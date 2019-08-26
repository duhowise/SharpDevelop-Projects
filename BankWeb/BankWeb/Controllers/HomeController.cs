/*
 * Created by SharpDevelop.
 * User: DUHO
 * Date: 8/4/2016
 * Time: 12:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Web.Mvc;

namespace BankWeb.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		
		public ActionResult Contact()
		{
			return View();
		}
	}
}
