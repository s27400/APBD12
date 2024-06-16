using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class ToDelDTO
{
    [Required]
    public int Id { get; set; }
}