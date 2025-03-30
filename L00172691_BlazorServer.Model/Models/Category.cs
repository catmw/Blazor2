using System.ComponentModel.DataAnnotations;

namespace L00172691_BlazorServer.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        
       
        public List<Product>? Products { get; set; } = new();
    }
}
