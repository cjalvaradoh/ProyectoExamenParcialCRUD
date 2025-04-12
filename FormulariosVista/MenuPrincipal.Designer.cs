namespace ProyectoParcialTucoCrud.FormulariosVista
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 0, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);

            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;

            button2.ForeColor = Color.White;
            button2.Location = new Point(540, 14);
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Name = "button2";
            button2.Size = new Size(154, 72);
            button2.TabIndex = 1;
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = true;

            button2.Click += btnProductos_Click;

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(320, 14);
            button1.Name = "button1";
            button1.Size = new Size(154, 72);
            button1.TabIndex = 0;
            button1.Text = "Ventas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ventaBoton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 211, 255);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 69);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(1007, 461);
            panel3.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 630);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
    }
}