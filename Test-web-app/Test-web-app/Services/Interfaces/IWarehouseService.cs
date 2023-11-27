using Test_web_app.Models;

namespace Test_web_app.Services.Interfaces
{
    public interface IWarehouseService
    {
        int Save(Product product);
        List<Product> GetAll();
        Product Get(int id);
        int Delete(int id);
    }
}
