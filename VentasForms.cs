using System;
using System.Data;
using System.Windows.Forms;

namespace PuntodeventaFerreteria
{
    public partial class VentasForms : Form
    {
        public VentasForms()
        {
            InitializeComponent();
            CargarVendedores();
            CargarVentas();
            ConfigurarDataGridView();
        }

        private void CargarVendedores()
        {
            // Simulación de lista de vendedores
            comboBoxVendedor.Items.Add("ADMINISTRADOR");
            comboBoxVendedor.Items.Add("PAULINA FRANCO");
            comboBoxVendedor.Items.Add("DAVID HERNÁNDEZ");
            comboBoxVendedor.SelectedIndex = 0;
        }

        private void CargarVentas()
        {
            // Simulación de datos de ventas
            DataTable ventas = new DataTable();
            ventas.Columns.Add("ID", typeof(int)); // Agregamos columna ID
            ventas.Columns.Add("Cliente", typeof(string));
            ventas.Columns.Add("Vendedor", typeof(string));
            ventas.Columns.Add("Total", typeof(decimal));
            ventas.Columns.Add("Fecha", typeof(DateTime));

            ventas.Rows.Add(1, "Cliente 1", "TREINOAC (ADMIN)", 100.50m, DateTime.Now);
            ventas.Rows.Add(2, "Cliente 2", "PAULINA FRANCO", 200.75m, DateTime.Now.AddDays(-1));
            ventas.Rows.Add(3, "Cliente 3", "DAVID HERNÁNDEZ", 150.00m, DateTime.Now.AddDays(-2));

            dataGridViewVentas.DataSource = ventas;
        }

        private void ConfigurarDataGridView()
        {
            // Agregar columna de botón "Borrar"
            DataGridViewButtonColumn columnaBorrar = new DataGridViewButtonColumn();
            columnaBorrar.HeaderText = "Borrar";
            columnaBorrar.Text = "X";
            columnaBorrar.UseColumnTextForButtonValue = true;
            dataGridViewVentas.Columns.Add(columnaBorrar);

            // Agregar columna de botón "Reimprimir"
            DataGridViewButtonColumn columnaReimprimir = new DataGridViewButtonColumn();
            columnaReimprimir.HeaderText = "Reimprimir";
            columnaReimprimir.Text = "📄";
            columnaReimprimir.UseColumnTextForButtonValue = true;
            dataGridViewVentas.Columns.Add(columnaReimprimir);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar ventas por vendedor, cliente y fecha
            string vendedor = comboBoxVendedor.SelectedItem.ToString();
            string cliente = textBoxBuscarCliente.Text;
            DateTime fechaDe = dateTimePickerDe.Value.Date;
            DateTime fechaAl = dateTimePickerAl.Value.Date;

            DataTable ventasFiltradas = ((DataTable)dataGridViewVentas.DataSource).Clone();

            foreach (DataRow row in ((DataTable)dataGridViewVentas.DataSource).Rows)
            {
                if ((row["Vendedor"].ToString() == vendedor || vendedor == "Todos") &&
                    row["Cliente"].ToString().Contains(cliente) &&
                    ((DateTime)row["Fecha"]).Date >= fechaDe &&
                    ((DateTime)row["Fecha"]).Date <= fechaAl)
                {
                    ventasFiltradas.ImportRow(row);
                }
            }

            dataGridViewVentas.DataSource = ventasFiltradas;
        }

        private void dataGridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda de botón
            if (e.RowIndex >= 0 && dataGridViewVentas.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Obtener el ID de la venta
                int idVenta = Convert.ToInt32(dataGridViewVentas.Rows[e.RowIndex].Cells["ID"].Value);

                // Determinar qué botón se hizo clic
                if (e.ColumnIndex == dataGridViewVentas.Columns["Borrar"].Index)
                {
                    // Lógica para borrar la venta
                    BorrarVenta(idVenta);
                }
                else if (e.ColumnIndex == dataGridViewVentas.Columns["Reimprimir"].Index)
                {
                    // Lógica para reimprimir el ticket
                    ReimprimirTicket(idVenta);
                }
            }
        }

        private void BorrarVenta(int idVenta)
        {
            // Mostrar un mensaje de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que quieres borrar esta venta?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Lógica para borrar la venta (por ejemplo, desde la base de datos)
                // Aquí iría el código para eliminar la venta con el ID proporcionado.

                // Recargar las ventas
                CargarVentas();
                MessageBox.Show("Venta borrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReimprimirTicket(int idVenta)
        {
            // Lógica para reimprimir el ticket
            // Aquí iría el código para generar o reimprimir el ticket de la venta.
            MessageBox.Show($"Ticket de la venta {idVenta} reimpreso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes implementar búsqueda en tiempo real si lo deseas
        }

        private void VentasForms_Load(object sender, EventArgs e)
        {
            // Código de inicialización adicional si es necesario
        }

        private void btnVentaNueva_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de Venta Nueva
            VentaNuevaForm ventaNuevaForm = new VentaNuevaForm();
            ventaNuevaForm.ShowDialog(); // Mostrar como ventana emergente
        }
    }
}