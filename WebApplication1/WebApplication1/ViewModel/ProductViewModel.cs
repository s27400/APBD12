using WebApplication1.Entities;

namespace WebApplication1.ViewModel;

public class ProductViewModel
{
    public IEnumerable<Product> Products { get; set; }
    public int AmoutnOfProducts { get; set; }
}