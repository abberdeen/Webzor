using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop; 

namespace Webzor.Core.Extensions
{ 
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWebzor(this IServiceCollection services)
        {

            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CurrentCulture;

            return services;
        }
    }
}
