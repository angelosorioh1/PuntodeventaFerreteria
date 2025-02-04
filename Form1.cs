using System;
using System.Windows.Forms;

namespace PuntodeventaFerreteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Este método se usa para personalizar el dibujo del TableLayoutPanel.
            // Si no lo necesitas, puedes dejarlo vacío o eliminarlo.
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // Limpiar el panel de contenido
            panelContenido.Controls.Clear();

            // Cargar el formulario de Ventas en el panel
            VentasForms ventasForm = new VentasForms();
            ventasForm.TopLevel = false; // Indica que no es una ventana de nivel superior
            ventasForm.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            ventasForm.Dock = DockStyle.Fill; // Ajustar al tamaño del panel
            panelContenido.Controls.Add(ventasForm); // Agregar al panel
            ventasForm.Show(); // Mostrar el formulario
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}