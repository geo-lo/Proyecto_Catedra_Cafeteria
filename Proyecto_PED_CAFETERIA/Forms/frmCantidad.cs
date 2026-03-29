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
    public partial class frmCantidad : Form
    {
        // Variables para almacenar la información del producto seleccionado
        string nombreProducto;
        Double precioProducto;
        Image imagenProducto;
        string DescripcionProducto;
        public frmCantidad()
        {
            InitializeComponent();
           
        }
        // Constructor del formulario de cantidad que recibe el nombre del producto,
        // su precio, la imagen y la descripción
        public frmCantidad(string nombre, double precio, Image imagen, string descripcionProducto)
        {
            InitializeComponent();
            nombreProducto = nombre;
            precioProducto = precio;
            imagenProducto = imagen;
            DescripcionProducto = descripcionProducto;
        }
        // Al cargar el formulario de cantidad, se muestra la imagen del producto,
        // su descripción y se configura el estilo del texto
        private void frmCantidad_Load(object sender, EventArgs e)
        {
          imagen.Image = imagenProducto;
            imagen.SizeMode = PictureBoxSizeMode.Zoom;
            lblDesc.Text = DescripcionProducto;
            lblDesc.ForeColor = Color.FromArgb(100, 60, 30);
            lblDesc.TextAlign = ContentAlignment.TopRight;
            lblDesc.Font = new Font("UNISPACE", 7, FontStyle.Bold);


        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        // Método para validar la cantidad ingresada por el usuario
        // Si la cantidad es 0, se muestra un mensaje de error
        // y se enfoca el control para que el usuario ingrese una cantidad válida
        public void validarCantidad()
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Ingrese una cantidad", "AVISO");
                numericUpDown1.Focus();
                return;

            }
            int cantidad = int.Parse(numericUpDown1.Text);
            Producto prod = new Producto(nombreProducto, cantidad, precioProducto);

            ClaseGlobal.listaTemporal.AgregarProducto(prod);

            MessageBox.Show("Producto Agregado");
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //bton aceptar
           validarCantidad();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            // Permite validar la cantidad ingresada por el usuario
            // al presionar la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                validarCantidad();
            }
        }
    }
}
