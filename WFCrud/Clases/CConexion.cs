using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCrud.Clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "Inventario";
        static string usuario = "root";
        static string password = "root";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("Conexión Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró conectar a la base de datos, error:" + ex.ToString());
            }
            return conex;
        }

        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
