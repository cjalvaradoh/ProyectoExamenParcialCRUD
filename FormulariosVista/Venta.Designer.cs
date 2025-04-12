namespace ProyectoParcialTucoCrud
{
    partial class VentaForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            modificarBoton = new Button();
            eliminarBoton = new Button();
            guardarCambiosBoton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            guardarBoton = new Button();
            label2 = new Label();
            label5 = new Label();
            textBoxCliente = new TextBox();
            label6 = new Label();
            textBoxMetodoPago = new TextBox();
            label7 = new Label();
            textBoxTotalVenta = new TextBox();
            panel2 = new Panel();
            cancelarBoton = new Button();
            textBoxIdVenta = new TextBox();
            label3 = new Label();
            textBoxFecha = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(modificarBoton);
            panel1.Controls.Add(eliminarBoton);
            panel1.Controls.Add(guardarCambiosBoton);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 615);
            panel1.TabIndex = 1;
            // 
            // modificarBoton
            // 
            modificarBoton.BackColor = Color.FromArgb(255, 163, 34);
            modificarBoton.FlatAppearance.BorderSize = 0;
            modificarBoton.FlatStyle = FlatStyle.Flat;
            modificarBoton.ForeColor = Color.White;
            modificarBoton.Location = new Point(291, 489);
            modificarBoton.Name = "modificarBoton";
            modificarBoton.Size = new Size(89, 35);
            modificarBoton.TabIndex = 6;
            modificarBoton.Text = "Modificar";
            modificarBoton.UseVisualStyleBackColor = false;
            modificarBoton.Click += modificarBoton_Click;
            // 
            // eliminarBoton
            // 
            eliminarBoton.BackColor = Color.FromArgb(184, 50, 37);
            eliminarBoton.FlatAppearance.BorderSize = 0;
            eliminarBoton.FlatStyle = FlatStyle.Flat;
            eliminarBoton.ForeColor = Color.White;
            eliminarBoton.Location = new Point(198, 489);
            eliminarBoton.Name = "eliminarBoton";
            eliminarBoton.Size = new Size(87, 35);
            eliminarBoton.TabIndex = 5;
            eliminarBoton.Text = "Eliminar";
            eliminarBoton.UseVisualStyleBackColor = false;
            eliminarBoton.Click += eliminarBoton_Click;
            // 
            // guardarCambiosBoton
            // 
            guardarCambiosBoton.BackColor = Color.FromArgb(0, 174, 255);
            guardarCambiosBoton.FlatAppearance.BorderSize = 0;
            guardarCambiosBoton.FlatStyle = FlatStyle.Flat;
            guardarCambiosBoton.ForeColor = Color.White;
            guardarCambiosBoton.Location = new Point(31, 488);
            guardarCambiosBoton.Name = "guardarCambiosBoton";
            guardarCambiosBoton.Size = new Size(151, 36);
            guardarCambiosBoton.TabIndex = 4;
            guardarCambiosBoton.Text = "Guardar Cambios";
            guardarCambiosBoton.UseVisualStyleBackColor = false;
            guardarCambiosBoton.Click += guardarCambiosBoton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 243, 243);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(228, 228, 228);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(31, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 201, 201);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(190, 190, 190);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(553, 378);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.Click += DataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 62, 62);
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 29);
            label1.TabIndex = 2;
            label1.Text = "Ventas";
            // 
            // guardarBoton
            // 
            guardarBoton.BackColor = Color.FromArgb(0, 174, 255);
            guardarBoton.FlatAppearance.BorderSize = 0;
            guardarBoton.FlatStyle = FlatStyle.Flat;
            guardarBoton.ForeColor = Color.White;
            guardarBoton.Location = new Point(975, 489);
            guardarBoton.Name = "guardarBoton";
            guardarBoton.Size = new Size(92, 35);
            guardarBoton.TabIndex = 7;
            guardarBoton.Text = "Guardar";
            guardarBoton.UseVisualStyleBackColor = false;
            guardarBoton.Click += guardarBoton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(116, 116, 116);
            label2.Location = new Point(34, 24);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 8;
            label2.Text = "Ventas CRUD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(116, 116, 116);
            label5.Location = new Point(687, 238);
            label5.Name = "label5";
            label5.Size = new Size(60, 18);
            label5.TabIndex = 13;
            label5.Text = "Cliente";
            // 
            // textBoxCliente
            // 
            textBoxCliente.BackColor = Color.FromArgb(239, 239, 239);
            textBoxCliente.Location = new Point(687, 261);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(380, 24);
            textBoxCliente.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(116, 116, 116);
            label6.Location = new Point(687, 297);
            label6.Name = "label6";
            label6.Size = new Size(132, 18);
            label6.TabIndex = 15;
            label6.Text = "Metodo de Pago";
            // 
            // textBoxMetodoPago
            // 
            textBoxMetodoPago.BackColor = Color.FromArgb(239, 239, 239);
            textBoxMetodoPago.Location = new Point(687, 320);
            textBoxMetodoPago.Name = "textBoxMetodoPago";
            textBoxMetodoPago.Size = new Size(380, 24);
            textBoxMetodoPago.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(116, 116, 116);
            label7.Location = new Point(687, 361);
            label7.Name = "label7";
            label7.Size = new Size(134, 18);
            label7.TabIndex = 17;
            label7.Text = "Total de la Venta";
            // 
            // textBoxTotalVenta
            // 
            textBoxTotalVenta.BackColor = Color.FromArgb(239, 239, 239);
            textBoxTotalVenta.Location = new Point(687, 392);
            textBoxTotalVenta.Name = "textBoxTotalVenta";
            textBoxTotalVenta.Size = new Size(380, 24);
            textBoxTotalVenta.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(623, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 59);
            panel2.TabIndex = 19;
            // 
            // cancelarBoton
            // 
            cancelarBoton.BackColor = Color.FromArgb(234, 234, 234);
            cancelarBoton.FlatAppearance.BorderSize = 0;
            cancelarBoton.FlatStyle = FlatStyle.Flat;
            cancelarBoton.ForeColor = Color.FromArgb(114, 114, 114);
            cancelarBoton.Location = new Point(687, 482);
            cancelarBoton.Name = "cancelarBoton";
            cancelarBoton.Size = new Size(83, 35);
            cancelarBoton.TabIndex = 20;
            cancelarBoton.Text = "Cancelar";
            cancelarBoton.UseVisualStyleBackColor = false;
            cancelarBoton.Click += cancelarBoton_Click;
            // 
            // textBoxIdVenta
            // 
            textBoxIdVenta.BackColor = Color.FromArgb(239, 239, 239);
            textBoxIdVenta.Location = new Point(687, 149);
            textBoxIdVenta.Name = "textBoxIdVenta";
            textBoxIdVenta.Size = new Size(380, 24);
            textBoxIdVenta.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(116, 116, 116);
            label3.Location = new Point(687, 111);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 21;
            label3.Text = "Id Venta";
            // 
            // textBoxFecha
            // 
            textBoxFecha.BackColor = Color.FromArgb(239, 239, 239);
            textBoxFecha.Location = new Point(687, 206);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(380, 24);
            textBoxFecha.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(116, 116, 116);
            label4.Location = new Point(687, 181);
            label4.Name = "label4";
            label4.Size = new Size(54, 18);
            label4.TabIndex = 23;
            label4.Text = "Fecha";
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1151, 615);
            Controls.Add(textBoxFecha);
            Controls.Add(label4);
            Controls.Add(textBoxIdVenta);
            Controls.Add(label3);
            Controls.Add(cancelarBoton);
            Controls.Add(guardarBoton);
            Controls.Add(panel2);
            Controls.Add(textBoxTotalVenta);
            Controls.Add(label7);
            Controls.Add(textBoxMetodoPago);
            Controls.Add(label6);
            Controls.Add(textBoxCliente);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "VentaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += VentaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button modificarBoton;
        private Button eliminarBoton;
        private Button guardarCambiosBoton;
        private DataGridView dataGridView1;
        private Label label1;
        private Button guardarBoton;
        private Label label2;
        private Label label5;
        private TextBox textBoxCliente;
        private Label label6;
        private TextBox textBoxMetodoPago;
        private Label label7;
        private TextBox textBoxTotalVenta;
        private Panel panel2;
        private Button cancelarBoton;
        private TextBox textBoxIdVenta;
        private Label label3;
        private TextBox textBoxFecha;
        private Label label4;
    }
}
