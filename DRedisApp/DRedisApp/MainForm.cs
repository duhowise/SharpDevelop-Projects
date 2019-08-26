/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 11/7/2016
 * Time: 2:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DRedisApp
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
		}
	}
	
	public class Phone{
		
		public string Id { get; set; }
		public string Model { get; set; }
		public string  Manufacturer { get; set; }
	
	}
}
