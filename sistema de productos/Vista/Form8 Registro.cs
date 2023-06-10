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
    public partial class Form8_Registro : Form
    {
       
        public Form8_Registro()
        {
            InitializeComponent();
        }


        private void limpiar()
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtApellido.Text = "";
            cmboxGenero.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            // Establecer la cadena de conexión a la base de datos
            string connectionString = "SERVER=localhost;DATABASE=farmaprog;UID=root;PASSWORD=;";

            // Crear una nueva conexión a la base de datos MySQL
            MySqlConnection conexion = new MySqlConnection(connectionString);

            conexion.Open();

            string nombre = txtNombre.Text;
            string contrasena = txtContraseña.Text;
            string apellido = txtApellido.Text;
            string genero = cmboxGenero.Text;


            string query = "Insert into usuario (nombre,apellido,contrasena,sexo) values ('" + nombre + "','" + apellido + "','" + contrasena + "','" + genero + "');";

            MySqlCommand cmd = new MySqlCommand(query,conexion);
            int n =cmd.ExecuteNonQuery();



            

            if (n>-1)
            {
                MessageBox.Show("Datos exitosamente ingresados");
                conexion.Close();

                limpiar();

                this.Close();

            }
            else
            {
                MessageBox.Show("Datos no ingresados");
            }

            
        }

        private void Form8_Registro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form7_login();// vuelve al formulario anterior
            formulario.Show();
            this.Close();
        }
    }
}