using HIS.Domain.Interfaces;
using HIS.Domain.Interfaces.Repository;
using HIS.Domain.Interfaces.Services;
using HIS.Infrastructure.Events;
using HIS.Infrastructure.Presestance;
using HIS.Infrastructure.Presestance.Repository;
using HIS.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Infrastructure.Configuration
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(connectionString));

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationDbContext).Assembly));

            services.AddScoped<IFileStorageService, FileStorageService>();
            services.AddScoped<IAntivirusScanner, AntivirusScanner>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDomainEventDispatcher , DomainEventDispatcher>();
            services.AddScoped(typeof(INotificationWrapper<>), typeof(NotificationWrapper<>));
            return services;
        }
    }
}
