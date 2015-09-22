using Autofac;
using BackgroundWorkingWithMVC.Application.BackgroudWorkers.CacheWorkers;

namespace BackgroundWorkingWithMVC.Application.Container
{
    public class BackgroundWorkersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoriesCacheWorker>().InstancePerLifetimeScope(); 
        }
    }
}