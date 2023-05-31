namespace NLayerApp.Core.DTOs.Products
{
    public class ProductDto
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        // ? nullable aktif...
        public DateTime? UpdateDate { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public string Code { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public  string CatgoryName { get; set; }
    }
}
