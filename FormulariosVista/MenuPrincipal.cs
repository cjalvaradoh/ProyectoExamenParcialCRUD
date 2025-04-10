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


        public MenuPrincipal(CrearVentaHandler crearHandler, ModificarVentaHandler modificarHandler)
        {
            InitializeComponent();
            _crearHandler = crearHandler;
            _modificarHandler = modificarHandler;


        }
        private void ventaBoton_Click(object sender, EventArgs e)
        {
            var ventaForm = new VentaForm(_crearHandler, _modificarHandler);
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
