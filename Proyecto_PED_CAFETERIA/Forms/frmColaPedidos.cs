using CAFETERIA.ClasesNuevas;
using Proyecto_PED_CAFETERIA.Clases;
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

namespace Proyecto_PED_CAFETERIA.Forms
{
    public partial class frmColaPedidos : Form
    {
        public frmColaPedidos()
        {
            InitializeComponent();
            MostrarPedidos();

        }
        public void MostrarPedidos()
        {
            dgvPedidos.Rows.Clear();
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Nodo_ColaPedidos actual = ClaseGlobal.colaPedidos.Primero;

            while (actual != null)
            {
                Pedido p = actual.PedidoGuardado;

                string productoTexto = p.ProductosSeleccionados.ObtenerProductosTexto();

                dgvPedidos.Rows.Add(
                    p.nombreCliente,
                    productoTexto,
                    p.CalcularTotal(),
                    p.ProductosSeleccionados,
                    p.Total + "$"
                );

                actual = actual.siguiente;
            }
        }

        private void frmColaPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            dgvPedidos.ReadOnly = true;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            MostrarPedidos();
            estiloDataGrid(dgvPedidos);
            foreach (DataGridViewColumn col in dgvPedidos.Columns)
            {
                col.Frozen = false;
            }


        }
        private void estiloDataGrid(DataGridView dataHistorial)
        {
            dataHistorial.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataHistorial.Columns[2].DefaultCellStyle.Format = "$0.00";

            dataHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataHistorial.BorderStyle = BorderStyle.None;
            dataHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dataHistorial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataHistorial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 150, 100);
            dataHistorial.DefaultCellStyle.SelectionForeColor = Color.White;

            dataHistorial.BackgroundColor = Color.White;
            dataHistorial.EnableHeadersVisualStyles = false;
            dataHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 60, 30);
            dataHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("UNISPACE", 8, FontStyle.Regular);

            dataHistorial.DefaultCellStyle.Font = new Font("UNISPACE", 8);
            dataHistorial.DefaultCellStyle.ForeColor = Color.Black;

            dataHistorial.RowHeadersVisible = false;

            dataHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataHistorial.MultiSelect = false;
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //este boton se encargara de eliminar el pedido seleccionado de la cola y
            //agregarlo al historial
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido", "Aviso");
                return;
            }

            int index = dgvPedidos.SelectedRows[0].Index;

            
            Pedido pedido = ClaseGlobal.colaPedidos.EliminarPorSeleccion(index);

            if (pedido == null)
            {
                MessageBox.Show("Error al procesar pedido");
                return;
            }

            string cliente = pedido.nombreCliente;
            string productos = pedido.ProductosSeleccionados.ObtenerProductosTexto();
            string total = pedido.CalcularTotal().ToString("0.00") + "$";

           
            ClaseGlobal.historial.Agregar(cliente, productos, total);
            MostrarPedidos();

            MessageBox.Show("Pedido procesado correctamente", "Éxito");
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           Application.Exit();

        }
    }
}
