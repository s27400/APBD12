using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Service;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    
    
    [HttpGet]
    public async Task<IActionResult> Index(CancellationToken token)
    {
        var list = await _productService.GetAll(token);
        var vm = new ProductViewModel()
        {
            Products = list,
            AmoutnOfProducts = list.Count()
        };
        return View(vm);
    }
    
    public IActionResult Create()
    {
        
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductDTO dto, CancellationToken token)
    {
        if (ModelState.IsValid)
        {
            await _productService.Add(dto, token);
            return RedirectToAction("Index");
        }

        return View();
    }
    
}