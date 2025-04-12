using ProyectoParcialTucoCrud.Aplication;
using ProyectoParcialTucoCrud.Application;
using ProyectoParcialTucoCrud.Venta.Aplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoParcialTucoCrud.FormulariosVista
{
    public partial class MenuPrincipal : Form
    {
        private readonly CrearVentaHandler _crearHandler;
        private readonly ModificarVentaHandler _modificarHandler;
        private readonly EliminarVentaHandler _eliminarHandler;

        public MenuPrincipal(CrearVentaHandler crearHandler, ModificarVentaHandler modificarHandler, EliminarVentaHandler eliminarHandler)
        {
            InitializeComponent();
            _crearHandler = crearHandler;
            _modificarHandler = modificarHandler;
<<<<<<< HEAD

            // Botón cerrar (X)
            Button btnCerrar = new Button();
            btnCerrar.Text = "X";
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrar.BackColor = Color.FromArgb(255, 77, 77);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Size = new Size(40, 30);
            btnCerrar.Location = new Point(this.Width - 50, 10);
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Click += (s, e) => { this.Close(); };
            panel1.Controls.Add(btnCerrar);

            // Botón minimizar (–)
            Button btnMinimizar = new Button();
            btnMinimizar.Text = "–";
            btnMinimizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinimizar.BackColor = Color.Gray;
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.Size = new Size(40, 30);
            btnMinimizar.Location = new Point(this.Width - 100, 10);
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            panel1.Controls.Add(btnMinimizar);

=======
            _eliminarHandler = eliminarHandler;
>>>>>>> main

        }
        private void ventaBoton_Click(object sender, EventArgs e)
        {
            var ventaRepository = new VentaCsvRepository();
            // Usa los handlers que ya recibiste en el constructor
            var ventaForm = new VentaForm(
                _crearHandler,
                _modificarHandler,
                _eliminarHandler,
                ventaRepository); // Añade el repositorio

            MostrarFormulario(ventaForm);
        }
        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(formulario);
            formulario.Show();
        }

<<<<<<< HEAD
        private void btnProductos_Click(object sender, EventArgs e)
            {
                FrmProducto frmProducto = new FrmProducto();
                MostrarFormulario(frmProducto);
            }
=======
        private void MeExit()
        {
           
            var iExit = MessageBox.Show("¿Deseas salir?", "Guardar DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit(); 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MeExit(); 
        }

>>>>>>> main
    }
}
