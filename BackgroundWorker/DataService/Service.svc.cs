/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 9/11/2016
 * Time: 11:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ServiceModel;

namespace DataService
{
	[ServiceContract]
	public interface IService
	{
	   [OperationContract]
	   void MyOperation();
	}
	
	 
}
