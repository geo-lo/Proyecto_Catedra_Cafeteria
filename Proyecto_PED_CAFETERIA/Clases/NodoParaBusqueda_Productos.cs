using CAFETERIA.ClasesNuevas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PED_CAFETERIA.Clases
{
    internal class NodoBusqueda_Productos
    {
        public Producto Producto;
        public NodoBusqueda_Productos Siguiente;

        public NodoBusqueda_Productos(Producto producto)
        {
            Producto = producto;
            Siguiente = null;
        }
    }
}
