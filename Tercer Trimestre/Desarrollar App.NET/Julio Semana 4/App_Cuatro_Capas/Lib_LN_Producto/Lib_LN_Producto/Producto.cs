using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LibConexionBD;
using System.Data;
using System.Data.SqlClient;
using LibLlenarGrid;
using System.Windows.Forms;
using LibConexionBD;

namespace Lib_LN_Producto
{
    public class Producto
    {
        #region Atributos
        private string idProducto;
        private string nombre;
        private string marca;
        private string categoria;
        private string descripcion;
        private double precio;
        private string error;
        private SqlDataReader objReader;

        #endregion
        #region Metodos Publicos

        public Producto()
        {
            this.idProducto = "";
            this.Nombre = "";
            this.Marca = "";
            this.Categoria = "";
            this.Descripcion = "";
            this.Precio = 0.0;
            this.Error = "";
        }

        public Producto(string id, string nombre, string marca, string categoria, string descripcion, double precio)
        {
            this.idProducto = id;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Categoria = categoria;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        public bool guardarProducto()
        {
            ClsConexion conexion = new ClsConexion();
            string query = $"EXECUTE USP_CREATE_PRODUCTO '{idProducto}',  '{ Nombre }', '{ Marca }', '{Categoria}', '{Descripcion}', { Precio }";

            if (!conexion.EjecutarSentencia(query, false))
            {
                Error = conexion.Error;
                conexion = null;
                return false;
            }

            Error = "Se ha guardado el producto con exito!.";
            conexion = null;
            return true;
        }

        public bool actualizarProducto()
        {
            ClsConexion conexion = new ClsConexion();
            string query = $"EXECUTE USP_PRODUCTO_UPDATE '{idProducto}',  '{ Nombre }', '{ Marca }', '{Categoria}', '{Descripcion}', { Precio }";

            if (!conexion.EjecutarSentencia(query, false))
            {
                Error = conexion.Error;
                conexion = null;
                return false;
            }

            Error = $"Se ha actualizado el empleado con id {idProducto} exitosamente.";
            conexion = null;
            return true;
        }

        public bool eliminarProducto()
        {
            ClsConexion conexion = new ClsConexion();
            string query = $"EXECUTE USP_DELETE_PRODUCTO '{idProducto}'";

            if (!conexion.EjecutarSentencia(query, false))
            {
                Error = conexion.Error;
                conexion = null;
                return false;
            }

            Error = $"Se ha eliminado el empleado con id {idProducto} exitosamente.";
            conexion = null;
            return true;
        }

        public bool consultarProducto()
        {
            ClsConexion conexion = new ClsConexion();
            string query = $"EXECUTE USP_READ_PRODUCTO '{idProducto}'";

            if (!conexion.Consultar(query, false))
            {
                error = conexion.Error;
                conexion = null;
                return false;
            }

            objReader = conexion.Reader;
            conexion = null;
            return true;

        }

        public bool listarProducto(DataGridView obj)
        {
            ClsLlenarGrid gridObject = new ClsLlenarGrid();
            gridObject.NombreTabla = "datos";
            gridObject.SQL = "USP_LIST_ALL_PRODUCTOS";

            if (gridObject.LlenarGrid(obj))
            {
                gridObject = null;
                return true;
            }
            error = gridObject.Error;
            error = null;
            return false;
        }


        #endregion
        #region Propiedades

        public string IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader ObjReader { get => objReader; set => objReader = value; }
        
        #endregion
    }
}
