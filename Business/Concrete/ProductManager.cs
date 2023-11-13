using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product product)
        {
            if (product.UnitPrice>10)
            {
            _productRepository.Add(product);
            }
        }

        public void Delete(int id)
        {
            Product getById = _productRepository.Get(p => p.Id == id);
            _productRepository.Delete(getById);
        }

        public void Update(Product product)
        {
            Product getById = _productRepository.Get(p => p.Id == product.Id);
            getById.Name=product.Name;
            getById.UnitPrice=product.UnitPrice;    
            getById.UnitInStock=product.UnitInStock;
            getById.Description=product.Description;
            _productRepository.Update(getById);
        }
        
    }
}
