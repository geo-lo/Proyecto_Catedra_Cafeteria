using CAFETERIA.ClasesNuevas;
using Proyecto_PED_CAFETERIA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            //llenamos el buscador de productos con los productos disponibles
            // Cada producto se agrega al buscador con su nombre, precio, imagen y descripción
           
            AgregarProducto("Pan", 1, 1.50, btnPan, "Comida", btnPan.Image);
            AgregarProducto("Jugo Natural", 1, 1.75, btnJugo, "Bebida", btnJugo.Image);
            AgregarProducto("Papas Fritas", 1, 1.25, btnPapas, "Snack", btnPapas.Image);
            AgregarProducto("Pastel", 1, 1.50, btnPastel, "Postre", btnPastel.Image);
            AgregarProducto("Dona Glaseada", 1, 1.25, button1, "Postre", button1.Image);
            AgregarProducto("Galletas de Chocolate", 1, 1.00, button2, "Postre", button2.Image);
            AgregarProducto("Agua", 1, 1.00, btnAgua, "Bebida", btnAgua.Image);
            AgregarProducto("Sandwich", 1, 2.50, button3, "Comida", button3.Image);
            AgregarProducto("Pancakes", 1, 2.00, button4, "Comida", button4.Image);
            AgregarProducto("Barra de Chocolate", 1, 1.25, button5, "Snack", button5.Image);
            AgregarProducto("Helado", 1, 1.50, button6, "Postre", button6.Image);
            AgregarProducto("Hot Dog", 1, 2.50, button7, "Comida", button7.Image);
            AgregarProducto("Cupcakes", 1, 1.75, button8, "Postre", button8.Image);
            AgregarProducto("Croissant", 1, 1.75, button12, "Comida", button12.Image);
            AgregarProducto("Waffles", 1, 2.00, button11, "Comida", button11.Image);
            AgregarProducto("Té Helado", 1, 1.25, button15, "Bebida", button15.Image);
            AgregarProducto("Coca-Cola", 1, 1.50, button16, "Bebida", button16.Image);
            AgregarProducto("Café Frío", 1, 1.75, button17, "Bebida", button17.Image);
            AgregarProducto("Café Caliente", 1, 1.75, button18, "Bebida", button18.Image);
            AgregarProducto("Batido de Fresa", 1, 2.50, button19, "Bebida", button19.Image);
            AgregarProducto("Limonada", 1, 1.75, button20, "Bebida", button20.Image);
            AgregarProducto("Monster", 1, 2.00, button21, "Bebida", button21.Image);
            AgregarProducto("Sprite", 1, 1.50, button22, "Bebida", button22.Image);
            AgregarProducto("Fanta", 1, 1.50, button23, "Bebida", button23.Image);
            AgregarProducto("Pepsi", 1, 1.50, button24, "Bebida", button24.Image);
            AgregarProducto("Leche", 1, 1.25, button25, "Bebida", button25.Image);
            AgregarProducto("Vino", 1, 3.00, button26, "Bebida", button26.Image);
            AgregarProducto("Cerveza", 1, 2.50, button27, "Bebida", button27.Image);
            AgregarProducto("Sushi", 1, 3.50, button60, "Mas", button60.Image);
            AgregarProducto("Cereal", 1, 1.75, button59, "Mas", button59.Image);
            AgregarProducto("Queso", 1, 2.50, button58, "Mas", button58.Image);
            AgregarProducto("Harina", 1, 1.25, button57, "Mas", button57.Image);
            AgregarProducto("Aceite", 1, 1.75, button56, "Mas", button56.Image);
            AgregarProducto("Huevos", 1, 1.50, button55, "Mas", button55.Image);
            AgregarProducto("Atún", 1, 2.00, button54, "Mas", button54.Image);
            AgregarProducto("Azúcar", 1, 1.25, button53, "Mas", button53.Image);
            AgregarProducto("Avena", 1, 1.75, button52, "Mas", button52.Image);
            AgregarProducto("Jalea de Fresa", 1, 1.50, button51, "Mas", button51.Image);
            AgregarProducto("Mantquilla de Mani", 1, 1.75, button50, "Mas", button50.Image);
            AgregarProducto("Nutella", 1, 1.75, button49, "Mas", button49.Image);
            AgregarProducto("Mayonesa", 1, 1.50, button49, "Mas", button48.Image);
            AgregarProducto("Bistec", 1, 3.00, button48, "Mas", button47.Image);
            AgregarProducto("Ketchup", 1, 1.25, button46, "Mas", button46.Image);
            AgregarProducto("Sal de Mesa", 1, 1.00, button45, "Mas", button45.Image);
        






        }
        //metodo para agregar productos al buscador
        private void AgregarProducto(string nombre,int cantidad, Double precio,Button button,string categoria,Image image)
        {
            ClaseGlobal.buscadorProductos.Agregar(
                new Producto(nombre, 1, precio, button, categoria, button.Image)
            );
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
            // Al hacer clic en el botón "Pan", se abre el formulario
            // de cantidad para ese producto específico
            // Se pasan el nombre del producto, el precio,
            // la imagen y la descripción al formulario de cantidad

            frmCantidad frm = new frmCantidad("Pan", 1.50,
                btnPan.BackgroundImage, "Pan Frances recien horneado," +
                " \ncrujiente por fuera y suave por dentro");
            estiloForm(frm);
            frm.ShowDialog();

        }
        // Método para configurar el estilo del los formularios
        private void estiloForm(Form frm)
        {
            frm.BackColor = Color.FromArgb(255, 255, 255);
            frm.ForeColor = Color.FromArgb(0, 0, 0);
            frm.Font = new Font("Unispace", 8, FontStyle.Regular);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;

            
        }

        private void btnJugo_Click(object sender, EventArgs e)
        {

            frmCantidad frm = new frmCantidad("Jugo Natural", 1.75,
                btnJugo.BackgroundImage, "Jugo Natural de Frutas," +
                "\nhecho con ingredientes frescos y sin conservantes," +
                "\nideal para refrescarte en cualquier momento del día.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void btnPapas_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Papas Fritas", 1.25, btnPapas.BackgroundImage, "Papas Fritas Caseras," +
                "\ncrujientes por fuera y suaves por dentro,\nhechas con papas frescas y sazonadas con sal," +
                "\nperfectas para acompañar tus comidas o como snack.");
            estiloForm(frm);
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
            if (ClaseGlobal.listaTemporal == null)
            {
                MessageBox.Show("No hay Productos en el Pedido", "AVISO");
                return;
            }
            if (ClaseGlobal.listaTemporal.Primero == null)
            {
                MessageBox.Show("Agregue al menos un producto", "AVISO");
                return;
            }
            // Si todas las validaciones pasan, se crea un nuevo pedido con el nombre del cliente
            // y la lista de productos seleccionados,
            // luego se encola el pedido en la cola de pedidos y se muestra un mensaje de éxito
            // Finalmente, se limpia la lista temporal
            // y el campo de nombre para preparar el formulario para un nuevo pedido
            string nombreCliente = nombreP.Text;
            Pedido pedido = new Pedido(ClaseGlobal.listaTemporal, nombreCliente);
            ClaseGlobal.colaPedidos.Encolar(pedido);
            MessageBox.Show("Pedido en la cola", "EXITO");
            ClaseGlobal.listaTemporal = new ListaProductos();
            nombreP.Text = "";

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón para ingresar el nombre del cliente
            // se abre el formulario de cliente

            frmCliente frm = new frmCliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                nombreP.Text = frm.NombreCliente;
            }

        }

        private void btnPastel_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Pastel", 1.50,
                btnPastel.BackgroundImage,
                "Pastel de Chocolate,\nhecho con ingredientes de alta calidad," +
                "\ncon una textura suave y un sabor intenso a chocolate," +
                "\nperfecto para los amantes del chocolate.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Dona Glaseada", 1.25,
                button1.BackgroundImage, "Dona Glaseada," +
                "\nhecha con masa suave y esponjosa," +
                "\ncubierta con un glaseado dulce y brillante," +
                "\nideal para disfrutar en cualquier momento del día como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Galletas de Chocolate", 1.00,
                button2.BackgroundImage, "Galletas de Chocolate," +
                "\nhechas con ingredientes de alta calidad," +
                "\ncon una textura crujiente por fuera y suave por dentro," +
                "\ncon un sabor intenso a chocolate,\nperfectas para disfrutar como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //boton sandwich agregar sandwich al form cantidad y mostrar la descripcion del producto
                frmCantidad frm = new frmCantidad("Sandwich", 2.50,
                    button3.BackgroundImage, "Sandwich de Pollo,\nhecho con ingredientes frescos y de alta calidad," +
                    "\ncon una combinación perfecta de sabores y texturas," +
                    "\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void FrmPedirOrden_Shown(object sender, EventArgs e)
        {
            // Al mostrar el formulario, se enfoca el campo de texto
            // para que el usuario pueda ingresar el nombre del cliente de inmediato
            nombreP.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                ClaseGlobal.buscadorProductos.MostrarTodos();
            }
            else
            {
                ClaseGlobal.buscadorProductos.Buscar(filtro,tablaC);
            }
            txtBuscar.Focus();
            txtBuscar.SelectionStart = txtBuscar.Text.Length;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //boton para agua agregar agua al form cantidad
            frmCantidad frm = new frmCantidad("Agua", 1.00,
                btnAgua.BackgroundImage, "Agua Mineral,\nrefrescante y pura," +
                "\nideal para hidratarte en cualquier momento del día," +
                "\nperfecta para acompañar tus comidas o disfrutarla sola.");
            estiloForm(frm);
            frm.ShowDialog();


        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                ClaseGlobal.buscadorProductos.Buscar(txtBuscar.Text, tablaC);
                e.SuppressKeyPress = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmCarrito carrito = new frmCarrito();
            carrito.ShowDialog();
            estiloForm(carrito);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //boton para pancaques agregar pancaques al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Pancakes", 2.00,
                button4.BackgroundImage, "Pancakes esponjosos,\nhechos con ingredientes de alta calidad," +
                "\ncon una textura suave y esponjosa,\nperfectos para disfrutar en el desayuno o como un delicioso postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //bton para cupcakes agregar cupcakes al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Cupcakes", 1.75,
                button8.BackgroundImage, "Cupcakes de Vainilla,\nhechos con ingredientes de alta calidad," +
                "\ncon una textura suave y esponjosa,\ncon un sabor delicioso a vainilla," +
                "\nperfectos para disfrutar como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //boton para hot dog agregar hot dog al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Hot Dog", 2.50,
                button7.BackgroundImage, "Hot Dog Clásico,\nhecho con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas," +
                "\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //boton para helado agregar helado al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Helado", 1.50,
                button6.BackgroundImage, "Helado de Vainilla,\nhecho con ingredientes de alta calidad," +
                "\ncon una textura suave y cremosa,\ncon un sabor delicioso a vainilla," +
                "\nperfecto para disfrutar como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //bton barra de chocolate agregar barra de chocolate al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Barra de Chocolate", 1.25,
                button5.BackgroundImage, "Barra de Chocolate,\nhecha con ingredientes de alta calidad," +
                "\ncon un sabor intenso a chocolate,\nperfecta para disfrutar como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //boton croasant agregar croasant al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Croissant", 1.75,
                button12.BackgroundImage, "Croissant de Mantequilla,\nhecho con ingredientes de alta calidad," +
                "\ncon una textura suave y hojaldrada,\ncon un sabor delicioso a mantequilla," +
                "\nperfecto para disfrutar en el desayuno o como un delicioso snack.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //boton para wafles agregar wafles al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Waffles", 2.00,
                button11.BackgroundImage, "Waffles esponjosos,\nhechos con ingredientes de alta calidad," +
                "\ncon una textura crujiente por fuera y suave por dentro,\nperfectos para disfrutar en el desayuno o como un delicioso postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //bton batido de fresa agregar batido de fresa al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Batido de Fresa", 2.50,
                button19.BackgroundImage, "Batido de Fresa,\nhecho con ingredientes frescos y de alta calidad," +
                "\ncon un sabor delicioso a fresa,\nperfecto para disfrutar como un refrescante snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //bton cocacola agregar cocacola al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Coca-Cola", 1.50,
                button16.BackgroundImage, "Coca-Cola,\nrefrescante y deliciosa,\ncon su sabor clásico e inconfundible," +
                "\nperfecta para disfrutar en cualquier momento del día como un refrescante acompañante para tus comidas o como una bebida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //bton te agregar te al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Té Helado", 1.25,
                button15.BackgroundImage, "Té Verde,\nrefrescante y saludable,\ncon un sabor suave y delicado," +
                "\nperfecto para disfrutar en cualquier momento del día como una bebida relajante o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //bton limonada agregar limonada al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Limonada", 1.75,
                button20.BackgroundImage, "Limonada Casera,\nrefrescante y deliciosa,\nhecha con limones frescos y azúcar," +
                "\nperfecta para disfrutar en cualquier momento del día como una bebida refrescante o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //bton fanta agregar fanta al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Fanta", 1.50,
                button23.BackgroundImage, "Fanta,\nrefrescante y deliciosa,\ncon su sabor frutal e inconfundible," +
                "\nperfecta para disfrutar en cualquier momento del día como un refrescante acompañante para tus comidas o como una bebida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //bton cafe caliente agregar cafe caliente al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Café Caliente", 1.75,
                button18.BackgroundImage, "Café Caliente,\nhecho con granos de alta calidad y preparado con esmero," +
                "\ncon un sabor intenso y aromático,\nperfecto para disfrutar en cualquier momento del día como una bebida reconfortante o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //bton cafe frio agregar cafe frio al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Café Frío", 1.75,
                button17.BackgroundImage, "Café Frío,\nhecho con granos de alta calidad y preparado con esmero," +
                "\ncon un sabor intenso y refrescante,\nperfecto para disfrutar en cualquier momento del día como una bebida reconfortante o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            //bton pepsi agregar pepsi al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Pepsi", 1.50,
                button24.BackgroundImage, "Pepsi,\nrefrescante y deliciosa,\ncon su sabor clásico e inconfundible," +
                "\nperfecta para disfrutar en cualquier momento del día como un refrescante acompañante para tus comidas o como una bebida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            //bton cerveza agregar cerveza al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Cerveza", 2.50,
                button27.BackgroundImage, "Cerveza,\nrefrescante y deliciosa,\ncon su sabor único e inconfundible," +
                "\nperfecta para disfrutar en cualquier momento del día como un acompañante para tus comidas o como una bebida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //bton sprite agregar sprite al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Sprite", 1.50,
                button22.BackgroundImage, "Sprite,\nrefrescante y deliciosa,\ncon su sabor cítrico e inconfundible," +
                "\nperfecta para disfrutar en cualquier momento del día como un refrescante acompañante para tus comidas o como una bebida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //bton mosnter agregar monster al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Monster", 2.00,
                button21.BackgroundImage, "Monster Energy,\nrefrescante y energizante,\ncon su sabor único e inconfundible," +
                "\nperfecta para disfrutar en cualquier momento del día como un acompañante para tus comidas o como una bebida sola.");
            frm.ShowDialog();
            estiloForm(frm);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //bton yogur agregar yogur al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Yogur", 1.50,
                button28.BackgroundImage, "Yogur Natural,\nrefrescante y saludable,\nhecho con ingredientes de alta calidad," +
                "\ncon un sabor suave y delicioso,\nperfecto para disfrutar como un snack saludable o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            //bton vino agregar vino al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Vino", 3.00,
                button26.BackgroundImage, "Vino Tinto,\nrefrescante y delicioso,\ncon su sabor único e inconfundible," +
                "\nperfecto para disfrutar en cualquier momento del día como un acompañante para tus comidas o como una bebida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            //bton leche agregar leche al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Leche", 1.25,
                button25.BackgroundImage, "Leche Entera,\nrefrescante y saludable,\nhecha con ingredientes de alta calidad," +
                "\ncon un sabor suave y delicioso,\nperfecta para disfrutar como un snack saludable o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }
        //todos los productos por ingresar se iran a la categoria de "Mas"
        //porque son productos que no se venden con tanta frecuencia pero que
        //igual queremos tener disponibles para nuestros clientes
        private void button60_Click(object sender, EventArgs e)
        {
            //bton sushi
            frmCantidad frm = new frmCantidad("Sushi", 3.50,
                button60.BackgroundImage, "Sushi,\nrefrescante y delicioso,\nhecho con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button59_Click(object sender, EventArgs e)
        {
            //bton cereal
            frmCantidad frm = new frmCantidad("Cereal", 1.75,
                button59.BackgroundImage, "Cereal,\nrefrescante y saludable,\nhecho con ingredientes de alta calidad," +
                "\ncon un sabor suave y delicioso,\nperfecto para disfrutar como un snack saludable o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button58_Click(object sender, EventArgs e)
        {
            //bton queso
            frmCantidad frm = new frmCantidad("Queso", 2.50,
                button58.BackgroundImage, "Queso,\nrefrescante y delicioso,\nhecho con ingredientes de alta calidad," +
                "\ncon un sabor único e inconfundible,\nperfecto para disfrutar en cualquier momento del día como un acompañante para tus comidas o como una comida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button57_Click(object sender, EventArgs e)
        {
            //boton harina agregar harina al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Harina", 1.25,
                button57.BackgroundImage, "Harina de Trigo,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para hacer diferentes tipos de comida de harina.");
            estiloForm(frm);
            frm.ShowDialog();


        }

        private void button56_Click(object sender, EventArgs e)
        {
            //bton aceite agregar aceite al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Aceite", 1.75,
                button56.BackgroundImage, "Aceite de Oliva,\nhecho con ingredientes de alta calidad," +
                "\nperfecto para cocinar diferentes tipos de comida.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button55_Click(object sender, EventArgs e)
        {
            //bton huevos
            frmCantidad frm = new frmCantidad("Huevos", 1.50,
                button55.BackgroundImage, "Huevos" +
                "\nperfectos para cocinar diferentes tipos de comida o desayunos y cenas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button54_Click(object sender, EventArgs e)
        {
            //boton atun agregar atun al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Atún", 2.00,
                button54.BackgroundImage, "Atún enlatado,\nhecho con ingredientes de alta calidad," +
                "\nperfecto para cocinar diferentes tipos de comida o como un snack saludable.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button53_Click(object sender, EventArgs e)
        {
            //boton azucar agregar azucar al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Azúcar", 1.25,
                button53.BackgroundImage, "Azúcar Blanca,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para endulzar diferentes tipos de comida o bebidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button52_Click(object sender, EventArgs e)
        {
            //boton avena enlatada agregar avena al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Avena", 1.75,
                button52.BackgroundImage, "Avena enlatada,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para cocinar diferentes tipos de comida o como un snack saludable.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button51_Click(object sender, EventArgs e)
        {
            //boton jalea de fresa agregar jalea de fresa al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Jalea de Fresa", 1.50,
                button51.BackgroundImage, "Jalea de Fresa,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para untar en pan o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button50_Click(object sender, EventArgs e)
        {
            //boton mantequilla de mani agregar mantequilla de mani al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Mantequilla de Maní", 1.75,
                button50.BackgroundImage, "Mantequilla de Maní,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para untar en pan o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button49_Click(object sender, EventArgs e)
        {
            //boton nutella agregar nutella al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Nutella", 2.00,
                button49.BackgroundImage, "Nutella,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para untar en pan o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button48_Click(object sender, EventArgs e)
        {
            //boton mayonesa agregar mayonesa al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Mayonesa", 1.50,
                button48.BackgroundImage, "Mayonesa,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para untar en pan o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button47_Click(object sender, EventArgs e)
        {
            //boton bistec agregar bistec al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Bistec", 3.00,
                button47.BackgroundImage, "Bistec de Res,\nhecho con ingredientes de alta calidad," +
                "\nperfecto para cocinar diferentes tipos de comida o como una comida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button46_Click(object sender, EventArgs e)
        {
            //boton ketchup agregar ketchup al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Ketchup", 1.25,
                button46.BackgroundImage, "Ketchup,\nhecho con ingredientes de alta calidad," +
                "\nperfecto para untar en pan o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button45_Click(object sender, EventArgs e)
        {
            //boton sal agregar sal al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Sal", 1.00,
                button45.BackgroundImage, "Sal de Mesa,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para sazonar diferentes tipos de comida o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button44_Click(object sender, EventArgs e)
        {
            //boton pescado agregar pescado al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Pescado", 2.50,
                button44.BackgroundImage, "Pescado Fresco" +
                "\nperfecto para cocinar diferentes tipos de comida o como una comida sola.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button43_Click(object sender, EventArgs e)
        {
            //boton hamburguesa agregar hamburguesa al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Hamburguesa", 2.50,
                button43.BackgroundImage, "Hamburguesa Clásica,\nhecha con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button42_Click(object sender, EventArgs e)
        {
            //boton tacos agregar tacos al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Tacos", 2.00,
                button42.BackgroundImage, "Tacos al Pastor,\nhechos con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button41_Click(object sender, EventArgs e)
        {
            //boton sopa agregar sopa al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Sopa", 1.75,
                button41.BackgroundImage, "Sopa de Pollo,\nhecha con ingredientes frescos y de alta calidad," +
                "\ncon un sabor delicioso y reconfortante,\nperfecta para disfrutar en cualquier momento del día como una comida reconfortante o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button40_Click(object sender, EventArgs e)
        {
            //boton burrito agregar burrito al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Burrito", 2.50,
                button40.BackgroundImage, "Burrito de Carne,\nhecho con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button39_Click(object sender, EventArgs e)
        {
            //boton nachos agregar nachos al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Nachos", 1.75,
                button39.BackgroundImage, "Nachos con Queso,\nhechos con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso snack o acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            //boton concha de pan agregar concha de pan al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Concha de Pan", 1.25,
                button38.BackgroundImage, "Concha de Pan,\nhecha con ingredientes de alta calidad," +
                "\ncon una textura suave y esponjosa,\ncon un sabor delicioso a pan dulce," +
                "\nperfecta para disfrutar en el desayuno o como un delicioso snack.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button37_Click(object sender, EventArgs e)
        {
            //boton pollo horneado agregar pollo horneado al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Pollo Horneado", 3.00,
                button37.BackgroundImage, "Pollo Horneado,\nPollo de la mas alta CALIDAD," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button36_Click(object sender, EventArgs e)
        {
            //boton quesadilla agregar quesadilla al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Quesadilla", 2.50,
                button36.BackgroundImage, "Quesadilla de Queso,\nhecha con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button35_Click(object sender, EventArgs e)
        {
            //boton elote loco agregar elote loco al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Elote Loco", 1.75,
                button35.BackgroundImage, "Elote Loco,\nhecho con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso snack o acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button34_Click(object sender, EventArgs e)
        {
            //boton palomitas de maiz agregar palomitas de maiz al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Palomitas de Maíz", 1.50,
                button34.BackgroundImage, "Palomitas de Maíz,\nhechas con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso snack o acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            //boton ensalada fresca agregar ensalada fresca al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Ensalada Fresca", 2.50,
                button33.BackgroundImage, "Ensalada Fresca,\nhecha con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            //boton torta mexicana agregar torta mexicana al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Torta Mexicana", 2.50,
                button32.BackgroundImage, "Torta Mexicana,\nhecha con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button31_Click(object sender, EventArgs e)
        {
            //boton tamales agregar tamales al form cantidad y mostrar la descripcion del producto
                frmCantidad frm = new frmCantidad("Tamales", 2.00,
                    button31.BackgroundImage, "Tamales,\nhechos con ingredientes frescos y de alta calidad," +
                    "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            //boton desayuno agregar desayuno al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Desayuno", 3.00,
                button30.BackgroundImage, "Desayuno Completo,\nhecho con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso desayuno o brunch.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button29_Click(object sender, EventArgs e)
        {
            //boton pasta agregar pasta al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Pasta", 2.50,
                button29.BackgroundImage, "Pasta al Pomodoro,\nhecha con ingredientes frescos y de alta calidad," +
                "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            //si el carrito esta vacio muestra mensaje de error
            if (ClaseGlobal.listaTemporal.Primero==null)
            {
                MessageBox.Show("Agregue al menos un producto");
                return;
            }
            frmCarrito carrito = new frmCarrito();
            estiloForm(carrito);
            carrito.ShowDialog();

        }
    }
}
