using Store.Entities;

namespace Store.WebUI.Models
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public List<Product>? Products { get; set; }

    }
}
