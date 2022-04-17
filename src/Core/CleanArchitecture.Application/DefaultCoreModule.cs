using Autofac;
using AutoMapper;
using CleanArchitecture.Application.Profiles;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application
{

    public class DefaultCoreModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        { 
            RegisterCommonDependencies(builder);
        }
        private void RegisterCommonDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<MappingProfile>().As<Profile>().InstancePerLifetimeScope();

            builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            var mediatrOpenTypes = new[]
            {
                typeof(IRequestHandler<,>),
                typeof(IRequestExceptionHandler<,,>),
                typeof(IRequestExceptionAction<,>),
                typeof(INotificationHandler<>),
            };

            //foreach (var mediatrOpenType in mediatrOpenTypes)
            //{
            //    builder
            //    .RegisterAssemblyTypes(_assemblies.ToArray())
            //    .AsClosedTypesOf(mediatrOpenType)
            //    .AsImplementedInterfaces();
            //}
        }

        private void RegisterDevelopmentOnlyDependencies(ContainerBuilder builder)
        {
            // TODO: Add development only services
        }

        private void RegisterProductionOnlyDependencies(ContainerBuilder builder)
        {
            // TODO: Add production only services
        }


    }
}


