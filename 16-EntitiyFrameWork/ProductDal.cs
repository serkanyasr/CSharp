using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.AccessControl;

namespace EntitiyFrameWork
{
    // ProductDal class for handling CRUD operations on the Product entity using Entity Framework
    public class ProductDal
    {
        // Method to get all products from the database
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        // Method to get products containing a specific keyword in their names
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        // Method to get products within a specific price range
        public List<Product> GetByUnitPrice(decimal minPrice, decimal maxPrice)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice > minPrice && p.UnitPrice < maxPrice).ToList();
            }
        }

        // Method to get a product by its ID
        public Product GetByID(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
                // SingleOrDefault() can be used if expecting only one product, but it may throw an error if multiple results are found.
            }
        }

        // Method to add a new product
        public void Add(Product product)
        {
            using (ETradeContext ctx = new ETradeContext())
            {
                ctx.Products.Add(product);
                // Alternatively, you can use the following lines for adding:
                // var entity = ctx.Entry(product);
                // entity.State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        // Method to update a product
        public void Update(Product product)
        {
            using (ETradeContext ctx = new ETradeContext())
            {
                var entity = ctx.Entry(product);
                entity.State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        // Method to delete a product
        public void Delete(Product product)
        {
            using (ETradeContext ctx = new ETradeContext())
            {
                var entity = ctx.Entry(product);
                entity.State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }
    }
}
