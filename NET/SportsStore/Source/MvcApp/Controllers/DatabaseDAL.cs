
using System.Collections.Generic;
using System.Linq;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class DatabaseDAL
    {
        private static SportsStoreEntities dbEntity = new SportsStoreEntities();

        public static IQueryable<Product> GetAllProducts()
        {
            return dbEntity.Products.OrderBy(c => c.Name);
        }

        public static IQueryable<ProductModel> GetAllProductModels()
        {
            IList<ProductModel> productModels = new List<ProductModel>();
            foreach (var p in GetAllProducts())
            {
                productModels.Add(new ProductModel()
                                      {
                                          ProductID = p.ProductID,
                                          Name = p.Name,
                                          Description = p.Description,
                                          Price=p.Price,
                                          Action = "Add to Cart"
                                      });
            }

            return productModels.AsQueryable();
        }

        public static Product GetProductByProductID(int productId)
        {
            return dbEntity.Products.FirstOrDefault(p => p.ProductID==productId);
        }
    }
}