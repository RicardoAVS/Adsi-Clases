using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppConsumir.operaciones;

namespace AppConsumir
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double num2 = Convert.ToDouble(txtNum2.Text);
                double num1 = Convert.ToDouble(txtNum1.Text);
                WebService1 webService = new WebService1();

                txtResta.Text = webService.Resta(num1, num2).ToString();
                webService = null;
                return;

            } catch (Exception error)
            {
                labelMsg.Text = error.Message;
                return;
            }
        }
    }
}