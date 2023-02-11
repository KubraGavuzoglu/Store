using Store.Data.Concrete;
using Store.Data;
using Store.Entities;
using Store.Service.Abstract;

namespace Store.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext _context) : base(_context)
        {
        }
    }
}
