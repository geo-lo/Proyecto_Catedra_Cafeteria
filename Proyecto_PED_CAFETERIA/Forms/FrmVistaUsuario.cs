using CAFETERIA.ClasesNuevas;
using Proyecto_PED_CAFETERIA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PED_CAFETERIA.Forms
{
    public partial class FrmVistaUsuario : Form
    {
        string[] dialogo = { "bienvenido a la cafeteria la copa feliz.......",
        "¿listo para ordenar?.........",
        "usa el menu de tu izquierda para navegar"};
        int linea1 = 0;
        int index = 0;
        public FrmVistaUsuario()
        {
            InitializeComponent();
        }
        public void AbrirForms(Form form)
        {
            if (panelFill.Controls.Count>0)
            {
                Form actual = panelFill.Controls[0] as Form;
                if (actual != null)
                { 
                    actual.Close();
                }
            }
            panelFill.Controls.Clear();
            form.TopLevel=false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelFill.Controls.Add(form);
            panelFill.Tag = form;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ClaseGlobal.listaTemporal = new ListaProductos();
            AbrirForms(new FrmPedirOrden());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmColaPedidos());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmSalida());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForms(new FrmHistorialPedidos());

        }

        private void panelFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmVistaUsuario_Load(object sender, EventArgs e)
        {
            Bienvenida.Visible = true;
            Bienvenida.Enabled = false;
            Bienvenida.ForeColor = Color.FromArgb(100, 60, 30);
            Bienvenida.Text = "";
            timer1.Interval = 100;
            timer1.Start();

            cup1.Visible = true;
            cup2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < dialogo[linea1].Length)
            {
                Bienvenida.Text += dialogo[linea1][index];
                index++;
            }
            else
            {
                linea1++;
                if (linea1 < dialogo.Length)
                {
                    Bienvenida.Text = "";
                    index = 0;
                }
                else
                {
                    timer1.Stop();
                }
            }
        }

        private void Bienvenida_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
