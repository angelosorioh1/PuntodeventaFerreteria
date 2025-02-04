namespace PuntodeventaFerreteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnVentas = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnProveedores = new Button();
            btnFacturas = new Button();
            btnEmpleados = new Button();
            btnInventario = new Button();
            btnReportes = new Button();
            panelContenido = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.HotTrack;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnVentas, 0, 0);
            tableLayoutPanel1.Controls.Add(btnProductos, 1, 0);
            tableLayoutPanel1.Controls.Add(btnClientes, 0, 1);
            tableLayoutPanel1.Controls.Add(btnProveedores, 1, 1);
            tableLayoutPanel1.Controls.Add(btnFacturas, 1, 2);
            tableLayoutPanel1.Controls.Add(btnEmpleados, 0, 3);
            tableLayoutPanel1.Controls.Add(btnInventario, 0, 2);
            tableLayoutPanel1.Controls.Add(btnReportes, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(400, 705);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.GradientActiveCaption;
            btnVentas.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.Location = new Point(3, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(148, 148);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.BottomCenter;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.GradientActiveCaption;
            btnProductos.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.Location = new Point(203, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(148, 148);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.BottomCenter;
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.GradientActiveCaption;
            btnClientes.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(3, 179);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(148, 148);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = SystemColors.GradientActiveCaption;
            btnProveedores.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.Image = (Image)resources.GetObject("btnProveedores.Image");
            btnProveedores.Location = new Point(203, 179);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(148, 148);
            btnProveedores.TabIndex = 3;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.BottomCenter;
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = SystemColors.GradientActiveCaption;
            btnFacturas.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturas.Image = (Image)resources.GetObject("btnFacturas.Image");
            btnFacturas.Location = new Point(203, 355);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(148, 148);
            btnFacturas.TabIndex = 5;
            btnFacturas.Text = "Facturas";
            btnFacturas.TextAlign = ContentAlignment.BottomCenter;
            btnFacturas.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = SystemColors.GradientActiveCaption;
            btnEmpleados.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.Location = new Point(3, 531);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(148, 148);
            btnEmpleados.TabIndex = 6;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.BottomCenter;
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.GradientActiveCaption;
            btnInventario.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new Point(3, 355);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(148, 148);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario ";
            btnInventario.TextAlign = ContentAlignment.BottomCenter;
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.GradientActiveCaption;
            btnReportes.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.Location = new Point(203, 531);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(148, 148);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.BottomCenter;
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // panelContenido
            // 
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(400, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(817, 705);
            panelContenido.TabIndex = 1;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 705);
            Controls.Add(panelContenido);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnVentas;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnProveedores;
        private Button btnInventario;
        private Button btnFacturas;
        private Button btnEmpleados;
        private Button btnReportes;
        private Panel panelContenido;
    }
}
