/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/19/2016
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
namespace StoreProject
{
	public class CustomerBase
	{
		public string Customername { get; set; }
		public string phoneNumber { get; set; }
		public Decimal BillAmount { get; set; }
		public DateTime BillDate { get; set; }
		public string Address { get; set; }
		public virtual void Validate()
		{
			throw new NotImplementedException("Not Implemented");
		}
		
	}
}


