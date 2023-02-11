using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProductsByCategoriesBrandsAsync(); // Task bu metodun asenkron bir metot olduğunu belirtir
        Task<Product> GetProductByCategoriesBrandsAsync(int id);
    }
}
