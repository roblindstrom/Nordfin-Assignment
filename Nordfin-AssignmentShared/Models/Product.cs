using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentShared.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public List<DayOfWeek>? DeliveryDays { get; set; }
        public ProductType ProductType { get; set; }
        public int DaysInAdvance { get; set; }
    }
}
