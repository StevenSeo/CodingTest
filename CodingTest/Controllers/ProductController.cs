using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using CodingTest.Models;

namespace CodingTest.Controllers
{
	public class ProductController : Controller
	{
		public async Task<ViewResult> Detail(string id)
		{
			Product product;
			using(var db = new Db())
			{
				//var query = db.Database.SqlQuery<Product>("SQL...");
				product = await db.Products.FirstOrDefaultAsync();
			}
			return View(product);
		}
	}
}