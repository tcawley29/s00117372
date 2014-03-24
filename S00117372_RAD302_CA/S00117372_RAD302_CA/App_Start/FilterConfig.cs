using System.Web;
using System.Web.Mvc;

namespace S00117372_RAD302_CA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}