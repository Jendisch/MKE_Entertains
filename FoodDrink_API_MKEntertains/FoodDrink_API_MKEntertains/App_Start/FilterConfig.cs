using System.Web;
using System.Web.Mvc;

namespace FoodDrink_API_MKEntertains
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
