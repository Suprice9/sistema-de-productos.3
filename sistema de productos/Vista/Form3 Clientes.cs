using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sistema_de_productos.Modelo;

namespace sistema_de_productos
{
    public partial class Form3_clientes : Form
    {
        Conexion con = new Conexion();
        public Form3_clientes()
        {
            InitializeComponent();
        }

        private void validar(int numero)
        {

        }

        private void Form3_clientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Establecer la cadena de conexión a la base de datos
            string connectionString = "SERVER=localhost;DATABASE=farmaprog;UID=root;PASSWORD=;";

            // Crear una nueva conexión a la base de datos MySQL
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();

            string laboratorio = txtLaboratorio.Text;
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;

            //Validar que  no este vacio
            String mensajeError = "";

            if (correo == "")
            {
                mensajeError = mensajeError + "El Correo no puede estar vacio";
            }
            if (direccion == "")
            {
                mensajeError = mensajeError + "La direccion no puede estar vacio";
            }


            //Inserta los datos del suplidor

            try
            {                                                                                                                                                                                                                                                           
                string consulta = "Insert Into proveedores (laboratorio,codigo,direccion,correo_electronico,telefono) values ('" + laboratorio + "','" + codigo + "','" + direccion + "','" + correo + "','" + telefono + "')";

                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                var resultado = cmd.ExecuteNonQuery();
                Console.WriteLine("Ingresado correctamente");

            }
            catch (Exception s)
            {

                MessageBox.Show(s.Message);
            }
            conexion.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtLaboratorio_KeyPress(object sender, KeyPressEventArgs e)
        {
           //Valida los valores ingresados en letras
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 225))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar Numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar Numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
            this.Close();
        }
    }
}
