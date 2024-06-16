using WebApplication1.Entities;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Service;

public class ProductService : IProductService
{
    private readonly IProductRepo _productRepo;

    public ProductService(IProductRepo repo)
    {
        _productRepo = repo;
    }
    
    public async Task<IEnumerable<Product>> GetAll(CancellationToken token)
    {
        var res = await _productRepo.GetAllProducts(token);
        return res;
    }

    public async Task<string> Add(ProductDTO dto, CancellationToken token)
    {
        return await _productRepo.AddProduct(dto, token);
    }
    

}