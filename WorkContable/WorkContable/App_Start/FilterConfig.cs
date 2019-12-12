﻿using System.Web;
using System.Web.Mvc;

namespace WorkContable
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filtros.Verificacion());
        }
    }
}
