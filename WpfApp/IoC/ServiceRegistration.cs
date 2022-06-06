
using Autofac;

using WpfApp.Interfaces.Services;
using WpfApp.Services;

namespace WpfApp.IoC
{
    internal class ServiceRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<СontractService>().As<IСontractService>();
        }
    }
}
