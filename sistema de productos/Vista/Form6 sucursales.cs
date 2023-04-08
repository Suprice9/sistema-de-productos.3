using MySql.Data.MySqlClient;
using sistema_de_productos.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_productos
{
    public partial class Form6_sucursales : Form
    {
        private object txtContenido;

        public Form6_sucursales()
        {
            InitializeComponent();
        }

        /*  
         aqui estan los botones
                                                                                   */

        /*private void btn_agregar_sucursal_Click(object sender, EventArgs e)  //agrega pero no deja poner el nombre que uno quiera
        {
            // Obtener el texto del TextBox
            string nombreTabPage = txtNombreTabPage.Text;

            // Crear un nuevo TabPage con el nombre del TextBox
            TabPage nuevoTabPage2 = new TabPage(nombreTabPage);

            // Agregar el nuevo TabPage al TabControl
            tabControl1.TabPages.Add(nuevoTabPage2);
        }*/


        //codigo que esta corriendo
        /*  // Crea un nuevo objeto TabPage y establece sus propiedades

        TabPage nuevaTabPage = new TabPage();

        nuevaTabPage.Text = "Nueva pestaña";                          //aparece este que dice aqui
        nuevaTabPage.BackColor = Color.White;

        // Agrega el objeto TabPage al TabControl
        tabControl1.TabPages.Add(nuevaTabPage);

        // Selecciona la nueva pestaña para mostrar su contenido
        tabControl1.SelectedTab = nuevaTabPage;

    }*/
        //                 no esta funcionando este boton

        /* private void btn_eliminar_sucursal_Click(object sender, EventArgs e) // boton eliminar funciona bien
         {
             // Obtiene la pestaña actualmente seleccionada
             TabPage pestanaActual = tabControl1.SelectedTab;

             // Si la pestaña no es nula, la elimina del TabControl
             if (pestanaActual != null)
             {
                 tabControl1.TabPages.Remove(pestanaActual);
             }
         }*/

        private void txt_box_agregar_sucursal_TextChanged(object sender, EventArgs e) //aqui es del textbox
        {
            /*// Obtiene el nombre para el nuevo objeto TabPage   ///probando
            string nombreTabPage = txt_box_agregar_sucursal.Text;

            // Crea un nuevo objeto TabPage y establece su nombre con el contenido del TextBox
            TabPage nuevaTabPage = new TabPage();
            nuevaTabPage.Name = nombreTabPage;

            // Agrega el objeto TabPage al TabControl
            tabControl1.TabPages.Add(nuevaTabPage);

            // Selecciona la nueva pestaña para mostrar su contenido
            tabControl1.SelectedTab = nuevaTabPage;

            // Limpia el contenido del TextBox
            txt_box_agregar_sucursal.Text = "";*/


        }

        private void Form6_sucursales_Load(object sender, EventArgs e)
        {

        }
        //este boton esta funcionando correctamente
        // este boton es nuevo es para agregar la sucursales
        private void btn_agregar_Click(object sender, EventArgs e)//boton de agregar sucursales
        {
            // Obtener el texto del TextBox
            string nombreTabPage = txtNombreTabPage.Text;

            // Crear un nuevo TabPage con el nombre del TextBox
            TabPage nuevoTabPage = new TabPage(nombreTabPage);

            // Agregar el nuevo TabPage al TabControl
            tabControl1.TabPages.Add(nuevoTabPage);
        }

        // este boton es nuevo es para eliminar las sucursales esta funcionando muy bien
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Obtiene la pestaña actualmente seleccionada
            TabPage pestanaActual = tabControl1.SelectedTab;

            // Si la pestaña no es nula, la elimina del TabControl
            if (pestanaActual != null)
            {
                tabControl1.TabPages.Remove(pestanaActual);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Conectar a la base de datos
            string cadenaConexion = "Data Source=127.0.0.1;Initial Catalog=farmaprog;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            // Crear una consulta SQL
            string consulta = "SELECT * FROM sucursales";

            // Ejecutar la consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            // Crear un objeto DataTable y cargar los datos
            DataTable tabla = new DataTable();
            tabla.Load(lector);

            // Asignar la tabla al DataGridView
            dataGridView3.DataSource = tabla;

            // Cerrar la conexión
            conexion.Close();


        }

        
    }
}