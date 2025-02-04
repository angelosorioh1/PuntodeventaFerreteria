using System;
using System.Linq;
using System.Windows.Forms;

namespace PuntodeventaFerreteria
{
    public partial class VentaNuevaForm : Form
    {
        public VentaNuevaForm()
        {
            InitializeComponent();
            ConfigurarDataGridView(); // Configurar las columnas del DataGridView
            ActualizarTotales(); // Calcular y mostrar los totales iniciales
        }

        private void VentaNuevaForm_Load(object sender, EventArgs e)
        {
            // Código para ejecutar cuando el formulario se carga
            MessageBox.Show("El formulario se ha cargado correctamente.");
        }

        private void ConfigurarDataGridView()
        {
            // Configurar las columnas del DataGridView
            dataGridViewProductos.Columns.Add("Cantidad", "Cantidad");
            dataGridViewProductos.Columns.Add("Precio", "Precio");
            dataGridViewProductos.Columns.Add("Descripcion", "Descripción");
            dataGridViewProductos.Columns.Add("Importe", "Importe");

            // Agregar botones de acción
            DataGridViewButtonColumn columnaAumentar = new DataGridViewButtonColumn();
            columnaAumentar.HeaderText = "Aumentar";
            columnaAumentar.Text = "+";
            columnaAumentar.UseColumnTextForButtonValue = true;
            dataGridViewProductos.Columns.Add(columnaAumentar);

            DataGridViewButtonColumn columnaDisminuir = new DataGridViewButtonColumn();
            columnaDisminuir.HeaderText = "Disminuir";
            columnaDisminuir.Text = "-";
            columnaDisminuir.UseColumnTextForButtonValue = true;
            dataGridViewProductos.Columns.Add(columnaDisminuir);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();
            columnaEliminar.HeaderText = "Eliminar";
            columnaEliminar.Text = "X";
            columnaEliminar.UseColumnTextForButtonValue = true;
            dataGridViewProductos.Columns.Add(columnaEliminar);
        }

        private void ActualizarTotales()
        {
            // Calcular el número de artículos
            int numeroArticulos = dataGridViewProductos.Rows.Cast<DataGridViewRow>()
                .Sum(row => Convert.ToInt32(row.Cells["Cantidad"].Value));
            txtNumeroArticulos.Text = numeroArticulos.ToString();

            // Calcular el subtotal
            decimal subtotal = dataGridViewProductos.Rows.Cast<DataGridViewRow>()
                .Sum(row => Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToInt32(row.Cells["Cantidad"].Value));
            txtSubtotal.Text = subtotal.ToString("C");

            // Calcular el IVA (16%)
            decimal iva = subtotal * 0.16m;
            txtIVA.Text = iva.ToString("C");

            // Calcular el total
            decimal total = subtotal + iva;
            txtTotal.Text = total.ToString("C");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Lógica para consultar productos
            MessageBox.Show("Consultando productos...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana
            this.Close();
        }

        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {
            // Lógica para asignar la venta a un cliente
            MessageBox.Show("Venta asignada a cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            // Lógica para cancelar la venta
            MessageBox.Show("Venta cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Lógica para procesar el pago
            MessageBox.Show("Pago realizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cerrar la ventana después del pago
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar clics en los botones del DataGridView
            if (e.RowIndex >= 0 && dataGridViewProductos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string accion = dataGridViewProductos.Columns[e.ColumnIndex].HeaderText;

                switch (accion)
                {
                    case "Aumentar":
                        // Lógica para aumentar la cantidad
                        int cantidad = Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["Cantidad"].Value);
                        dataGridViewProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = cantidad + 1;
                        break;
                    case "Disminuir":
                        // Lógica para disminuir la cantidad
                        cantidad = Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["Cantidad"].Value);
                        if (cantidad > 1)
                        {
                            dataGridViewProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = cantidad - 1;
                        }
                        break;
                    case "Eliminar":
                        // Lógica para eliminar el producto
                        dataGridViewProductos.Rows.RemoveAt(e.RowIndex);
                        break;
                }

                // Actualizar los totales después de modificar la cantidad o eliminar un producto
                ActualizarTotales();
            }
        }

        private void dataGridViewProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizar los totales cuando cambie la cantidad o el precio
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridViewProductos.Columns["Cantidad"].Index || e.ColumnIndex == dataGridViewProductos.Columns["Precio"].Index))
            {
                ActualizarTotales();
            }
        }

        private void dataGridViewProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Actualizar los totales cuando se agregue una nueva fila
            ActualizarTotales();
        }

        private void dataGridViewProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Actualizar los totales cuando se elimine una fila
            ActualizarTotales();
        }

        private void btnCancelarVenta_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAsignarCliente_Click_1(object sender, EventArgs e)
        {

        }
    }
}