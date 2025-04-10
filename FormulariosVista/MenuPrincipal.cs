using ProyectoParcialTucoCrud.Aplication;
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
        private readonly EliminarVentaHandler _eliminarHandler;


        public MenuPrincipal(CrearVentaHandler crearHandler, EliminarVentaHandler eliminarHandler)
        {
            InitializeComponent();
            _crearHandler = crearHandler;
            _eliminarHandler = eliminarHandler;


        }
        private void ventaBoton_Click(object sender, EventArgs e)
        {
            var ventaForm = new VentaForm(_crearHandler, _eliminarHandler);
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


    }
}
