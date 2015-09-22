using Autofac;

namespace BackgroundWorkingWithMVC.Application.Container
{
    public static class Bootstrapper
    {
        public static IContainer Container { get; private set; }

        public static IContainer Initialize()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new CurrentApplicationModule());
            builder.RegisterModule(new BackgroundWorkersModule());
            builder.RegisterModule(new CachingModule());
            builder.RegisterModule(new RepositoryModule());

            Container = builder.Build();
             
            return Container;
        }
    }
}