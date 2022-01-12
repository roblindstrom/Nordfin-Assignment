using Nordfin_AssignmentShared.ResponseModels;

namespace Nordfin_AssignmentServices.Services.ProductServices
{
    public interface IProductService
    {
        List<ProductResponse> GetAllProducts();
    }
}