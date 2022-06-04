
using Autofac;

using AutoMapper;

using WpfApp.Services.Interfaces;
using WpfApp.Services.Services;

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
