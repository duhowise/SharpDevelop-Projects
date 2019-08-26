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
	/// <summary>
	/// Description of Lead.
	/// </summary>
	public class Lead:CustomerBase
	{
		public override void Validate()
		{
			if (Customername.Length==0) {
				throw new Exception("Customer Name is Required");
			}
			if (phoneNumber.Length==0)
			{
				throw new Exception("Customer phone is Required");
			}
		}
		
	}
}
