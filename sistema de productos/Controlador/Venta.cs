using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_productos.Controlador
{
    public class Venta
    {
        private string nombre;

        private string nombreproducto;

        private string precioVenta;

        private string stock;

        private decimal cantidad;

        private string codigodeproducto;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
   
        public string Stock { get => stock; set => stock = value; }
     
        public decimal Cantidad { get => cantidad; set => cantidad = value; }
        public string PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Codigodeproducto { get => codigodeproducto; set => codigodeproducto = value; }
    }
}
