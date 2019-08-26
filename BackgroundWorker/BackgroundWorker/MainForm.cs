/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 9/11/2016
 * Time: 9:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace BackgroundWorker
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
	
		void Button1Click(object sender, EventArgs e)
		{
			if (!backgroundWorker1.IsBusy) {
				backgroundWorker1.RunWorkerAsync();
			}else{label1.Text="Please Wait";}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (backgroundWorker1.IsBusy) {
				backgroundWorker1.CancelAsync();
			}
		}
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			int Sum = 0;
			for (int i = 0; i <= 100; i++) {
				Thread.Sleep(100);
				Sum = Sum + i;
				backgroundWorker1.ReportProgress(i);
				if (backgroundWorker1.CancellationPending) {
					e.Cancel = true;
					backgroundWorker1.ReportProgress(0);
					return;
				}
			}
			e.Result=Sum;
		}
		void BackgroundWorker1ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar1.Value=e.ProgressPercentage;
			label1.Text=e.ProgressPercentage.ToString() +"%";
			
		}
		void BackgroundWorker1RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled) {
				label1.Text="Processing Cancelled";
			}else if (e.Error!=null) {
				MessageBox.Show(e.Error.Message);
			} else {
				label1.Text="Sum="+e.Result.ToString(); 
				
			}
		}
	}
}
