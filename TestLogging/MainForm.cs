/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 3/2/17
 * Time: 3:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestLogging
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			try {
				string samuel="Something";
				samuel=null;
			} catch (Exception ec) {
				Logging.LogError(samuel,ec);
			}
		}
	}
}

