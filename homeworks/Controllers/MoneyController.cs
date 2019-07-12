using homeworks.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homeworks.Controllers
{
	public class MoneyController : Controller
	{
		// GET: Money
		public ActionResult Money()
		{
			List<AccountViewModel> viewModels = new List<AccountViewModel> { };

			Random rnd = new Random();
			for (int i = 1; i <= 100; i++)
			{
				AccountViewModel data = new AccountViewModel
				{
					No = i,
					Cost = rnd.Next(10000).ToString("###,###"),
					CostDate = DateTime.Now.AddDays(-(rnd.Next(100))).ToString("yyyy-MM-dd"),
					Type = rnd.Next(2) == 1 ? "支出" : "收入"
				};
				viewModels.Add(data);
			}
			return View(viewModels);
		}
	}
}

