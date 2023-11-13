using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProductRepository:EfEntityRepositoryBase<Product,AppDbContext>,IProductRepository
    {

    }
}
