using LibParametro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteInfoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClsParametro cliente = new ClsParametro();

        
            if (cliente.CrearConexion())
            {

                String id = cliente.StrID;
                String name = cliente.StrName;
                String lastName = cliente.StrLastName;
                String age = cliente.StrAge;

                txtClienteId.Text = id;
                txtClienteNombre.Text = name;
                txtClienteApellido.Text = lastName;
                txtClienteEdad.Text = age;

                return;
            } 
        }
    }
}
