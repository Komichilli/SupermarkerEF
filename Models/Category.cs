using Microsoft.Identity.Client;
using SupermarketEF.Models;

namespace SupermarkerEF.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}