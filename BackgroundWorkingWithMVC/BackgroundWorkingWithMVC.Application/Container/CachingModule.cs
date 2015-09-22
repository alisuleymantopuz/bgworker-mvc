using Autofac;
using BackgroundWorkingWithMVC.Application.Caching;

namespace BackgroundWorkingWithMVC.Application.Container
{
    public class CachingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DefaultCacheProvider>().InstancePerLifetimeScope();
            builder.RegisterType<CategoriesCachingHelper>().InstancePerLifetimeScope();
        }
    }
}