using Bware.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Bware.Repository
{
    public class ProductServices : IProductServices
    {
        private BwareContext _context;
        public ProductServices(BwareContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetAllProductsForMale()
        {
            var products = await _context.Products.Where(x=>x.Sex=="Male").ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetAllProductsForFemale()
        {
            var products = await _context.Products.Where(x => x.Sex == "Female").ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetAllProductsForAll()
        {
            var products = await _context.Products.Where(x => x.Sex == "Unisex").ToListAsync();
            return products;
        }

       public async Task<Product> UpdateProducts(int id, Product product)
        {
            var products=await _context.Products.FirstOrDefaultAsync(x=>x.ProductId==id);
            products.ProductPrice = product.ProductPrice;
            products.ProductName = product.ProductName;
            products.ProductQuantity = product.ProductQuantity;
            products.ProductBrand= product.ProductBrand;
            _context.SaveChanges();
            return products;
        } 
        public async Task<Product> PostProducts(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
       public async Task<string> DeleteProducts(int id)
        {
            var products= await _context.Products.FirstOrDefaultAsync(x=>x.ProductId == id);
            _context.Remove(products);
            _context.SaveChanges();
            return "Deleted Successfully";
        }
    }
}
