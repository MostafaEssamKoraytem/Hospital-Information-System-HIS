using HIS.API.Endpoints;
using HIS.API.Endpoints.Patient;

namespace HIS.API.Configuration
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            //services.AddScoped<IEndPoint, CreatePatientEndPoint>();
            //services.AddScoped<IEndPoint, GetPatientByIdEndPoint>();
            //services.AddScoped<IEndPoint, UpdatePatientEndPoint>();
            return services;
        }

        public static IApplicationBuilder MapPatientEndpoints(this WebApplication app)
        {
            var endpoints = app.Services.GetRequiredService<IEnumerable<IEndPoint>>();

            foreach (var endpoint in endpoints)
            {
                endpoint.MapEndPoint(app);
            }

            return app;
        }
    }
}
