/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/19/2016
 * Time: 3:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using StoreProject;
using System.Collections.Generic;

namespace CustomerFactory
{
	/// <summary>
	/// Factory Design Pattern
	/// </summary>
	public static class Factory
	{
			private static readonly Dictionary<String,CustomerBase>custormertypes=new Dictionary<String,CustomerBase>();
			public static CustomerBase Create(string typeofCustomer)
		{
			if (custormertypes.Count == 0) {
				custormertypes.Add("Customer", new Customer());
				custormertypes.Add("Lead", new Lead());
				
			}
		
			return custormertypes[typeofCustomer];
		}
		
		
		
	}
}
