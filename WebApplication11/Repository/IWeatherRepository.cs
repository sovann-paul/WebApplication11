using System.Collections.Generic;

namespace WebApplication11.Repository
{
    public interface IWeatherRepository
    {
        IEnumerable<WeatherForecast> GetData(); 
    }
}
