using Autofac;

namespace Praxent.Service
{
    public static class Bootstrapper
    {
        public static ContainerBuilder AddServiceComponents(this ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(BasicDataService<>)).As(typeof(IBasicDataService<>));

            return builder;
        }
    }
}