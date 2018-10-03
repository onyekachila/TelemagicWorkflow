using System.Web;
using System.Web.Mvc;

namespace TelemagicWorkflow
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
