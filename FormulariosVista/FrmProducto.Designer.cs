namespace ProyectoParcialTucoCrud.FormulariosVista
{
    partial class FrmProducto
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
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblCategoria = new Label();
            lblStock = new Label();
            lblUnidadMedida = new Label();
            lblPrecioUnitario = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            cbCategoria = new ComboBox();
            txtStock = new TextBox();
            cbUnidadMedida = new ComboBox();
            txtPrecioUnitario = new TextBox();
            dgvProductos = new DataGridView();
            btnCrear = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(217, 37);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "CODIGO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(217, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(217, 107);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(81, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(217, 145);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(70, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "CATEGORIA";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(217, 179);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // lblUnidadMedida
            // 
            lblUnidadMedida.AutoSize = true;
            lblUnidadMedida.Location = new Point(217, 218);
            lblUnidadMedida.Name = "lblUnidadMedida";
            lblUnidadMedida.Size = new Size(45, 15);
            lblUnidadMedida.TabIndex = 5;
            lblUnidadMedida.Text = "Unidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(217, 259);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(40, 15);
            lblPrecioUnitario.TabIndex = 6;
            lblPrecioUnitario.Text = "Precio";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(331, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(248, 23);
            txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(331, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(331, 107);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(248, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(331, 145);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(248, 23);
            cbCategoria.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(331, 179);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(248, 23);
            txtStock.TabIndex = 11;
            // 
            // cbUnidadMedida
            // 
            cbUnidadMedida.FormattingEnabled = true;
            cbUnidadMedida.Location = new Point(331, 217);
            cbUnidadMedida.Name = "cbUnidadMedida";
            cbUnidadMedida.Size = new Size(248, 23);
            cbUnidadMedida.TabIndex = 12;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(331, 256);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(248, 23);
            txtPrecioUnitario.TabIndex = 13;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(39, 338);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(732, 150);
            dgvProductos.TabIndex = 14;
            dgvProductos.CellContentClick += dgvProductos_CellClick;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(228, 299);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 15;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(331, 299);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += dgvProductos_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.Location = new Point(430, 299);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(524, 299);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 500);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(dgvProductos);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(cbUnidadMedida);
            Controls.Add(txtStock);
            Controls.Add(cbCategoria);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblUnidadMedida);
            Controls.Add(lblStock);
            Controls.Add(lblCategoria);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Name = "FrmProducto";
            Text = "FrmProducto";
            Load += FrmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblCategoria;
        private Label lblStock;
        private Label lblUnidadMedida;
        private Label lblPrecioUnitario;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private ComboBox cbCategoria;
        private TextBox txtStock;
        private ComboBox cbUnidadMedida;
        private TextBox txtPrecioUnitario;
        private DataGridView dgvProductos;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}