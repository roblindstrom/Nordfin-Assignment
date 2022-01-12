using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nordfin_AssignmentData.Repositories;
using Nordfin_AssignmentShared.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentData
{
    public static class DataServiceRegistration
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Delivery service registration
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
