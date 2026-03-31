using CAFETERIA.ClasesNuevas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PED_CAFETERIA.Clases;
namespace Proyecto_PED_CAFETERIA.Clases
{
    internal class ClaseParaBusqueda_Productos
    {
        
            public NodoBusqueda_Productos Primero;
            public void Agregar(Producto producto)
            {
                NodoBusqueda_Productos nuevo = new NodoBusqueda_Productos(producto);

                if (Primero == null)
                {
                    Primero = nuevo;
                }
                else
                {
                    NodoBusqueda_Productos actual = Primero;

                    while (actual.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }

                    actual.Siguiente = nuevo;
                }
            }

        public void Buscar(string filtro, TabControl tabC)
        {
            NodoBusqueda_Productos actual = Primero;
            filtro = filtro.ToLower();

            TabPage primeraPaginaEncontrada = null; 

            while (actual != null)
            {
                var p = actual.Producto;

                string nombre = p.NombreProducto.ToLower();
                string categoria = p.Categoria?.ToLower() ?? "";

                if (nombre.Contains(filtro) || categoria.Contains(filtro))
                {
                    p.Boton.Visible = true;

                    
                    if (primeraPaginaEncontrada == null)
                    {
                        Control parent = p.Boton.Parent;

                        while (parent != null && !(parent is TabPage))
                        {
                            parent = parent.Parent;
                        }

                        if (parent is TabPage pagina)
                        {
                            primeraPaginaEncontrada = pagina;
                        }
                    }
                }
                else
                {
                    p.Boton.Visible = false;
                }

                actual = actual.Siguiente;
            }


            if (tabC != null && primeraPaginaEncontrada != null)
            {
                tabC.SelectedTab = primeraPaginaEncontrada;
            }
        }

        public void MostrarTodos()
            {
                NodoBusqueda_Productos actual = Primero;

                while (actual != null)
                {
                    actual.Producto.Boton.Visible = true;
                    actual = actual.Siguiente;
                }
            }
        }
    }
