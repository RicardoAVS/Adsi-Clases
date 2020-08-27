using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppConsumir.operaciones;

namespace AppConsumir
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double numUno = Convert.ToDouble(txtNum1.Text);
                double numDos = Convert.ToDouble(txtNum2.Text);
                WebService1 webService = new WebService1();

                txtPerimetro.Text = webService.suma(numUno, numDos).ToString();
                webService = null;
                return;

            }
            catch (Exception error)
            {
                labelMsg.Text = error.Message;
            }
        }
    }
}