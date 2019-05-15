using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Treehouse.FitnessFrog.App_Start
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new RequireHttpsAttribute());
            filters.Add(new AuthorizeAttribute());
        }
    }
}