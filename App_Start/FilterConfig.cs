using System.Web;
using System.Web.Mvc;

namespace Bike_And_Fun_MVC_Proto_III
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}