using System.Web;
using System.Web.Mvc;

namespace JavaScriptIncludeFileFromAsp.net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
