using Microsoft.EntityFrameworkCore;
using Store.Data.Abstract;
using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Concrete
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DatabaseContext _context) : base(_context)
        {
        }

        public async Task<Category> GetCategoryByProducts(int id)
        {
            return await context.Categories.Where(k => k.Id == id).AsNoTracking().Include(p => p.Products).FirstOrDefaultAsync(); // context üzerindeki kategorilerden id si bu metoda gönderilen id ile eşleşen kaydı bul ve bu kaydı izleme (AsNoTracking), bulduğun kategorinin ürünlerini de include ile join le birleştir ve ilk kaydı metodun çağrıldığı yere döndür.
        }
    }
}
