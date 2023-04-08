using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace sistema_de_productos.Modelo
{
    internal class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "farmaprog";
        static string usuario = "root";
        static string contrasena = "";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + contrasena + ";" + "database=" + bd + ";";
        public MySqlConnection establecerConexion()
        {
            try
            {

                conexion.ConnectionString = cadenaConexion;

                conexion.Open();
               
               
                MessageBox.Show("Se logro conectarse a la base de datos");

               
            }
            

            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos,Error" + e.ToString());

            }

            return conexion;
        }


    }
}
