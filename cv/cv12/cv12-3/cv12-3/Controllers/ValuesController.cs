using cv12_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace cv12_3.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public decimal Post([FromBody] CalcData calcData)
        {
            decimal result = 0;
            switch (calcData.Operace)
            {
                case "+":
                    result = calcData.Operand1 + calcData.Operand2;
                    break;
                case "-":
                    result = calcData.Operand1 - calcData.Operand2;
                    break;
                case "*":
                    result = calcData.Operand1 * calcData.Operand2;
                    break;
                case "/":
                    result = calcData.Operand1 / calcData.Operand2;
                    break;
            }
            return result;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
