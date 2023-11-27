using Test_web_app.Models;

namespace Test_web_app.Services.Interfaces
{
    public interface IApiService
    {
        WeatherResponse Get(string city);
    }
}
