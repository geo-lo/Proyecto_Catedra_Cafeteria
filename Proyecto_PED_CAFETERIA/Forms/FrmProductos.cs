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
    public partial class FrmPedirOrden : Form
    {
        string nombreProducto;
        Double precio;
        public FrmPedirOrden()
        {
            InitializeComponent();
        }

        public FrmPedirOrden(string nombreProducto, double precio)
        {
            InitializeComponent();
            this.nombreProducto = nombreProducto;
            this.precio = precio;
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            //
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Scroll_1(object sender, ScrollEventArgs e)
        {
            //
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
           

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPan_Click_1(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Pan", se abre el formulario de cantidad para ese producto específico
            // Se pasan el nombre del producto, el precio, la imagen y la descripción al formulario de cantidad

            frmCantidad frm = new frmCantidad("Pan",1.50,btnPan.BackgroundImage, "Pan Frances recien horneado, \ncrujiente por fuera y suave por dentro");
            frm.ShowDialog();
        }

        private void btnJugo_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Jugo",0.50, btnJugo.BackgroundImage,"");
            frm.ShowDialog();
        }

        private void btnPapas_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Papas",1.25,btnPapas.BackgroundImage, "");
            frm.ShowDialog();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un nombre de cliente, que haya productos en la lista temporal y
            // que se haya agregado al menos un producto antes de confirmar el pedido
            if (string.IsNullOrEmpty(nombreP.Text))
            {
                MessageBox.Show("Ingrese un Nombre", "AVISO");
                return;
                
            }
            if (ClaseGlobal.listaTemporal==null)
            {
                MessageBox.Show("No hay Productos en el Pedido","AVISO");
                return;
            }
            if (ClaseGlobal.listaTemporal.Primero==null)
            {
                MessageBox.Show("Agregue al menos un producto","AVISO");
                return;
            }
            // Si todas las validaciones pasan, se crea un nuevo pedido con el nombre del cliente
            // y la lista de productos seleccionados,
            // luego se encola el pedido en la cola de pedidos y se muestra un mensaje de éxito
            // Finalmente, se limpia la lista temporal
            // y el campo de nombre para preparar el formulario para un nuevo pedido
            string nombreCliente = nombreP.Text;
            Pedido pedido = new Pedido(ClaseGlobal.listaTemporal,nombreCliente);
            ClaseGlobal.colaPedidos.Encolar(pedido);
            MessageBox.Show("Pedido en la cola","EXITO");
            ClaseGlobal.listaTemporal = new ListaProductos();
            nombreP.Text = "";

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón para ingresar el nombre del cliente
            // se abre el formulario de cliente
            
            frmCliente frm = new frmCliente();
            if (frm.ShowDialog()==DialogResult.OK)
            {
                nombreP.Text = frm.NombreCliente;
            }
            
        }

        private void btnPastel_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Pastel",2.00,btnPastel.BackgroundImage, "");
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Dona",1.00, button1.BackgroundImage, "");
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Galletas",1.75,button2.BackgroundImage, "");
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPedirOrden_Shown(object sender, EventArgs e)
        {
            nombreP.Focus();
        }
    }
}
