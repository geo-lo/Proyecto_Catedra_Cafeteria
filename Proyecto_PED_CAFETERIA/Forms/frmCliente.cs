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
    public partial class frmCliente : Form
    {
        public string NombreCliente {  get; private set; }
        public frmCliente()
        {
            InitializeComponent();

        }
        public void ValidarNombre()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un Nombre");
                txtNombre.Focus();
                return;
            }
            NombreCliente = txtNombre.Text;
            NombreCliente.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarNombre();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un Nombre");
                return;
            }
            NombreCliente = txtNombre.Text;
            NombreCliente.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            lblN.Visible = true;
            lblN.ForeColor = Color.FromArgb(100, 60, 30);
            lblN.Font = new Font("UNISPACE", 7, FontStyle.Bold);
            lblN.Text = "¡Bienvenido!\nPor favor, ingresa tu nombre para comenzar tu pedido.\n" +
                "Este nombre se utilizara para identificar su Pedido";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                ValidarNombre();
            }
        }

        private void frmCliente_Shown(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
    }
}
