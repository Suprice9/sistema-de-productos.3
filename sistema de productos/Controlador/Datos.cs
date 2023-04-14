using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_productos.Controlador
{
    public class Datos
    {
       private string codigo;
       private string idsuplidor;
       private string producto;
       private string descripcion;
       private string preciocompra;
       private string precioventa;
       private DateTime fechavenci;
       private string cantidad;

        public string Idsuplidor { get => idsuplidor; set => idsuplidor = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Preciocompra { get => preciocompra; set => preciocompra = value; }
        public string Precioventa { get => precioventa; set => precioventa = value; }
        public DateTime Fechavenci { get => fechavenci.Date; set => fechavenci = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }

  
}
