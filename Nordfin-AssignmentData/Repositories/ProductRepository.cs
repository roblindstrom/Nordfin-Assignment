using Nordfin_AssignmentShared.IRepositories;
using Nordfin_AssignmentShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentData.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllproducts()
        {
            var listOfProducts = new List<Product>()
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Apple",
                    ProductType = ProductType.Normal,
                    DaysInAdvance = 2,
                    DeliveryDays = new List<DayOfWeek>()
                    {
                        DayOfWeek.Monday,
                        DayOfWeek.Friday,
                    }
                },
                 new Product
                {
                    ProductId = 2,
                    Name = "Banana",
                    ProductType = ProductType.Normal,
                    DaysInAdvance = 2,
                    DeliveryDays = new List<DayOfWeek>()
                    {
                        DayOfWeek.Monday,
                        DayOfWeek.Friday,
                    }
                },

                  new Product
                {
                    ProductId = 3,
                    Name = "Tomato",
                    ProductType = ProductType.Normal,
                    DaysInAdvance = 2,
                    DeliveryDays = new List<DayOfWeek>()
                    {
                        DayOfWeek.Sunday,
                        DayOfWeek.Wednesday
                    }
                },
                  new Product
                {
                    ProductId = 4,
                    Name = "Onion",
                    ProductType = ProductType.Normal,
                    DaysInAdvance = 2,
                    DeliveryDays = new List<DayOfWeek>()
                    {
                        DayOfWeek.Sunday

                    }
                },
            };


            return listOfProducts;
        }
    }
}
