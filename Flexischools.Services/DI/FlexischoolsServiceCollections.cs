using Flexischools.Services.Services;
using Flexischools.Services.Services.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Flexischools.Services.DI
{
    public static class FlexischoolsServiceCollections
    {
        public static IServiceCollection AddFlexischoolsServices(this IServiceCollection services)
        {
            services.AddOptions();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddScoped<ISubjectService, SubjectService>();
            return services;
        }
    }
}
