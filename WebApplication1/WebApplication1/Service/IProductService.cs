using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Service;

public interface IProductService
{
    public Task<IEnumerable<Product>> GetAll(CancellationToken token);
    public Task<string> Add(ProductDTO dto,CancellationToken token);

}