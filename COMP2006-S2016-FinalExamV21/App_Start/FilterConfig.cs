using System.Web;
using System.Web.Mvc;

namespace COMP2006_S2016_FinalExamV21
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
