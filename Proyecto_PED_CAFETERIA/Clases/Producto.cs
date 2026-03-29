using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.ClasesNuevas
{
    public class Producto
    {

        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }

        public Double Precio { get; set; }
        public Double Total { get; set; }

        public Producto(string nombreProducto, int cantidad, double precio)
        {
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Precio = precio;
            Total = cantidad * precio;
        }
    }
}
