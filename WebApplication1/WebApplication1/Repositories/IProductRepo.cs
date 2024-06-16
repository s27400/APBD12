using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Repositories;

public interface IProductRepo
{
    public Task<IEnumerable<Product>> GetAllProducts(CancellationToken token);
    public Task<string> AddProduct(ProductDTO dto, CancellationToken token);
}