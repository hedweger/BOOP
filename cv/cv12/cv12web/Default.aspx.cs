using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv12web.Model
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string Calculate(string a, string b, string op)
        {
            CalcData calcData = new CalcData
            {
                Operace = op,
                Operand1 = Convert.ToDecimal(a),
                Operand2 = Convert.ToDecimal(b)
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44391/");
            HttpResponseMessage response =
            client.PostAsJsonAsync("api/values", calcData).Result;
            if (response.IsSuccessStatusCode)
            {
                decimal reply = response.Content.ReadAsAsync<decimal>().Result;
                return reply.ToString();
            }
            return "Error";
        }

    }
}