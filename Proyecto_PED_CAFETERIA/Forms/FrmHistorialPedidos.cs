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
    public partial class FrmHistorialPedidos : Form
    {
        //esta linea es para poder acceder a este formulario desde otros formularios y
        //mostrar el historial actualizado

        public static FrmHistorialPedidos instancia;
        public FrmHistorialPedidos()
        {
            InitializeComponent();
            instancia = this;

        }

        public void AgregarHistorial(string cliente, string productos, string Total)
        {
            dgvHistorial.Columns.Clear();
            dgvHistorial.Columns.Add("Cliente", "Cliente");
            dgvHistorial.Columns.Add("Productos", "Productos");
            dgvHistorial.Columns.Add("Total", "Total");
            dgvHistorial.Rows.Add(cliente, productos, Total);


        }
        public void MostrarPedidos()
        {
            dgvHistorial.Rows.Clear();

            NodoHistorial actual = ClaseGlobal.historial.Primero;

            while (actual != null)
            {
                dgvHistorial.Rows.Add(
                    actual.Cliente,
                    actual.Productos,
                    actual.Total
                );

                actual = actual.siguiente;
            }

        }


        private void FrmHistorialPedidos_Load(object sender, EventArgs e)
        {
            dgvHistorial.MultiSelect = false;
            dgvHistorial.ReadOnly = true;

            MostrarPedidos();
            estiloDataGrid(dgvHistorial);
            foreach (DataGridViewColumn col in dgvHistorial.Columns)
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

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            //cuando se haga click se mostrara un mensaje que el pedido se esta preparando y
            //se eliminara del historial y se mandara a una base de datos

           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //boton para borrar el pedido seleccionado del historial,
            //se eliminara de la base de datos y del historial

        }
    }
}
