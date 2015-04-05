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
            Dictionary<string, Product> products = new Dictionary<string, Product>();

			Product product = new Product();

			using(var db = new Db())
			{
				//var query = db.Database.SqlQuery<Product>("SQL...");
			//	product = await db.Products.FirstOrDefaultAsync();
                products = await db.Products.ToDictionaryAsync(item => item.Id.ToString());
			}

            foreach (KeyValuePair<string, Product> entry in products)
            {
                if (entry.Key == id)
                    product = entry.Value;
            }

			return View(product);
		}
	}
}