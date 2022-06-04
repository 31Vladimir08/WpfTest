
using Autofac;

using AutoMapper;

using WpfApp.IoC;

namespace WpfApp
{
    internal class Bootstrapper
    {
        internal Bootstrapper()
        {
            CreateContainer();
            CreateMapper();
        }

        public static IContainer Container { get; private set; }
        public static IMapper Mapper { get; private set; }

        private void CreateMapper()
        {
            var mapConfig = new MapperConfiguration(
                x =>
                {
                    x.AddProfile<AutoMapperProfile.AutoMapperProfile>();
                });
            mapConfig.AssertConfigurationIsValid();
            Mapper = mapConfig.CreateMapper();
        }

        private void CreateContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new IoC.ServiceRegistration());
            Container = builder.Build();
        }
    }
}
