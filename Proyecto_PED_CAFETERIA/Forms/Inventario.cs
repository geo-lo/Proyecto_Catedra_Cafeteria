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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Acciones del boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultasDB repo = new ConsultasDB();
            if (int.TryParse(txtId.Text, out int id) == false)
            {

                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;

            }

            if (id <= 0)
            {
                MessageBox.Show("El id debe ser un número positivo.");
                return;
            }

            DataTable resultado = repo.BuscarPorId(id);

            if (resultado.Rows.Count > 0)
            {
                // Si lo encontró, puedes pasar los datos a los TextBox
                DataRow fila = resultado.Rows[0];
                txtNombre.Text = fila["NombreProducto"].ToString();
                txtCantidad.Text = fila["CantidadActual"].ToString();
                txtPrecio.Text = fila["PrecioUnitario"].ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }


        //Acciones del boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ConsultasDB repo = new ConsultasDB();

            // Validar que los campos no estén vacíos
            if (txtNombre.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            try 
            {
                // Validar que cantidad y precio sean números válidos
                int cantidad = int.Parse(txtCantidad.Text);
                double precio = double.Parse(txtPrecio.Text);

                if (precio < 0 || cantidad < 0)
                {
                    MessageBox.Show("Por favor, ingrese valores positivos para cantidad y precio.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para cantidad y precio.");
                return;
            }

            repo.Insertar(txtNombre.Text, int.Parse(txtCantidad.Text), double.Parse(txtPrecio.Text));
            RefrescarInventario();
        }


        //funcion para refrescar el datagridview con los datos de la tabla Inventario
        private void RefrescarInventario()
        {
            ConsultasDB repo = new ConsultasDB();
            dgvInventario.DataSource = repo.MostrarInventario();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dgvInventario.DataSource = new ConsultasDB().MostrarInventario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConsultasDB repo = new ConsultasDB();
            if (int.TryParse(txtId.Text, out int id) == false)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("El id debe ser un número positivo.");
                return;
            }

            repo.EliminarProducto(id);
            RefrescarInventario();
        }
    }
}
