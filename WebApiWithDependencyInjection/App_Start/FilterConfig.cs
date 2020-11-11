using System.Web;
using System.Web.Mvc;

namespace WebApiWithDependencyInjection
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
