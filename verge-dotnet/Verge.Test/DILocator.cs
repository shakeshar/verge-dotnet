using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Verge.Core;
using Verge.Core.Client;


namespace Verge.Test
{
    public static class DILocator
    {

        private static ServiceProvider serviceProvider;
        private static ServiceCollection serviceProviderCollection;
        static DILocator()
        {
            serviceProviderCollection = new ServiceCollection();
            Func<IServiceProvider, IAppSettings> appsettings = new Func<IServiceProvider, IAppSettings>((px) =>
            {
                var assembly = Assembly.GetAssembly(typeof(DILocator)) ;
               
                FileInfo fi = new FileInfo(assembly.Location);
                string appConfigPath = Path.Combine(fi.Directory.FullName, "appConfig.json");
                IAppSettings settings = new AppSettings(appConfigPath);
                return settings;
            });
          
            serviceProvider = serviceProviderCollection.BuildServiceProvider();
            serviceProviderCollection.AddSingleton<IAppSettings>(appsettings);
            serviceProviderCollection.AddSingleton<IVergeClient, VergeClient>();


            serviceProvider = serviceProviderCollection.BuildServiceProvider();
        }
        public static T Resolve<T>()
        {            
            return serviceProvider.GetService<T>();
        }
        public static object Resolve(Type t)
        {
            return serviceProvider.GetService(t);
        }
    }
}
