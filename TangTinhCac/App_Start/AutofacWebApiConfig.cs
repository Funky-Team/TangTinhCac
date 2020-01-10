﻿using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using TangTinhCac.Services.DBFactory;
using TangTinhCac.Services.Idols;

namespace TangTinhCac.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<DBFactory>()
                      .As<IDBFactory>()
                      .InstancePerRequest();
            builder.RegisterType<IdolService>()
                      .As<IIdolService>()
                      .InstancePerRequest();
            builder.RegisterType<BodyService>()
                     .As<IBodyService>()
                     .InstancePerRequest();
            builder.RegisterType<BoobStatusService>()
                     .As<IBoobStatusService>()
                     .InstancePerRequest();
            builder.RegisterType<BraService>()
                     .As<IBraService>()
                     .InstancePerRequest();
            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}