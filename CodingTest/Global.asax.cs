﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Brass9.Threading.TPL;
using System.Data.Entity;
using CodingTest.Models;

namespace CodingTest
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
            Database.SetInitializer<Db>(null);

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			TaskHelper.RunBg(DbInit.InitData);
		}
	}
}
