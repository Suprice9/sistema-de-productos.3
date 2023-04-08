using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_de_productos.Modelo;
using MySql.Data.MySqlClient;

namespace sistema_de_productos.Vista
{
    public partial class Form7_login : Form
    {
        Conexion con = new Conexion();
        public Form7_login()
        {
            InitializeComponent();
        }

        private void Form7_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Seccion_Click(object sender, EventArgs e)
        {

            // Establecer la cadena de conexión a la base de datos
            string connectionString = "SERVER=localhost;DATABASE=farmaprog;UID=root;PASSWORD=;";

            // Crear una nueva conexión a la base de datos MySQL
            MySqlConnection conexion = new MySqlConnection(connectionString);




            string usuario = txtUsuario.Text;
            string contrasena = TxtContraseña.Text;

            //Verifica si no tiene datos
            String mensajeError = "";

            if (usuario == "")
            {
                mensajeError = mensajeError + "El Usuario no puede estar vacio";
            }
            if (contrasena == "")
            {
                mensajeError = mensajeError + "La contraseña no puede estar vacio";
            }


            conexion.Open();

            string consulta = ("select * from usuario  where nombre = '" + usuario + "'and contrasena = '" + contrasena + "'");

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);


           
            MySqlDataReader leer = cmd.ExecuteReader();


            if (leer.Read())
            {
               
                    MessageBox.Show("Bienvenido");

                    /* agrege esta parte para cuando se cumpliera la funcion pase al inicio*/

                    Form1 formPrincipal = new Form1();
                    formPrincipal.Show();
                    this.Hide(); 
                

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");

            }
           conexion.Close();

        }

        private void btnRegistro_Click(object sender, EventArgs e) //este boton conecta al formulario de registro
        {
            Form formulario = new Form8_Registro();
            formulario.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
