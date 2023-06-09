﻿using MySql.Data.MySqlClient;
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
using sistema_de_productos.Controlador;

namespace sistema_de_productos.Vista
{
    public partial class Frm_venta : Form
    {
        Form2_productos productos = new Form2_productos();
        public Frm_venta()
        {
            

            InitializeComponent();
        }

        public void limpiar()
        {
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            txtPrecioVenta.Clear();
            TxtStock.Clear();
            txtFechaVencimiento.Clear();
            numerictext.Value = 1; 
        }

        private void Frm_venta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        //s
        int Fila = 0;



        public void InsertarVenta(List<Venta> v)
        {
            string connectionString = "server=localhost;user id=root;password=;database=farmaprog";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();

            foreach (Venta fact in v)
            {
                string query = "Insert into venta(nombrecliente,nombreproduct,preciovent,Cantidad,Total) VALUES(@nombrecliente, @nombreproduct,@preciovent,@Cantidad, @Total)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                // Asignar los valores a los parámetros de consulta
                cmd.Parameters.AddWithValue("@nombrecliente",TxtNombreCliente.Text );
                cmd.Parameters.AddWithValue("@nombreproduct", fact.Nombreproducto);
                cmd.Parameters.AddWithValue("@preciovent", fact.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", fact.Cantidad);
                cmd.Parameters.AddWithValue("@Total",suma);


                //inidcicamos donde querenos guardar el archivo que sera nuestro reporte
                StreamWriter escribir = new StreamWriter(@"E:\Programas\sistema-de-productos.2-Pruebas2\sistema de productos\reportes\Factura de venta\reporte de venta.txt", true);
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
                    escribir.WriteLine("Codigo: " + fact.Codigodeproducto);
                    escribir.WriteLine("producto: " + fact.Nombreproducto);
                    escribir.WriteLine("cantidad: " + fact.Cantidad);
                    escribir.WriteLine("Total a pagar: " + suma);


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

                cmd.ExecuteNonQuery();
            }


            conexion.Close();
        }
        private void button2_Click(object sender, EventArgs e) // este boton es de realizar  la venta
                                                               //mostrara un mensaje en pantalla diciendo 
        {
            List<Venta> factven = new List<Venta>();


            foreach (DataGridViewRow filas in dataGridView1.Rows)
            {
                Venta fact = new Venta();

                if (filas.Cells[0].Value != null)
                {
                    fact.Codigodeproducto = (string)filas.Cells[0].Value;
                    fact.Nombreproducto = (string)filas.Cells[1].Value;
                    fact.PrecioVenta = (string)filas.Cells[2].Value;
                    fact.Stock = (string)filas.Cells[3].Value;
                    fact.Cantidad=(decimal)filas.Cells[5].Value;

                    factven.Add(fact);

                }



            }

            InsertarVenta(factven);


            MessageBox.Show("Se ha Realizado Exitosamente");


            MessageBox.Show("Se ha guardado el reporte de esta venta ");
            panel1.ResetText();
            panel2.ResetText();

            dataGridView1.Rows.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //parte donde se introduce el efectivo para que haga el descuento
        {
            
            double total = Convert.ToDouble(suma); // Total a pagar
            double efectivo = Convert.ToDouble(textBox3.Text); // Dinero entregado por el usuario
            double devolucion = - total + efectivo ; // Calcula la cantidad a devolver

            // Muestra la cantidad a devolver en el Label "devolucion"
            lbldevolucion.Text = devolucion.ToString();

          
        }

        int Conteo;
        private int precio;

        public int Cantidad { get; private set; }
        public static object SelectedValue { get; private set; }

        //Se puso global para que lo calculara de ahí
        decimal suma = 0;
        private void button3_Click(object sender, EventArgs e) // boton vender
        {
            
            // Recorrer el DataGridView y sumar el total de la venta
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                

                if  (row.Cells[6].Value != null) //5 es "Sub-Precio"
                { 
                    suma += Convert.ToDecimal(row.Cells[6].Value);
                }

                // Mostrar el total en el TextBox
                lblCostoApagar.Text = suma.ToString(
                lblCostoApagar.Text = "C");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2_productos(this); //cuando precione del boton de productos se abre el segundo form
          
            formulario.Show();

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

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Todos los datos extraidos de producto lo agrega aquí

            string Vtxtnombre = txtNombreProducto.Text;  // Recupera el valor del primer TextBox
            string codigo = txtCodigo.Text;                                  
            string VtxtprecioVenta = txtPrecioVenta.Text; // Recupera el valor del segundo TextBox
            string VtxtStock = TxtStock.Text;     // Recupera el valor del tercero TextBox
            string VfechaVencimiento = txtFechaVencimiento.Text;    // Recupera el valor del sexto TextBox
            decimal VnumericText = numerictext.Value;
            decimal dinero=Convert.ToInt32(VtxtprecioVenta) * VnumericText;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = codigo;
            fila.Cells[1].Value = Vtxtnombre; // Establece el valor de la primera celda
            fila.Cells[2].Value = VtxtprecioVenta; // Establece el valor de la segunda celda
            fila.Cells[3].Value = VtxtStock; // Establece el valor de la tercera celda
            fila.Cells[4].Value = VfechaVencimiento; // Establece el valor de la cuarta celda
            fila.Cells[5].Value = VnumericText;
            fila.Cells[6].Value = dinero;

            dataGridView1.Rows.Add(fila); // Agrega la fila al DataGridView

            limpiar();

        }

        private void btnReporteVenta_Click(object sender, EventArgs e)
        {
            TextReader leer = new StreamReader(@"E:\Programas\sistema-de-productos.2-Pruebas2\sistema de productos\reportes\Factura de venta\reporte de venta.txt");
            MessageBox.Show(leer.ReadToEnd());
        }
    }
}
  
    
    

