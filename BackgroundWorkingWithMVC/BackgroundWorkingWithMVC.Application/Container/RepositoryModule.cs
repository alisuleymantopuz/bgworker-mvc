using Autofac;
using BackgroundWorkingWithMVC.Application.Helpers;

namespace BackgroundWorkingWithMVC.Application.Container
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryFakeDataHelper>().InstancePerLifetimeScope();
        }
    }
}