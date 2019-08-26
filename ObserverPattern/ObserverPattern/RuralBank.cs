/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/20/2016
 * Time: 8:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ObserverPattern
{
	/// <summary>
	/// Description of RuralBank.
	/// </summary>
	public class RuralBank:IObserver
	{
		#region IObserver implementation

	public void Notify()
	{
		Console.WriteLine("Tractor Loan Processed");
		
	}

	#endregion

		public RuralBank()
		{
		}
	}
}
