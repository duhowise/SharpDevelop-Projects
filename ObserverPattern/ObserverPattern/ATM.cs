/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/20/2016
 * Time: 7:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ObserverPattern
{
	/// <summary>
	/// Description of ATM.
	/// </summary>
	public class ATM:IObserver
	{
		#region IObserver implementation

	public void Notify()
	{
		Console.WriteLine("Cash Withrawn");
	}

	#endregion

		public ATM()
		{
		}
		
	}
}
