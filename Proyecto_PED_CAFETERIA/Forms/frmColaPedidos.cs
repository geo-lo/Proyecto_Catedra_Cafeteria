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
                    p.Total
                );

                actual = actual.siguiente;
            }
        }

        private void frmColaPedidos_Load(object sender, EventArgs e)
        {
            MostrarPedidos();
            estiloDataGrid(dgvPedidos);
            foreach (DataGridViewColumn col in dgvPedidos.Columns)
            {
                col.Frozen = false;
            }
          

        }
        private void estiloDataGrid(DataGridView dataHistorial)
        {
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
    }
}
