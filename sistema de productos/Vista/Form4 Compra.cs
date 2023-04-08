using MySql.Data.MySqlClient;
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

namespace sistema_de_productos
{
    public partial class Form4_ventas : Form
    {
        public Form4_ventas()
        {
            InitializeComponent();
        }

        private void Form4_ventas_Load(object sender, EventArgs e)
        {
            //esto es para que aparezca la fecha en la pantalla
                lblFecha.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

            // Conectar a la base de datos
            string connectionString = "server=localhost;user id=root;password=;database=farmaprog";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();

            MySqlCommand cm = new MySqlCommand("Select laboratorio from proveedores", conexion);


            MySqlDataReader registro = cm.ExecuteReader();
            while (registro.Read())
            {
                cmbSuplidor.Items.Add(registro["laboratorio"].ToString());
            }
            conexion.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            // Conectar a la base de datos
            string connectionString = "server=localhost;user id=root;password=;database=farmaprog";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Escribir la consulta SQL
            string query = "INSERT INTO compra (id_suplidor, producto, descripcion, preciocompra, precioventa, fechavencimiento, cantidad) VALUES (@id_suplidor, @producto, @descripcion, @preciocompra, @precioventa, @fechavencimiento, @cantidad)";

            // Crear un objeto MySqlCommand
            MySqlCommand command = new MySqlCommand(query, connection);

            // Asignar los valores a los parámetros de consulta
            command.Parameters.AddWithValue("@id_suplidor", cmbSuplidor.Text);
            command.Parameters.AddWithValue("@producto", txt_producto_compra.Text);
            command.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
            command.Parameters.AddWithValue("@preciocompra", txt_precio_compra.Text);
            command.Parameters.AddWithValue("@precioventa", txt_venta_compra.Text);
            command.Parameters.AddWithValue("@fechavencimiento", datatimeVencimiento.Value);
            command.Parameters.AddWithValue("@cantidad", txt_cantidad_compra.Text);

            // Ejecutar la consulta
            command.ExecuteNonQuery();

            // Cerrar la conexión a la base de datos
            connection.Close();

            // Mostrar un mensaje de éxito
            MessageBox.Show("se ha Realizado la compra correctamente.");

            //esta parte de aqui guarda los daton introducidos en un documento de texto

            
            //inidcicamos donde querenos guardar el archivo que sera nuestro reporte
            StreamWriter escribir = new StreamWriter(@"E:\Programas\sistema-de-productos.2-Pruebas2\sistema de productos\reportes\Factura de compra\reporte de compra.txt", true);
            try
            {
                escribir.WriteLine("   FarmaProg ");
                escribir.WriteLine("---------------------");
                escribir.WriteLine("Compra de medicamentos para abastecer la farmacia");
                escribir.WriteLine("---------------------");
                escribir.WriteLine("Medicamentos");
                escribir.WriteLine("---------------------");
                escribir.WriteLine("Fecha: " + lblFecha.Text);
                escribir.WriteLine("---------------------"); //de aqui para abajo van los datos de suplidor etc
            escribir.WriteLine("Suplidor: " + cmbSuplidor.Text);
            escribir.WriteLine("Producto: " + txt_producto_compra.Text);
            escribir.WriteLine("Descripcion: " + txt_descripcion.Text);
            escribir.WriteLine("cantidad: " + txt_cantidad_compra.Text);
            escribir.WriteLine("Precio de compra: " +  txt_precio_compra.Text);
            escribir.WriteLine("Precio de venta: " + txt_venta_compra.Text);
            escribir.WriteLine("Fecha de vencimiento: " + datatimeVencimiento.Value);
                


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

            MessageBox.Show("Se ha guardado el reporte de esta compra ");
            //---------------------------------------------------------------------------------------

        }

        private void bnt_agregarlista_Click(object sender, EventArgs e) //este boton agrega los datos introducidos y los refleja en el datagridview que esta al lado
        {
            string valor1 = cmbSuplidor.Text; // Recupera el valor del primer TextBox
            string valor2 = txt_producto_compra.Text; // Recupera el valor del segundo TextBox
            string valor3 = txt_descripcion.Text;     // Recupera el valor del tercero TextBox
            string valor4 = txt_precio_compra.Text;   // Recupera el valor del cuarto TextBox
            string valor5 = txt_venta_compra.Text;    // Recupera el valor del quinto TextBox
            DateTime valor6 =Convert.ToDateTime(datatimeVencimiento.Value);    // Recupera el valor del sexto TextBox
            string valor7 = txt_cantidad_compra.Text; // Recupera el valor del septimo TextBox

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = valor1; // Establece el valor de la primera celda
            fila.Cells[1].Value = valor2; // Establece el valor de la segunda celda
            fila.Cells[2].Value = valor3; // Establece el valor de la tercera celda
            fila.Cells[3].Value = valor4; // Establece el valor de la cuarta celda
            fila.Cells[4].Value = valor5; // Establece el valor de la quinta celda
            fila.Cells[5].Value = valor6; // Establece el valor de la sexta celda
            fila.Cells[6].Value = valor7; // Establece el valor de la septima celda

            dataGridView1.Rows.Add(fila); // Agrega la fila al DataGridView

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSuplidor_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnAgregarSuplidor_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3_clientes();
            formulario.Show();
        }
    }
    }

