/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/19/2016
 * Time: 2:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using CustomerFactory;
using StoreProject;

namespace DesignPatterns
{
	/// <summary>
	/// Description of CustomerForm.
	/// </summary>
	public partial class CustomerForm : Form
	{
		private CustomerBase customer=null;
			
		public CustomerForm()
		{
			
			InitializeComponent();
			CustomerType.Items.Add("Customer");
			CustomerType.Items.Add("Lead");
		
			
		}
		void CustomerTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			customer=Factory.Create(CustomerType.Text);
				
		}
		void ValidationClick(object sender, EventArgs e)
		{
			try {
				customer.Address = Addresstxt.Text;
				customer.BillAmount = Convert.ToDecimal(BillAmounttxt.Text);
				customer.BillDate = Convert.ToDateTime(BillDatetxt.Text);
				customer.Customername = CustomerNametxt.Text;
				customer.phoneNumber = PhoneNumbertxt.Text;
				customer.Validate();
			} catch (Exception exception) {
				MessageBox.Show(exception.Message);
			}
		}
		void CustomerFormLoad(object sender, EventArgs e)
		{
			BillDatetxt.Text=DateTime.Now.ToShortDateString();
		}
	}
}
