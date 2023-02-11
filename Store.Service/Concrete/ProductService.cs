using Store.Data.Concrete;
using Store.Data;
using Store.Service.Abstract;

namespace Store.Service.Concrete
{
    public class ProductService : ProductRepository, IProductService
    {
        public ProductService(DatabaseContext _context) : base(_context)
        {
        }
    }
}
