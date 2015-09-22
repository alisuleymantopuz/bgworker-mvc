using Autofac;
using Autofac.Integration.Mvc;

namespace BackgroundWorkingWithMVC.Application.Container
{
    public class CurrentApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(System.Reflection.Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterFilterProvider();
        }
    }
}