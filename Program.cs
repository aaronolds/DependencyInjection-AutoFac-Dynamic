using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Autofac.Core;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UsingAutoFac("DependencyInjection.Transitions.ITransition", "DependencyInjection.Transitions.ATransition");
        }

        private static void UsingAutoFac(string interfaceName, string assemblyName)
        {
            var builder = new ContainerBuilder();
            var typeFrom = Type.GetType(interfaceName, true);
            var typeTo = Type.GetType(assemblyName, true);

            List<NamedParameter> properties = new List<NamedParameter>();
            properties.Add(new NamedParameter("intProperty", 100));
            properties.Add(new NamedParameter("stringProperty", "I am a string"));
            properties.Add(new NamedParameter("dateTimeProperty", DateTime.Now));

            // builder.RegisterType(typeTo).As(typeFrom).WithProperty("IntProperty", 100);
            builder.RegisterType(typeTo).As(typeFrom).WithParameters(properties);

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var writer = scope.Resolve(typeFrom);
                System.Console.WriteLine(writer);
            }
        }
    }
}
