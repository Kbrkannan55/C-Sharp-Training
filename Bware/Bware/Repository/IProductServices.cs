using Bware.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bware.Repository
{
    public interface IProductServices
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetAllProductsForMale();
        Task<List<Product>> GetAllProductsForFemale();

        Task<List<Product>> GetAllProductsForAll();
        Task<Product> UpdateProducts(int id, Product product);
        Task<string> DeleteProducts(int id);
        Task<Product> PostProducts(Product product);
    }
}
