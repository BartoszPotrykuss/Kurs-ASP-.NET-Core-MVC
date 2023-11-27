using Test_web_app.Models;
using Test_web_app.Services.Interfaces;

namespace Test_web_app.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly DbTestContext _context;

        public WarehouseService(DbTestContext context)
        {
            _context = context;
        }

        public int Delete(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return id;
        }

        public Product Get(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public List<Product> GetAll()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public int Save(Product product)
        {
            // logika zapisująca do bazy
            _context.Add(product);
            if(_context.SaveChanges() > 0)
            {
                System.Console.WriteLine("SUKCES");
            };
            return product.Id;
        }
    }
}
