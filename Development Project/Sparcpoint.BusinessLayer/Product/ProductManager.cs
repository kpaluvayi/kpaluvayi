using Sparcpoint.Models;
using Sparcpoint.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sparcpoint.Models.DomainDto.Product;
using Sparcpoint.Mappers.DomainToEntity;
using System.Linq;
namespace Sparcpoint.BusinessLayer.Product
{
    public class ProductManager :IProductManager
    {
        private readonly IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Products> AddProduct(ProductDto product) {
            //Mapping Domain Object to Entity Object
            var productEntity  = ProductEntityMapper.MapDomainToEntity(product);
            //InstanceId to be made common to avoid foreign key violation
            productEntity.Attributes.ToList().ForEach(x => x.InstanceId = productEntity.InstanceId);
            productEntity.Categories.ToList().ForEach(x => x.InstanceId = productEntity.InstanceId);
            var productAdded = await _productRepository.AddProduct(productEntity).ConfigureAwait(false);
            return productAdded;
        }
        public async Task<List<Products>> SearchProduct(FilterModel filterModel) {
            var productFiltered = await _productRepository.SearchProduct(filterModel).ConfigureAwait(false);
            return productFiltered;
        }
    }
}
