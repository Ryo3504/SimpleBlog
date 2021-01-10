using System.Web.Mvc;

namespace BlogLearning.App_Start
{
    public class Filteronfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
