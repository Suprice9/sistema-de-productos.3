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
using sistema_de_productos.Vista;
using sistema_de_productos.Controlador;

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

            MySqlCommand cm = new MySqlCommand("Select laboratorio,codprov from proveedores", conexion);

            //Mientras el registro lea buscara los suplidores existente en la base de datos
            MySqlDataReader registro = cm.ExecuteReader();

            
            while (registro.Read())
            {
                cmbSuplidor.Items.Add(registro["codprov"].ToString());
               
            }
           
               conexion.Close();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void InsetarFactura(List<Datos> f)
        {
            string connectionString = "server=localhost;user id=root;password=;database=farmaprog";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();

            foreach(Datos fact in f)
            {
                string query = "Insert into producto(idproveedor,nombreproduc,preciovent,preciocomp,fechavencimiento,stock,descripcion) VALUES(@id_suplidor, @producto,@precioventa,@preciocompra, @fechavencimiento, @cantidad,@descripcion)";

                MySqlCommand cmd = new MySqlCommand(query,conexion);

                // Asignar los valores a los parámetros de consulta
                cmd.Parameters.AddWithValue("@id_suplidor", fact.Idsuplidor);
                cmd.Parameters.AddWithValue("@producto", fact.Producto);
                cmd.Parameters.AddWithValue("@descripcion", fact.Descripcion);
                cmd.Parameters.AddWithValue("@preciocompra", fact.Preciocompra);
                cmd.Parameters.AddWithValue("@precioventa", fact.Precioventa);
                cmd.Parameters.AddWithValue("@fechavencimiento", fact.Fechavenci);
                cmd.Parameters.AddWithValue("@cantidad", fact.Cantidad);

                cmd.ExecuteNonQuery();
            }
            

            conexion.Close();
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            // Conectar a la base de datos
            string connectionString = "server=localhost;user id=root;password=;database=farmaprog";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            

            //Toma los valores del datagridview
           
            
            List<Datos> listfact = new List<Datos>();

            foreach (DataGridViewRow filas in dataGridView1.Rows) {
                Datos fact = new Datos();

                if (filas.Cells[0].Value != null)
                {


                    fact.Codigo = (string)filas.Cells[0].Value;
                    fact.Idsuplidor = (string)filas.Cells[1].Value;
                    fact.Producto = (string)filas.Cells[2].Value;
                    fact.Descripcion = (string)filas.Cells[3].Value;
                    fact.Preciocompra = (string)filas.Cells[4].Value;
                    fact.Precioventa = (string)filas.Cells[5].Value;
                    fact.Fechavenci = (DateTime)filas.Cells[6].Value;
                    fact.Cantidad = (string)filas.Cells[7].Value;

                    listfact.Add(fact);
                   
                }
          
            }
            InsetarFactura(listfact);

            if (listfact != null)
            {
                MessageBox.Show("No hay datos que ingresar ");
            }
            else
            {
                MessageBox.Show("se ha Realizado la compra correctamente.");


                //esta parte de aqui guarda los daton introducidos en un documento de texto
                //inidcicamos donde querenos guardar el archivo que sera nuestro reporte
                StreamWriter escribir = new StreamWriter(@"E:\Programas\sistema-de-productos.2-Pruebas2\sistema de productos\reportes\Factura de compra\reporte de compra.", true);
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
                    escribir.WriteLine("Producto: " + txtCodigo.Text);
                    escribir.WriteLine("Producto: " + txt_producto_compra.Text);
                    escribir.WriteLine("Descripcion: " + txt_descripcion.Text);
                    escribir.WriteLine("cantidad: " + numericUpDownCompra.Text);
                    escribir.WriteLine("Precio de compra: " + txt_precio_compra.Text);
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
                dataGridView1.Rows.Clear();
            }
        }

        public void limpiar()
        {
            cmbSuplidor.Text ="";
            txt_descripcion.Clear();
            txt_precio_compra.Clear();
            txt_venta_compra.Clear();
            txt_producto_compra.Clear();
            datatimeVencimiento.ResetText();
            numericUpDownCompra.Value = 1;
        }

        private void bnt_agregarlista_Click(object sender, EventArgs e) //este boton agrega los datos introducidos y los refleja en el datagridview que esta al lado
        {
            string valor1 = cmbSuplidor.Text; // Recupera el valor del primer TextBox
            string valor2 = txt_producto_compra.Text; // Recupera el valor del segundo TextBox
            string valor3 = txt_descripcion.Text;     // Recupera el valor del tercero TextBox
            string valor4 = txt_precio_compra.Text;   // Recupera el valor del cuarto TextBox
            string valor5 = txt_venta_compra.Text;    // Recupera el valor del quinto TextBox
            DateTime valor6 =Convert.ToDateTime(datatimeVencimiento.Value);    // Recupera el valor del sexto TextBox
            string valor7 = numericUpDownCompra.Text; // Recupera el valor del septimo TextBox
            string valor8 = txtCodigo.Text;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = valor8;
            fila.Cells[1].Value = valor1; // Establece el valor de la primera celda
            fila.Cells[2].Value = valor2; // Establece el valor de la segunda celda
            fila.Cells[3].Value = valor3; // Establece el valor de la tercera celda
            fila.Cells[4].Value = valor4; // Establece el valor de la cuarta celda
            fila.Cells[5].Value = valor5; // Establece el valor de la quinta celda
            fila.Cells[6].Value = valor6; // Establece el valor de la sexta celda
            fila.Cells[7].Value = valor7; // Establece el valor de la septima celda

            dataGridView1.Rows.Add(fila); // Agrega la fila al DataGridView

            limpiar();
            
            

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2_productos(this); //cuando precione del boton de productos se abre el segundo form
            formulario.Show();
        }

        private void btnMostrarCompra_Click(object sender, EventArgs e)
        {

            TextReader leer = new StreamReader(@"E:\Programas\sistema-de-productos.2-Pruebas2\sistema de productos\reportes\Factura de compra\reporte de compra.txt", true);
            MessageBox.Show(leer.ReadToEnd());
        }
    }
    }

