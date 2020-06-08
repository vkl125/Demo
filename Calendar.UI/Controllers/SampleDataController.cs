using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calendar.Entities.ViewModel;

namespace ReactCrudDemo.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<EventViewModel> GetEvents()
        {
            return null;
        }
        [HttpPost]
        [Route("[action]")]
        public int CreateEvent([FromBody] EventViewModel eventVM)
        {
            return 1;
        }

        [HttpPost]
        [Route("[action]")]
        public int CreateEventAvail([FromBody] EventAvailabilityViewModel eventAvailVM)
        {
            return 1;
        }

        [HttpGet]
        [Route("[action]")]
        public EventViewModel EventDetails(int id)
        {
            //return events details
            return new EventViewModel();
        }

        [HttpPut]
        [Route("[action]")]
        public int EditEvent(EventViewModel employee)
        {
            //update event
            return 1;
        }

        [HttpDelete]
        [Route("[action]")]
        public int DeleteEvent(int id)
        {
            //return delete evenyt
            return 1;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
        
    }
}
