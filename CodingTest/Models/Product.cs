using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodingTest.Models
{
	public class Product
	{
		public int Id { get; set; }

		[MaxLength(300)]
		public string Name { get; set; }

		public decimal Cost { get; set; }

		[MaxLength(4000)]
		public string Description { get; set; }
	}
}