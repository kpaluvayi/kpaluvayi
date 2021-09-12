using Sparcpoint.Models;
using Sparcpoint.Models.DomainDto.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sparcpoint.BusinessLayer.Product
{
    public interface IProductManager
    {
        Task<Products> AddProduct(ProductDto product);
        Task<List<Products>> SearchProduct(FilterModel filterModel);
    }
}