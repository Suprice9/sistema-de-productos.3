using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_productos.Vista
{
    public partial class Form9_reporte : Form
    {
        public Form9_reporte()
        {
            InitializeComponent();
        }

        private void Form9_reporte_Load(object sender, EventArgs e)
        {
            /* string texto = textBox1.Text;
             string archivo = "texto.txt";
             System.IO.File.WriteAllText(archivo, texto);*/
        }

        private void btn_report_Click(object sender, EventArgs e)// este boton hace la funcion de guardar todos los datos introducidos en un archivo de texto
        {
            
            {
                //inidcicamos donde querenos guardar el archivo que sera nuestro reporte
                StreamWriter escribir = new StreamWriter(@"E:\Programas\FarmaProg-master2\sistema de productos\reportes\Reporte de medicamentos\reportes.txt", true);
                try
                {
                    escribir.WriteLine("Medicamento");
                    escribir.WriteLine("↓↓↓↓↓↓↓↓↓↓↓");
                    escribir.WriteLine("nombre: "+ txt_reporte_n.Text);
                    escribir.WriteLine("De cuantos Mg: "+ txt_reporte_mg.Text);
                    escribir.WriteLine("De cuantos ml: "+ txt_reporte_ml.Text);
                    escribir.WriteLine("Cuantas Unidades: "+ txt_reporte_u.Text);
                    escribir.WriteLine("--------------------------");
                    escribir.WriteLine("\n");
                } catch
                {
                    //mensaje error
                    MessageBox.Show("error");
                }
                //cerramos proceso
                escribir.Close();

                /*
                --------------------este es el 2------------
string texto1 = textBox2.Text;//este esta nitido es que voy a probar otro
                string texto = textBox1.Text;
                string nombreArchivo = "texto.txt";
                string rutaCarpeta = @"C:\Users\enman\Desktop\Nueva carpeta\FarmaProg-master\sistema de productos\reportes"; // Reemplaza con la ruta de la carpeta donde quieras guardar el archivo
                string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);
                texto = texto.Replace("[NOTA]", "\r\n=== NOTA ===\r\n"); // Reemplaza "[NOTA]" con el texto de la nota
                System.IO.File.WriteAllText(rutaArchivo, texto1 + " " + texto);
                ----------------este es el 1------ -
                este esta bien
                /*string texto = textBox1.Text;
                string archivo = "texto.txt";
                System.IO.File.WriteAllText(archivo, texto);*/
                MessageBox.Show("se ha guardado el reporte que hizo ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextReader leer = new StreamReader(@"E:\Programas\FarmaProg-master2\sistema de productos\reportes\Reporte de medicamentos\reportes.txt");
            MessageBox.Show(leer.ReadToEnd());
          }
    }
}
