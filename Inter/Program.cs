/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/14/17
 * Time: 2:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inter
{
	class Program
	{
		public static void Main(string[] args)
		{
			    using Microsoft.Win32;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Security.Principal;
    using System.Text;
    using System.Windows.Forms;

           
            private void Patch()
            {
                DateTime start = DateTime.Now;

                if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)))
                {
                    MessageBox.Show("Patcher must be run as admin !", "Generic Patcher for VistaDB v5.x", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    return;
                }

                Process[] pname = Process.GetProcessesByName("devenv");
                if (pname.Length != 0)
                {
                    MessageBox.Show("Please close Visual Studio !", "Generic Patcher for VistaDB v5.x", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    return;
                }

                String[] aSearch = new string[3];
                String[] aReplace = new string[3];
                string InstDir = Path.GetDirectoryName(Application.ExecutablePath);
                string strWoW64 = "";
                List<string> PatchList = new List<string>();
                int nLocs = 0, nCount = 0, numPatt = 0, nSum = 4;
                string strLog = "";

                if (Directory.Exists(@"C:\Program Files (x86)")) strWoW64 = @"\Wow6432Node";
                String RegKey = "SOFTWARE" + strWoW64 + @"\Gibraltar Software\VistaDB 5";
                RegistryKey key = Registry.LocalMachine.OpenSubKey(RegKey);
                if (key != null)
                {
                    object obj2 = null;
                    try
                    {
                        obj2 = key.GetValue("Path");
                    }
                    finally
                    {
                        key.Close();
                    }
                    if (obj2 != null)
                    {
                        InstDir = obj2.ToString();
                        string lastChar = InstDir.Substring(InstDir.Length - 1);
                        if (lastChar == "\\") InstDir = InstDir.Substring(0, InstDir.Length - 1);
                    }
                }

                string[] searchPatterns = new String[] { "DataBuilder.exe", "VistaDB.5.VisualStudio.NET40.dll" };
                foreach (string pattern in searchPatterns)
                    PatchList.AddRange(Directory.GetFiles(InstDir, pattern, SearchOption.AllDirectories));


                if (PatchList.Count == 0)
                {
                    MessageBox.Show("No VistaDB files found !", "Generic Patcher for VistaDB v5.x", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    return;
                }

                foreach (string filename in PatchList)
                {
                    //Backup
                    if (!File.Exists(filename + ".bak"))
                        File.Copy(filename, filename + ".bak", true);

                    byte[] fileBytes = File.ReadAllBytes(filename);

                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in fileBytes)
                    {
                        sb.Append(String.Format("{0:X2}", b));
                    }
                    string strFile = sb.ToString();

                    if (filename.ToUpper().IndexOf("VISUALSTUDIO.") >= 0)
                    {
                        numPatt = 1;
                        aSearch[0] = "160A72";
                        aReplace[0] = "172A72";

                        //Bug in v5.2.0.1555: Resource Name must be changed from
                        //VistaDB.Ado.DataObjectSupport.xml to VistaDB.DataObjectSupport.xml

                        //V.i.s.t.a.D.B...D.a.t.a.O.b.j.e.c.t.S.u.p.p.o.r.t
                        int posBug11 = strFile.IndexOf("56006900730074006100440042002E0044006100740061004F0062006A0065006300740053007500700070006F00720074");

                        //VistaDB.Ado.DataObjectSupport.xml
                        int posBug12 = strFile.IndexOf("566973746144422E41646F2E446174614F626A656374537570706F72742E786D6C00");

                        if ((posBug11 > 0) && (posBug12 > 0))
                        {
                            numPatt = 2;
                            nSum = 5;
                            aSearch[1] = "566973746144422E41646F2E446174614F626A656374537570706F72742E786D6C00";
                            aReplace[1] = "566973746144422E446174614F626A656374537570706F72742E786D6C0000000000";
                        }
                    }

                    if (filename.ToUpper().IndexOf("DATABUILDER.EXE") >= 0)
                    {
                        numPatt = 3;

                        // Pattern 1
                        aSearch[0] = "160A0217";
                        aReplace[0] = "172A0217";

                        // Pattern 2
                        aSearch[1] = "160A72";
                        aReplace[1] = "172A72";

                        // Pattern 3
                        try
                        {
                            int posX = strFile.IndexOf("162A170B160C140D02", 0);
                            if (posX != -1)
                            {
                                int pos1 = strFile.Substring(0, posX).LastIndexOf("171200");
                                int pos3 = pos1;
                                aSearch[2] = strFile.Substring(pos1, 52);
                                posX = strFile.IndexOf("0004166F", pos1 + 10);
                                pos1 = strFile.Substring(0, posX).LastIndexOf("027B");
                                int pos4 = strFile.IndexOf("6F", pos3 + 52);
                                int XX = pos4 - pos3 - 52;
                                aReplace[2] = strFile.Substring(pos1, 48) + "172A";
                                if (XX > 0)
                                {
                                    for (int i = 0; i < XX; ++i)
                                    {
                                        aReplace[2] = aReplace[2] + "0";
                                    }
                                }
                            }
                            else
                            {
                               numPatt = 2;
                            }
                        }
                        catch
                        {
                            numPatt = 2;
                        }                 

                    }

                    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Write);
                    for (int i = 0; i < numPatt; ++i)
                    {
                        byte[] bReplace = new byte[aReplace[i].Length >> 1];
                        for (int j = 0; j < aReplace[i].Length >> 1; ++j)
                        {
                            bReplace[j] = (byte)Int32.Parse(aReplace[i].Substring(j * 2, 2), NumberStyles.HexNumber);
                        }

                        int pos = strFile.IndexOf(aSearch[i], 0);
                        if (pos > 0)
                        {
                            fs.Seek(pos / 2, 0);
                            fs.Write(bReplace, 0, bReplace.Length);
                            nLocs++;
                            if (i == 0)
                            {
                                nCount++;
                                strLog = strLog + nCount.ToString() + ": " + filename + "\r\n\r\n";
                            }
                        }
                    }
                    fs.Close();
                }
                DateTime end = DateTime.Now;
                int nDiff = ((int)(end - start).TotalMilliseconds);

                MessageBox.Show("Patching finished ! \r\n >>> " + nLocs.ToString() + " locations of " + nSum.ToString() + " patched in " + nCount.ToString() + " files in " + nDiff.ToString() + " milliseconds: \r\n\r\n" + strLog, "Generic Patcher for VistaDB v5.x", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

		}
	}
	
	class A
	{
		public A(string text)
		{
			B b=new B();
		}
		
	}
	class B
		{
			static A a1 = new A("a1");
			A a2 = new A("a2");
			static B()
			{
				a2 = new A("a3");
			}
		public B()
		{
			a2=new A("a4");
		}	
		}
}
}