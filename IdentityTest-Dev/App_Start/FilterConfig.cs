﻿using System.Web;
using System.Web.Mvc;

namespace IdentityTest_Dev
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
