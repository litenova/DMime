using Dmime.Abstractions;
using Dmime.Detector;
using Dmime.Registry;
using Microsoft.Extensions.DependencyInjection;

namespace Dmime.Extensions.MicrosoftDependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMimeDetector(this IServiceCollection services)
        {
            services.AddSingleton(SignatureRegistryAccessor.Registry);
            services.AddTransient<IMimeDetector, MimeDetector>();
        }
    }
}