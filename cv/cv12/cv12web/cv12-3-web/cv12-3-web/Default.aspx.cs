using cv12_3_web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv12_3_web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("Result.aspx?A={0}&B={1}&op={2}",
            OperandA.Text, OperandB.Text, Operace.SelectedValue));
        }
    }
}