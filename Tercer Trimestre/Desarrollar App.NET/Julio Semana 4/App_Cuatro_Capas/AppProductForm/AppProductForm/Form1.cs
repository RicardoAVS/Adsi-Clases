using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_LN_Producto;

namespace AppProductForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textIdProducto.Text;
                var nombre = textNombreProducto.Text;
                var marca = textMarcaProducto.Text;
                var categoria = textCategoriaProducto.Text;
                var descripcion = textDescripcionProducto.Text;
                var precio = Convert.ToDouble(textPrecioProducto.Text);

                Producto producto = new Producto(id, nombre, marca, categoria, descripcion, precio);

                if (producto.guardarProducto())
                {
                    MessageBox.Show(producto.Error);
                    producto = null;
                    return;
                }

                MessageBox.Show(producto.Error);
                producto = null;
                return;
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
               
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textIdProducto.Text;
                var nombre = textNombreProducto.Text;
                var marca = textMarcaProducto.Text;
                var categoria = textCategoriaProducto.Text;
                var descripcion = textDescripcionProducto.Text;
                var precio = Convert.ToDouble(textPrecioProducto.Text);

                Producto producto = new Producto(id, nombre, marca, categoria, descripcion, precio);

                if (producto.actualizarProducto())
                {
                    MessageBox.Show(producto.Error);
                    producto = null;
                    return;
                }

                MessageBox.Show(producto.Error);
                producto = null;
                return;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textIdProducto.Text;
                Producto producto = new Producto();
                producto.IdProducto = id;

                if (producto.eliminarProducto())
                {
                    MessageBox.Show(producto.Error);
                    producto = null;
                    return;
                }

                MessageBox.Show(producto.Error);
                producto = null;
                return;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarProducto();
        }

        private void consultarProducto()
        {
            try
            {
                var id = textIdProducto.Text;
                Producto producto = new Producto();

                producto.IdProducto = id;

                if(producto.consultarProducto())
                {
                    SqlDataReader dataReader;
                    dataReader = producto.ObjReader;

                    if(dataReader.HasRows)
                    {
                        dataReader.Read();
                        textNombreProducto.Text = dataReader.GetString(1);
                        textMarcaProducto.Text = dataReader.GetString(2);
                        textCategoriaProducto.Text = dataReader.GetString(3);
                        textDescripcionProducto.Text = dataReader.GetString(4);
                        textPrecioProducto.Text = dataReader.GetDouble(5).ToString();
                        dataReader.Close();
                    }

                    
                }
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            

        }

        private void bnListar_Click(object sender, EventArgs e)
        {
            listProductos();
        }

        private void listProductos()
        {
            try
            {
                Producto producto = new Producto();

                if (producto.listarProducto(dataGridProductList))
                {
                    producto = null;
                    return;
                }

                MessageBox.Show(producto.Error);
                producto = null;
                return;

            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listProductos();
        }
    }
}
