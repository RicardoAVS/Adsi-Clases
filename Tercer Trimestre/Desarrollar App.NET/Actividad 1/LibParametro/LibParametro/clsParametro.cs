using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LibParametro
{
    public class ClsParametro
    {
        #region "Atributos"
        private String strID;
        private String strName;
        private String strLastName;
        private String strAge;
        private String strError;
        private String strConexion;
        private String strFile;

        private XmlDataDocument strDataDocument;
        private XmlNode strNode;
        #endregion

        #region "Constructor"
        public ClsParametro()
        {
            strDataDocument = new XmlDataDocument();
            strFile = "";
        }
        #endregion

        #region "Propiedades"
        public String Error
        {
            get { return strError; }
            set { strError = value; }
        }
        public String CadenaConexion
        {
            get { return strConexion; }
            set { strConexion = value; }
        }

        public string StrID {
            get => strID; 
            set => strID = value; 
        }
        public string StrName { 
            get => strName; 
            set => strName = value;
        }
        public string StrLastName {
            get => strLastName;
            set => strLastName = value; 
        }
        public string StrAge { 
            get => strAge; 
            set => strAge = value; 
        }

        #endregion

        #region "Metodos Publicos"
        ///<summary>
        ///Construye la Cadena de Conexion a la BD
        ///</summary>
        ///<returns>Retorna un Booleano acorde a su Ejecucion</returns>
        public bool CrearConexion()
        {
            if (strFile == "")
            {
                try
                {
                    string strFileName = AppDomain.CurrentDomain.BaseDirectory;
                    strFileName = strFileName.Substring(0, strFileName.Length - 1);
                    if (strFileName.LastIndexOf("/") > 0)
                    {
                        //Es una aplicacion windows
                        strFile = strFileName.Replace("/", "\\");
                        strFile = strFile + "\\Cliente.xml";
                    }
                    else
                    {
                        //Es una aplicacion web
                        strFile = Application.StartupPath + "\\Cliente.xml";
                    }
                    strDataDocument.Load(strFile);
                    strNode = strDataDocument.SelectSingleNode("//ID");
                    StrID = strNode.InnerText;

                    strNode = strDataDocument.SelectSingleNode("//Name");
                    StrName = strNode.InnerText;

                    strNode = strDataDocument.SelectSingleNode("//LastName");
                    StrLastName = strNode.InnerText;

                    strNode = strDataDocument.SelectSingleNode("//Age");
                    StrAge = strNode.InnerText;

                    return true;
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                    return false;
                }
            }
            else
            {
                strError = "Archivo No Valido";
                return false;
            }
        }
        #endregion
    }
}
