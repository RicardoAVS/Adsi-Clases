using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppConsumir.operaciones;

namespace AppConsumir
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double numUno = Convert.ToDouble(txtBase.Text);
                WebService1 webService = new WebService1();

                txtArea.Text = webService.TrianguloEq(numUno).ToString();
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