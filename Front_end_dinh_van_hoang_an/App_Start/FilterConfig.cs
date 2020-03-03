using System.Web;
using System.Web.Mvc;

namespace Front_end_dinh_van_hoang_an
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
