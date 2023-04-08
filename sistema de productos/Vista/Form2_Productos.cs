using System;
using System.Windows.Forms;

namespace sistema_de_productos.Vista
{
    internal class Form2_Productos
    {
        public string nombreproduct { get; internal set; }
        public string preciovent { get; internal set; }
        public decimal stocks { get; internal set; }

        public static implicit operator Form(Form2_Productos v)
        {
            throw new NotImplementedException();
        }
    }
}