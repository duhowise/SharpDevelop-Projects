/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/20/2016
 * Time: 7:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ObserverPattern
{
	/// <summary>
	/// Description of Bank.
	/// </summary>
	public class Bank:IObserver
	{
		#region IObserver implementation

	public void Notify()
	{
	}

	#endregion

		public Bank()
		{
		Console.WriteLine("User Details Updated");
			
		}
	}
}
