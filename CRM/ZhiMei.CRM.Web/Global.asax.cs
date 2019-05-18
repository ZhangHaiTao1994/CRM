using System.Web.Mvc;
using System.Web.Routing;

namespace ZhiMei.CRM.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// ����Ӧ�ó���
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}