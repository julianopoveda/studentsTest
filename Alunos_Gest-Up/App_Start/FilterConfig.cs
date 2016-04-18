using System.Web;
using System.Web.Mvc;

namespace Alunos_Gest_Up
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
