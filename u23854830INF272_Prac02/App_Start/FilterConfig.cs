﻿using System.Web;
using System.Web.Mvc;

namespace u23854830INF272_Prac02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
