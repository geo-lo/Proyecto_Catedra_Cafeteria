using CAFETERIA.ClasesNuevas;
using Proyecto_PED_CAFETERIA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PED_CAFETERIA.Forms
{
    public partial class frmCarrito : Form
    {
        public void MostrarCarrito()
        {
            // Este método se encarga de mostrar los productos en el carrito
            // utilizando la lista temporal que almacena los productos seleccionados
            flowCarrito.Controls.Clear();
            Nodo_ListaProductos actual = ClaseGlobal.listaTemporal.Primero;
            while (actual != null)
            {
                var producto = actual.ProductoGuardado;
                Panel card = new Panel();
                card.Width = 350;
                card.Height = 90;
                card.BackColor = Color.Beige;
                card.Margin = new Padding(5);


                PictureBox pic = new PictureBox
                {
                    Image = producto.Imagen,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 60,
                    Height = 60,
                    Location = new Point(5, 10)
                };


                Label lblNombre = new Label
                {
                    Text = producto.NombreProducto,
                    Location = new Point(75, 10),
                    AutoSize = true
                };


                Label lblCantidad = new Label
                {
                    Text = "x" + producto.Cantidad,
                    Location = new Point(75, 30),
                    AutoSize = true
                };


                Label lblPrecio = new Label
                {
                    Text = "$" + (producto.Cantidad * producto.Precio),
                    Location = new Point(75, 50),
                    AutoSize = true
                };


                Button btnEliminar = new Button
                {
                    Text = "-",
                    BackColor = Color.White,
                    ForeColor = Color.Red,
                    Font = new Font("Unispace", 12, FontStyle.Bold),
                    Width = 30,
                    Height = 30,
                    Location = new Point(255, 45)
                };
                Button btnAgregar = new Button
                {
                    Text = "+",
                    BackColor = Color.White,
                    ForeColor = Color.Green,
                    Font = new Font("Unispace", 12, FontStyle.Bold),
                    Width = 30,
                    Height = 30,
                    Location = new Point(255, 10)
                };



                btnEliminar.Click += (s, e) =>
                {
                    if (producto.Cantidad > 1)
                    {
                        producto.Cantidad--;
                    }
                    else
                    {
                        ClaseGlobal.listaTemporal.EliminarProducto(producto.NombreProducto);
                    }

                    MostrarCarrito();
                };
               

                btnAgregar.Click += (s, e) =>
                {
                    Nodo_ListaProductos aux = ClaseGlobal.listaTemporal.Primero;

                    while (aux != null)
                    {
                        if (aux.ProductoGuardado.NombreProducto == producto.NombreProducto)
                        {
                            aux.ProductoGuardado.Cantidad++;
                            break;
                        }

                        aux = aux.siguiente;
                    }

                    MostrarCarrito();
                };




                card.Controls.Add(pic);
                card.Controls.Add(lblNombre);
                card.Controls.Add(lblCantidad);
                card.Controls.Add(lblPrecio);
                card.Controls.Add(btnEliminar);
                card.Controls.Add(btnAgregar);



                flowCarrito.Controls.Add(card);

                actual = actual.siguiente;
            }

            // Actualizar el total del carrito
            lblTotal.Text = "Total: $" + CalcularTotalCarrito();

        }
        // Este método calcula el total del carrito sumando
        // el precio de cada producto multiplicado por su cantidad
        public double CalcularTotalCarrito()
        {
            double total = 0;

            Nodo_ListaProductos actual = ClaseGlobal.listaTemporal.Primero;

            while (actual != null)
            {
                total += actual.ProductoGuardado.Cantidad * actual.ProductoGuardado.Precio;
                actual = actual.siguiente;
            }

            return total;
        }

        public frmCarrito()
        {
            InitializeComponent();
        }

        private void frmCarrito_Load(object sender, EventArgs e)
        {
            MostrarCarrito();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
            
        }

        private void flowCarrito_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
