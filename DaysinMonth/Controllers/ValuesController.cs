using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DaysinMonth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaysinamonthController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        [HttpGet("{inputdate}")]
        public ActionResult<string> Get(DateTime inputdate)
        {
            int days = DateTime.DaysInMonth(int.Parse(inputdate.Year.ToString()), int.Parse(inputdate.Month.ToString()));
            return "Given date is " + inputdate.ToShortDateString() + "\r\nNumber of days is " + days.ToString();
        }

        // POST api/values
        [HttpPost]
        //public void Post([FromBody] string value)
        public string Post([FromBody] DateTime value)
        {
            //string month = value.Month.ToString();
            //string year = value.Year.ToString();
            int days = DateTime.DaysInMonth(int.Parse(value.Year.ToString()), int.Parse(value.Month.ToString()));
            return "Given date is " + value.ToShortDateString() + "\r\nNumber of days is " + days.ToString();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
