using Autofac;
using Abstracciones;
using Implementacion;

namespace Proyecto
{
    internal class ConfiguracionIoC
    {
        public static IContainer GenerarContenedor()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Multiplicar>().As<IMultiplicador>();
            return builder.Build();
        }
    }
}