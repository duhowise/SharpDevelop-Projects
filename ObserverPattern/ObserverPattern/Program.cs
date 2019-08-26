/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/20/2016
 * Time: 7:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ObserverPattern
{
	class Program
	{
		public static void Main(string[] args)
		{
			BankingSystem RuralBankingSystem=new BankingSystem();
			RuralBank AmasieRuralBank=new RuralBank();
			Bank GhanaCommercialBank=new Bank();
			ATM AmansieReadyCashAtm=new ATM();
			ATM GhanaSpeedCashAtm=new ATM();
			
			RuralBankingSystem.Subscribe(AmasieRuralBank);
			RuralBankingSystem.Subscribe(GhanaCommercialBank);
			RuralBankingSystem.Subscribe(AmansieReadyCashAtm);
			RuralBankingSystem.Subscribe(GhanaSpeedCashAtm);
			
			RuralBankingSystem.NotifySubscribers();
			
			Console.ReadKey();
		}
	}
}