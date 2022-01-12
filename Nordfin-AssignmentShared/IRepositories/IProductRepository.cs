using Nordfin_AssignmentShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentShared.IRepositories
{
    public interface IProductRepository
    {
        List<Product> GetAllproducts();

    }
}
