using AutoMapper;
using Nordfin_AssignmentShared.IRepositories;
using Nordfin_AssignmentShared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentServices.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? throw new ArgumentException(nameof(productRepository));
            _mapper = mapper ?? throw new ArgumentException(nameof(mapper));
        }

        public List<ProductResponse> GetAllProducts()
        {
            var products = _productRepository.GetAllproducts();
            return _mapper.Map<List<ProductResponse>>(products);
        }
    }
}
