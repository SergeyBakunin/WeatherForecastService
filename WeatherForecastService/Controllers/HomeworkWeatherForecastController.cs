using Microsoft.AspNetCore.Mvc;
using WeatherForecastService.Models;

namespace WeatherForecastService.Controllers
{

    [Route("api/weather")]
    [ApiController]
    public class HomeworkWeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastHolder _holder;

        public HomeworkWeatherForecastController(WeatherForecastHolder holder)
        {
            _holder = holder;
        }

        [HttpPost("add")]
        public IActionResult Add([FromQuery] DateTime date, [FromQuery] int temperetureC)
        {
            _holder.Add(date, temperetureC);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime date, [FromQuery] int temperetureC)
        {
            _holder.Update(date, temperetureC);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime date)
        {
            _holder.Delete(date);
            return Ok();
        }
        
        [HttpGet("get")]
        public IActionResult Get([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return Ok(_holder.Get(dateFrom, dateTo));
        }
    }
}
