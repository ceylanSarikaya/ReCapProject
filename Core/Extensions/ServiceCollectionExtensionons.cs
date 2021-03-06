using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
   public static class ServiceCollectionExtensionons
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection servicescollection,ICoreModule[] modules )
        {
            foreach (var modul in modules)
            {
                modul.Load(servicescollection);
            }
            return ServiceTool.Create(servicescollection);
        }
    }
}
