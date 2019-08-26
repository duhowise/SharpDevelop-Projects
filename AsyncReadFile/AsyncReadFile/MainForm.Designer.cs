/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 11/5/2016
 * Time: 8:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AsyncReadFile
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Label Info;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRead = new System.Windows.Forms.Button();
			this.Info = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(133, 91);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(180, 64);
			this.btnRead.TabIndex = 0;
			this.btnRead.Text = "Read File";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.BtnReadClick);
			// 
			// Info
			// 
			this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Info.Location = new System.Drawing.Point(29, 176);
			this.Info.Name = "Info";
			this.Info.Size = new System.Drawing.Size(392, 23);
			this.Info.TabIndex = 1;
			this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 270);
			this.Controls.Add(this.Info);
			this.Controls.Add(this.btnRead);
			this.Name = "MainForm";
			this.Text = "AsyncReadFile";
			this.ResumeLayout(false);

		}
	}
}
