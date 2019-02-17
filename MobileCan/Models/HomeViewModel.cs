using MobileCan.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace MobileCan.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }

    public class ProductViewModel
    {
        public static ProductViewModel Map(Product product)
        {
            return new ProductViewModel()
            {
                Name = product.Name,
                Price = ((double)product.Price).ToString("C", CultureInfo.CurrentCulture),
                Rating = product.Rating.HasValue ? product.Rating.Value.ToStars() : ((double)0).ToStars(),
                Description = "Some description",
                Images = product.Images?.Select(x => x.ImageUrl).ToList(),
                Id = product.ProductId,
                Reviews = product.Reviews.ToList()
            };
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public List<string> Images { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Review> Reviews { get; set; }
    }
}