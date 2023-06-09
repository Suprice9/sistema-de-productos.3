﻿using System;
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
using sistema_de_productos.Vista;
using sistema_de_productos.Controlador;

namespace sistema_de_productos
{
    public partial class Form2_productos : Form
    {
        public Frm_venta fVentas;
       

        public Form4_ventas fCompras;


        Conexion conexion = new Conexion();
        public Form2_productos()
        {
            InitializeComponent();
        }
       
        public Form2_productos(Frm_venta venta)
        {
            InitializeComponent();
            this.fVentas = venta;
            
        }

        public Form2_productos(Form4_ventas Compras)
        {
            InitializeComponent();
            this.fCompras = Compras;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sucursales_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6_sucursales();
            formulario.Show();
            
        }

        private void btn_buscar_product_Click(object sender, EventArgs e)
        {
            // Establecer la cadena de conexión a la base de datos
            string connectionString = "SERVER=localhost;DATABASE=farmaprog;UID=root;PASSWORD=;Convert Zero Datetime = True";

            // Crear una nueva conexión a la base de datos MySQL
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();

           // int Id= Convert.ToInt32(txtbox_id_buscar_product.Text);
            
            
            string  Presentacion = txtbox_presentacion_buscar_product.Text;
            string Descrip = txtbox_descripcion_buscar_product.Text;

         

            MySqlDataReader reader = null;

            string consulta = ("select * from producto  where descripcion LIkE '" + Descrip + "%'or nombreproduc LIKE '" + Presentacion + "%'");

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            data_gv_listadoproduct.DataSource = tabla;
            conexion.Close();
        }

        private void Form2_productos_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_id_buscar_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar Numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbox_presentacion_buscar_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida los valores ingresados en letras
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 225))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void data_gv_listadoproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rellenar = data_gv_listadoproduct.Rows[e.RowIndex];

            if (fVentas!=null) {
                fVentas.txtCodigo.Text = rellenar.Cells[0].Value.ToString();
                fVentas.txtNombreProducto.Text = rellenar.Cells[2].Value.ToString();
                fVentas.txtPrecioVenta.Text = rellenar.Cells[3].Value.ToString();
                fVentas.txtFechaVencimiento.Text = rellenar.Cells[5].Value.ToString();
                fVentas.TxtStock.Text = rellenar.Cells[6].Value.ToString();
            }
            if (fCompras!=null)
            {
                fCompras.txtCodigo.Text=rellenar.Cells[0].Value.ToString();
                fCompras.txt_producto_compra.Text = rellenar.Cells[2].Value.ToString();
                fCompras.txt_descripcion.Text = rellenar.Cells[7].Value.ToString();
                fCompras.datatimeVencimiento.Text = rellenar.Cells[5].Value.ToString();
                fCompras.txt_precio_compra.Text = rellenar.Cells[4].Value.ToString();
                fCompras.txt_venta_compra.Text = rellenar.Cells[3].Value.ToString();
               
            }

            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
