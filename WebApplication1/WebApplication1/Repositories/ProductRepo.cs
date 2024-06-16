using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Repositories;

public class ProductRepo : IProductRepo
{
    private readonly ProductDbContext _context;

    public ProductRepo(ProductDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllProducts(CancellationToken token)
    {
        return await _context.Products.Select(x => new Product()
        {
            IdProduct = x.IdProduct, Name = x.Name, Quality = x.Quality
        }).ToListAsync(token);
    }

    public async Task<string> AddProduct(ProductDTO dto, CancellationToken token)
    {
        await _context.Products.AddAsync(new Product() { Name = dto.Name, Quality = dto.Quality }, token);
        await _context.SaveChangesAsync(token);
        return "Success";
    }
    

}