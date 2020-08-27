using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppConsumir.operaciones;

namespace AppConsumir
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtCircunferencia_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double radio = Convert.ToDouble(txtRadio.Text);
                WebService1 webService = new WebService1();

                txtCircunferencia.Text = webService.Circunferencia(radio).ToString();
                webService = null;
                return;

            }
            catch (Exception error)
            {
                labelMsg.Text = error.Message;
                return;
            }
        }
    }
}