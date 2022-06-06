
using Autofac;

using AutoMapper;

namespace WpfApp
{
    internal static class Bootstrapper
    {
        internal static void StartUp()
        {
            CreateContainer();
            CreateMapper();
        }

        public static IContainer Container { get; private set; }
        public static IMapper Mapper { get; private set; }

        private static void CreateMapper()
        {
            var mapConfig = new MapperConfiguration(
                x =>
                {
                    x.AddProfile<AutoMapperProfile.AutoMapperProfile>();
                });
            mapConfig.AssertConfigurationIsValid();
            Mapper = mapConfig.CreateMapper();
        }

        private static void CreateContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new IoC.ServiceRegistration());
            Container = builder.Build();
        }
    }
}
