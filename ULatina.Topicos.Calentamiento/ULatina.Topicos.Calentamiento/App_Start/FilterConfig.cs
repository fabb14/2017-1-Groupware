using System.Web;
using System.Web.Mvc;

namespace ULatina.Topicos.Calentamiento
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
