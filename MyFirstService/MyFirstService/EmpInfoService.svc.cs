/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 9/23/2016
 * Time: 11:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ServiceModel;

namespace MyFirstService
{
	[ServiceContract]
	public interface IEmpInfoService
	{
		[OperationContract]
		void MyOperation();
	}

	/// <summary>
	/// Description of EmpInfoService.
	/// </summary>
	public class EmpInfoService : IEmpInfoService
	{
		public void MyOperation()
		{
			// implement the operation
		}
	}
}
