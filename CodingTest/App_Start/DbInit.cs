using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CodingTest.Models;

namespace CodingTest
{
	public static class DbInit
	{
		public static async Task InitData()
		{
			using(var db = new Db())
			{
				await db.Database.ExecuteSqlCommandAsync("truncate table product");

				db.Products.Add(new Product
					{
						Name = "String",
						Cost = 9.99m,
						Description = "Buy this string. It's... really really good string. It's almost... rope."
					});

				db.Products.Add(new Product
					{
						Name = "Squiggly Spoon",
						Cost = 4.99m,
						Description = "Just imagine how much more ZANY life could be with a SQUIGGLE spoon! Now you're not just eating soup, you're UNIQUE!"
					});

				db.Products.Add(new Product
					{
						Name = "Really Ugly Doll",
						Cost = 16.99m,
						Description = "Have dinner guests coming over but just wish they'd go away? Place this vaguely inappropriate doll as a centerpiece to really stop the conversation. Hard to say what's wrong with it... there's just something... you know... eugh."
					});

				await db.SaveChangesAsync();
			}
		}
	}
}