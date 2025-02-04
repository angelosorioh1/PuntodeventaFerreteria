namespace PuntodeventaFerreteria
{
    partial class VentasForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxVendedor = new ComboBox();
            textBoxBuscarCliente = new TextBox();
            dateTimePickerDe = new DateTimePicker();
            dateTimePickerAl = new DateTimePicker();
            btnBuscar = new Button();
            dataGridViewVentas = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Vendedor = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            Reimprimir = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnVentaNueva = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            SuspendLayout();
            // 
            // comboBoxVendedor
            // 
            comboBoxVendedor.FormattingEnabled = true;
            comboBoxVendedor.Location = new Point(102, 168);
            comboBoxVendedor.Name = "comboBoxVendedor";
            comboBoxVendedor.Size = new Size(209, 28);
            comboBoxVendedor.TabIndex = 0;
            // 
            // textBoxBuscarCliente
            // 
            textBoxBuscarCliente.Location = new Point(102, 262);
            textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            textBoxBuscarCliente.Size = new Size(209, 27);
            textBoxBuscarCliente.TabIndex = 1;
            textBoxBuscarCliente.TextChanged += textBoxBuscarCliente_TextChanged;
            // 
            // dateTimePickerDe
            // 
            dateTimePickerDe.Location = new Point(982, 168);
            dateTimePickerDe.Name = "dateTimePickerDe";
            dateTimePickerDe.Size = new Size(286, 27);
            dateTimePickerDe.TabIndex = 2;
            // 
            // dateTimePickerAl
            // 
            dateTimePickerAl.Location = new Point(982, 262);
            dateTimePickerAl.Name = "dateTimePickerAl";
            dateTimePickerAl.Size = new Size(286, 27);
            dateTimePickerAl.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Red;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(102, 335);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(147, 68);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.Columns.AddRange(new DataGridViewColumn[] { Cliente, Vendedor, Total, Fecha, Acciones, Borrar, Reimprimir });
            dataGridViewVentas.Location = new Point(102, 426);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.RowHeadersWidth = 51;
            dataGridViewVentas.Size = new Size(1166, 351);
            dataGridViewVentas.TabIndex = 5;
            dataGridViewVentas.CellContentClick += dataGridViewVentas_CellContentClick;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Vendedor
            // 
            Vendedor.HeaderText = "Vendedor";
            Vendedor.MinimumWidth = 6;
            Vendedor.Name = "Vendedor";
            Vendedor.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total de la venta";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.MinimumWidth = 6;
            Acciones.Name = "Acciones";
            Acciones.Width = 125;
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            Borrar.Width = 125;
            // 
            // Reimprimir
            // 
            Reimprimir.HeaderText = "Reimprimir ticket";
            Reimprimir.MinimumWidth = 6;
            Reimprimir.Name = "Reimprimir";
            Reimprimir.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 262);
            label1.Name = "label1";
            label1.Size = new Size(265, 23);
            label1.TabIndex = 6;
            label1.Text = "Busque al cliente por nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1063, 108);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 7;
            label2.Text = "Filtro por fechas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(896, 168);
            label3.Name = "label3";
            label3.Size = new Size(35, 23);
            label3.TabIndex = 8;
            label3.Text = "De";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(896, 269);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 9;
            label4.Text = "Hasta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(555, 42);
            label5.Name = "label5";
            label5.Size = new Size(288, 43);
            label5.TabIndex = 10;
            label5.Text = "Seccion de Ventas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(351, 168);
            label6.Name = "label6";
            label6.Size = new Size(220, 23);
            label6.TabIndex = 11;
            label6.Text = "Filtre segun el vendedor";
            // 
            // btnVentaNueva
            // 
            btnVentaNueva.BackColor = Color.Red;
            btnVentaNueva.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentaNueva.Location = new Point(301, 335);
            btnVentaNueva.Name = "btnVentaNueva";
            btnVentaNueva.Size = new Size(147, 68);
            btnVentaNueva.TabIndex = 12;
            btnVentaNueva.Text = "Venta Nueva";
            btnVentaNueva.UseVisualStyleBackColor = false;
            btnVentaNueva.Click += btnVentaNueva_Click;
            // 
            // VentasForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1326, 717);
            Controls.Add(btnVentaNueva);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewVentas);
            Controls.Add(btnBuscar);
            Controls.Add(dateTimePickerAl);
            Controls.Add(dateTimePickerDe);
            Controls.Add(textBoxBuscarCliente);
            Controls.Add(comboBoxVendedor);
            Name = "VentasForms";
            Load += VentasForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxVendedor;
        private TextBox textBoxBuscarCliente;
        private DateTimePicker dateTimePickerDe;
        private DateTimePicker dateTimePickerAl;
        private Button btnBuscar;
        private DataGridView dataGridViewVentas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewButtonColumn Acciones;
        private DataGridViewButtonColumn Borrar;
        private DataGridViewButtonColumn Reimprimir;
        private Button btnVentaNueva;
    }
}