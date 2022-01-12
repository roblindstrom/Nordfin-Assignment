using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nordfin_AssignmentData;
using Nordfin_AssignmentServices.Services.DeliveryServices;
using Nordfin_AssignmentServices.Services.ProductServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentServices
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Delivery service registration
            services.AddScoped<IDeliveryService, DeliveryService>();

            //Product service registration
            services.AddScoped<IProductService, ProductService>();

            services.AddDataServices(configuration);

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
