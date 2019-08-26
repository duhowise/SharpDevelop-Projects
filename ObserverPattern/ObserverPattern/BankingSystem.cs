/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/20/2016
 * Time: 8:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace ObserverPattern
{
	/// <summary>
	/// Description of BankingSystem.
	/// </summary>
	public class BankingSystem
	{
		private List<IObserver>subscribers=new List<IObserver>();
		public void Subscribe(IObserver o){
			subscribers.Add(o);
		}
		public void UnSubscribe(IObserver o){
			subscribers.Remove(o);
		}
		public void NotifySubscribers(){
			foreach (IObserver o in subscribers) {
				o.Notify();
			}
		}
	}
}
