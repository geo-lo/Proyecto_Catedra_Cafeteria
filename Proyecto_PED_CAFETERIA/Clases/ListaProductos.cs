using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.ClasesNuevas
{
    public class ListaProductos
    {
        public Nodo_ListaProductos Primero;

        public string ObtenerProductosTexto()
        {
            if (Primero == null)
            {
                return "Sin productos";
            }

            string texto = "";
            Nodo_ListaProductos actual = Primero;

            while (actual != null)
            {
                texto += actual.ProductoGuardado.NombreProducto
                      + " x"
                      + actual.ProductoGuardado.Cantidad + "\n";

                
                if (actual.siguiente != null)
                {
                    texto += " | ";
                }

                actual = actual.siguiente;
            }

            return texto;
        }

        public void AgregarProducto(Producto p)
        {
            Nodo_ListaProductos nuevo = new Nodo_ListaProductos(p);

            if (Primero == null)
            {
                Primero = nuevo;
            }
            else
            {
                Nodo_ListaProductos actual = Primero;

                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }

                actual.siguiente = nuevo;
            }
        }
    }
}
