using Swagger.Net.Application;
using System.Web.Http;

namespace THS.MES.MAS.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            // config.MapHttpAttributeRoutes();
            //
            // config.Routes.MapHttpRoute(
            //     name: "DefaultApi",
            //     routeTemplate: "api/{controller}/{id}",
            //     defaults: new { id = RouteParameter.Optional }
            // );
            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                                       "DefaultApi",
                                       "api/{controller}/{id}",
                                       new {id = RouteParameter.Optional}
                                      );
            //Set Swagger as default start page
            config.Routes.MapHttpRoute(
                                       "swagger_root",
                                       "",
                                       null,
                                       null,
                                       new RedirectHandler(message => message.RequestUri.ToString(), "swagger"));
        }
    }
}
