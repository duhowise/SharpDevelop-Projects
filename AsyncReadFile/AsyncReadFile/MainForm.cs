/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 11/5/2016
 * Time: 8:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncReadFile
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{			
			InitializeComponent();
			
		}
		public int CountCharacters(){
			int count=0;
			using (StreamReader reader=new StreamReader(@"D:\\File.txt")) {
				string content=reader.ReadToEnd();
				count=content.Length;
				Thread.Sleep(5000);
			} 
			return count;
		}
		private async void  BtnReadClick(object sender, EventArgs e)
		{
			Task<int> task =new Task<int>(CountCharacters);
			task.Start();
			Info.Text="Processing File, Please Wait.....";
			var count=await task;
			Info.Text=count.ToString() +" "+"Characters in file";
		}
	}
}
