using System.Xml.Linq;

namespace ShopBackend.Helpers
{
    public static class FakeDatabase
    {
        public static List<Product> _products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Кепка BunkerDev 2",
                Price = 900
            },
            new Product()
            {
                Id = 2,
                Name = "Худи Limited",
                Price = 1700
            },
            new Product()
            {
                Id = 3,
                Name = "Кроссовки Limited",
                Price = 10000
            },
            new Product()
            {
                Id = 4,
                Name = "Штаны Limited",
                Price = 3000
            }
        };
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Price { get; set; }
    }
}
