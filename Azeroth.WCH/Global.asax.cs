using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;

namespace Azeroth.WCH
{
    public class MvcApplication : System.Web.HttpApplication
    {

        static Autofac.IContainer Container = new Autofac.ContainerBuilder().Build();

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            System.Web.Mvc.GlobalFilters.Filters.Add(new ErrorHandler());

            AutofacInit();
            
        }

        private void AutofacInit()
        {
            Type flagMeta = typeof(Model.IAutofacFlag);
            //bin下的所有程序集
            System.Reflection.Assembly[] allAssembly = AppDomain.CurrentDomain.GetAssemblies().ToArray();
            //标识接口派生的类和接口
            var allMeta = allAssembly.SelectMany(x => x.GetTypes()).Where(x => flagMeta.IsAssignableFrom(x) && x != flagMeta).ToArray();

            var builder = new Autofac.ContainerBuilder();

            builder.RegisterTypes(allMeta)
                .AsSelf()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope()
                .PropertiesAutowired();//PropertiesAutowired注册为属性注入类型，所有实现IAutofacFlag的注册为InstancePerLifetimeScope生命周期
            builder.Update(Container);

            builder = new ContainerBuilder();
            builder.RegisterControllers(allAssembly)
                .AsSelf()
                .InstancePerLifetimeScope()
                .PropertiesAutowired();
            builder.Update(Container);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
        }
    }

    public class ErrorHandler:System.Web.Mvc.HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            
            base.OnException(filterContext);
        }
    }
}
