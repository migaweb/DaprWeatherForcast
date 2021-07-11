using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeatherMvcFront.Services
{
  public interface IWeatherClient
  {
    Task<IEnumerable<WeatherForecast>> GetWeather();
  }
}
