using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class ProductDTO
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(40)]
    public string Quality { get; set; }
}