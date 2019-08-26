/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/19/2016
 * Time: 2:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DesignPatterns
{
	partial class CustomerForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox CustomerType;
		private System.Windows.Forms.TextBox CustomerNametxt;
		private System.Windows.Forms.TextBox PhoneNumbertxt;
		private System.Windows.Forms.TextBox BillAmounttxt;
		private System.Windows.Forms.TextBox BillDatetxt;
		private System.Windows.Forms.TextBox Addresstxt;
		private System.Windows.Forms.Button Validation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		
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
			this.CustomerType = new System.Windows.Forms.ComboBox();
			this.CustomerNametxt = new System.Windows.Forms.TextBox();
			this.PhoneNumbertxt = new System.Windows.Forms.TextBox();
			this.BillAmounttxt = new System.Windows.Forms.TextBox();
			this.BillDatetxt = new System.Windows.Forms.TextBox();
			this.Addresstxt = new System.Windows.Forms.TextBox();
			this.Validation = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CustomerType
			// 
			this.CustomerType.FormattingEnabled = true;
			this.CustomerType.Location = new System.Drawing.Point(121, 45);
			this.CustomerType.Name = "CustomerType";
			this.CustomerType.Size = new System.Drawing.Size(121, 21);
			this.CustomerType.TabIndex = 0;
			this.CustomerType.SelectedIndexChanged += new System.EventHandler(this.CustomerTypeSelectedIndexChanged);
			// 
			// CustomerNametxt
			// 
			this.CustomerNametxt.Location = new System.Drawing.Point(121, 82);
			this.CustomerNametxt.Name = "CustomerNametxt";
			this.CustomerNametxt.Size = new System.Drawing.Size(177, 20);
			this.CustomerNametxt.TabIndex = 1;
			// 
			// PhoneNumbertxt
			// 
			this.PhoneNumbertxt.Location = new System.Drawing.Point(121, 121);
			this.PhoneNumbertxt.Name = "PhoneNumbertxt";
			this.PhoneNumbertxt.Size = new System.Drawing.Size(177, 20);
			this.PhoneNumbertxt.TabIndex = 2;
			// 
			// BillAmounttxt
			// 
			this.BillAmounttxt.Location = new System.Drawing.Point(461, 45);
			this.BillAmounttxt.Name = "BillAmounttxt";
			this.BillAmounttxt.Size = new System.Drawing.Size(177, 20);
			this.BillAmounttxt.TabIndex = 3;
			this.BillAmounttxt.Text = "0";
			// 
			// BillDatetxt
			// 
			this.BillDatetxt.Location = new System.Drawing.Point(461, 82);
			this.BillDatetxt.Name = "BillDatetxt";
			this.BillDatetxt.Size = new System.Drawing.Size(177, 20);
			this.BillDatetxt.TabIndex = 4;
			// 
			// Addresstxt
			// 
			this.Addresstxt.Location = new System.Drawing.Point(461, 121);
			this.Addresstxt.Multiline = true;
			this.Addresstxt.Name = "Addresstxt";
			this.Addresstxt.Size = new System.Drawing.Size(323, 134);
			this.Addresstxt.TabIndex = 5;
			// 
			// Validation
			// 
			this.Validation.Location = new System.Drawing.Point(709, 279);
			this.Validation.Name = "Validation";
			this.Validation.Size = new System.Drawing.Size(75, 23);
			this.Validation.TabIndex = 6;
			this.Validation.Text = "Validate";
			this.Validation.UseVisualStyleBackColor = true;
			this.Validation.Click += new System.EventHandler(this.ValidationClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Customer Type";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Customer Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(355, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Bill Amount";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(15, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Phone Number";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(355, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Bill Date";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(355, 124);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Address";
			// 
			// CustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 315);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Validation);
			this.Controls.Add(this.Addresstxt);
			this.Controls.Add(this.BillDatetxt);
			this.Controls.Add(this.BillAmounttxt);
			this.Controls.Add(this.PhoneNumbertxt);
			this.Controls.Add(this.CustomerNametxt);
			this.Controls.Add(this.CustomerType);
			this.Name = "CustomerForm";
			this.Text = "CustomerForm";
			this.Load += new System.EventHandler(this.CustomerFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
