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
            _eliminarHandler = eliminarHandler;

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

    }
}
