namespace PuntodeventaFerreteria
{
    partial class VentaNuevaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaNuevaForm));
            btnConsultar = new Button();
            btnSalir = new Button();
            txtCantidad = new TextBox();
            label1 = new Label();
            txtBuscarProducto = new TextBox();
            label2 = new Label();
            dataGridViewProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            btnAsignarCliente = new Button();
            btnCancelarVenta = new Button();
            label3 = new Label();
            txtNumeroArticulos = new TextBox();
            label4 = new Label();
            txtSubtotal = new TextBox();
            label5 = new Label();
            txtIVA = new TextBox();
            txtTotal = new TextBox();
            label6 = new Label();
            btnPagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Transparent;
            btnConsultar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(207, 24);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(138, 68);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.TextAlign = ContentAlignment.MiddleRight;
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(31, 24);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(138, 68);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(31, 127);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(94, 27);
            txtCantidad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 131);
            label1.Name = "label1";
            label1.Size = new Size(169, 24);
            label1.TabIndex = 3;
            label1.Text = "Cantidad del producto";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(346, 124);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(263, 27);
            txtBuscarProducto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(646, 130);
            label2.Name = "label2";
            label2.Size = new Size(128, 24);
            label2.TabIndex = 5;
            label2.Text = "Buscar producto";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewProductos.Location = new Point(31, 221);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(940, 190);
            dataGridViewProductos.TabIndex = 6;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cantidad";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Precio";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descripcion ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Importe";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Aumentar";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Text = "+";
            Column5.UseColumnTextForButtonValue = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Disminuir";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Text = "-";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Eliminar";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Text = "X";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 125;
            // 
            // btnAsignarCliente
            // 
            btnAsignarCliente.BackColor = Color.Coral;
            btnAsignarCliente.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignarCliente.Image = (Image)resources.GetObject("btnAsignarCliente.Image");
            btnAsignarCliente.Location = new Point(31, 458);
            btnAsignarCliente.Name = "btnAsignarCliente";
            btnAsignarCliente.Size = new Size(177, 121);
            btnAsignarCliente.TabIndex = 7;
            btnAsignarCliente.Text = "Asignar venta a cliente";
            btnAsignarCliente.TextAlign = ContentAlignment.BottomCenter;
            btnAsignarCliente.UseVisualStyleBackColor = false;
            btnAsignarCliente.Click += btnAsignarCliente_Click_1;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.BackColor = SystemColors.Highlight;
            btnCancelarVenta.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarVenta.Image = (Image)resources.GetObject("btnCancelarVenta.Image");
            btnCancelarVenta.Location = new Point(283, 458);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(175, 121);
            btnCancelarVenta.TabIndex = 8;
            btnCancelarVenta.Text = "Cancelar venta";
            btnCancelarVenta.TextAlign = ContentAlignment.BottomCenter;
            btnCancelarVenta.UseVisualStyleBackColor = false;
            btnCancelarVenta.Click += btnCancelarVenta_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(985, 208);
            label3.Name = "label3";
            label3.Size = new Size(156, 24);
            label3.TabIndex = 9;
            label3.Text = "Numero de articulos";
            // 
            // txtNumeroArticulos
            // 
            txtNumeroArticulos.Location = new Point(1175, 201);
            txtNumeroArticulos.Name = "txtNumeroArticulos";
            txtNumeroArticulos.ReadOnly = true;
            txtNumeroArticulos.Size = new Size(125, 27);
            txtNumeroArticulos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(991, 253);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 11;
            label4.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(1175, 246);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(991, 315);
            label5.Name = "label5";
            label5.Size = new Size(75, 24);
            label5.TabIndex = 13;
            label5.Text = "IVA 16%";
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(1175, 308);
            txtIVA.Name = "txtIVA";
            txtIVA.ReadOnly = true;
            txtIVA.Size = new Size(125, 27);
            txtIVA.TabIndex = 14;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1175, 451);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(974, 458);
            label6.Name = "label6";
            label6.Size = new Size(195, 24);
            label6.TabIndex = 16;
            label6.Text = "TOTAL DE LA COMPRA";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Chartreuse;
            btnPagar.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(985, 510);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(315, 69);
            btnPagar.TabIndex = 17;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // VentaNuevaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 612);
            Controls.Add(btnPagar);
            Controls.Add(label6);
            Controls.Add(txtTotal);
            Controls.Add(txtIVA);
            Controls.Add(label5);
            Controls.Add(txtSubtotal);
            Controls.Add(label4);
            Controls.Add(txtNumeroArticulos);
            Controls.Add(label3);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnAsignarCliente);
            Controls.Add(dataGridViewProductos);
            Controls.Add(label2);
            Controls.Add(txtBuscarProducto);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Name = "VentaNuevaForm";
            Text = "VentaNuevaForm";
            Load += VentaNuevaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Button btnSalir;
        private TextBox txtCantidad;
        private Label label1;
        private TextBox txtBuscarProducto;
        private Label label2;
        private DataGridView dataGridViewProductos;
        private Button btnAsignarCliente;
        private Button btnCancelarVenta;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
        private Label label3;
        private TextBox txtNumeroArticulos;
        private Label label4;
        private TextBox txtSubtotal;
        private Label label5;
        private TextBox txtIVA;
        private TextBox txtTotal;
        private Label label6;
        private Button btnPagar;
    }
}