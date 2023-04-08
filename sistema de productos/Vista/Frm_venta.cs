using MySql.Data.MySqlClient;
using sistema_de_productos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_de_productos.Vista;

namespace sistema_de_productos.Vista
{
    public partial class Frm_venta : Form
    {
        public Frm_venta()
        {
            

            InitializeComponent();
        }

        private void Frm_venta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        //s
        int Fila = 0;

        private void button2_Click(object sender, EventArgs e) // este boton es de realizar  la venta
                                                               //mostrara un mensaje en pantalla diciendo 
        {
            MessageBox.Show("Se ha Realizado Exitosamente");

            //inidcicamos donde querenos guardar el archivo que sera nuestro reporte
            StreamWriter escribir = new StreamWriter(@"C:\Users\enman\Desktop\Hoy\FarmaProg-master3\FarmaProg-master2\sistema de productos\reportes\Factura de venta\reporte de venta.txt", true);
            try
            {
                escribir.WriteLine("   FarmaProg");
                escribir.WriteLine("---------------------");
                escribir.WriteLine("   Venta");
                escribir.WriteLine("---------------------");
                escribir.WriteLine("Medicamento");
                escribir.WriteLine("---------------------");
                escribir.WriteLine("Fecha: " + lblFecha.Text);
                escribir.WriteLine("---------------------");
                escribir.WriteLine("cliente: " + TxtNombreCliente.Text);
                escribir.WriteLine("producto: " + txtNombreProducto.Text);
                escribir.WriteLine("cantidad: " + numerictext.Text);
                escribir.WriteLine("Total a pagar: " + lblCostoApagar.Text);


                escribir.WriteLine("--------------------------");
                escribir.WriteLine("\n");
            }
            catch
            {
                //mensaje error
                MessageBox.Show("error");
            }
            //cerramos proceso
            escribir.Close();

            MessageBox.Show("Se ha guardado el reporte de esta venta ");

        }

        private void textBox3_TextChanged(object sender, EventArgs e) //parte donde se introduce el efectivo para que haga el descuento
        {
            //int total = 6600;
           double total = Convert.ToDouble(txt_totalpagar.Text); // Total a pagar
            double efectivo = Convert.ToDouble(textBox3.Text); // Dinero entregado por el usuario
            double devolucion = - total + efectivo ; // Calcula la cantidad a devolver

            // Muestra la cantidad a devolver en el Label "devolucion"
            lbldevolucion.Text = devolucion.ToString();

            /* double total2 = Convert.ToDouble(lblCostoApagar.Text); // Total a pagar
                                                       // double efectivo = Convert.ToInt32(textBox3.Text);
        double efectivo = Convert.ToDouble(textBox3.Text); // Dinero entregado por el usuario
        double cambio = efectivo - total2; // Calcular el cambio a devolver

        // Mostrar el cambio en un cuadro de texto llamado "panel1"
        lblCostoApagar.Text = cambio.ToString("lblCostoApagar");

         try
        {
            lbldevolucion.Text = (float.Parse(textBox3.Text) - float.Parse(lblCostoApagar.Text)).ToString();
        }
        catch
        {
            //lbldevolucion.Text = 0.ToString();

        }*/
        }

        int Conteo;
        private int precio;

        public int Cantidad { get; private set; }
        public static object SelectedValue { get; private set; }

        private void button3_Click(object sender, EventArgs e) // boton vender
        {
            // Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            //if (Conteo != 0)



            //double total;

            //double cantidad = Convert.ToDouble(txtCantidad.Text);


            // Recorrer el DataGridView y sumar el total de la venta
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double total;
                double Cantidad;
                double precio;

                //precio = Convert.ToDouble(row.Cells["preciovent"].Value);

                //Cantidad = Convert.ToDouble(row.Cells["Cantidad"].Value);
                // total = precio * Cantidad;
                precio = 150;
                Cantidad = 10;
                


                total = precio * Cantidad;
                // Mostrar el total en el TextBox
                lblCostoApagar.Text = total.ToString(
                lblCostoApagar.Text = "C");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2_productos(); //cuando precione del boton de productos se abre el segundo form
          
            formulario.Show();

            /*  // Establecer la cadena de conexión a la base de datos
              string connectionString = "SERVER=localhost;DATABASE=farmaprog;UID=root;PASSWORD=;";

              // Crear una nueva conexión a la base de datos MySQL
              MySqlConnection conexion = new MySqlConnection(connectionString);

              try
              {

                  // Abrir la conexión a la base de datos
                  conexion.Open();

                  // Crear una consulta que busque un valor específico en un campo de la tabla
                  string consulta = "SELECT * FROM venta WHERE nombreproduct LIKE '%" + txtIdProducto.Text + "%'";

                  // Crear un nuevo comando MySQL utilizando la consulta y la conexión
                  MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                  // Crear un adaptador de MySQL para llenar un DataTable con los resultados de la consulta
                  MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                  // Crear un nuevo DataTable para almacenar los resultados de la consulta
                  DataTable tabla = new DataTable();

                  // Llenar el DataTable con los resultados de la consulta utilizando el adaptador
                  adaptador.Fill(tabla);

                  // Asignar el DataTable como origen de datos del control DataGridView
                  dataGridView1.DataSource = tabla;


              }
              catch (MySqlException ex)   //revisar aqui
              {
                  // Mostrar un mensaje de error si se produce una excepción al buscar en la base de datos
                  MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
              }
              finally
              {
                  // Cerrar la conexión a la base de datos
                  conexion.Close();

              }*/
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCostoApagar_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lbldevolucion_Click(object sender, EventArgs e)
        {

        }
    }
}
  
    
    

