using ProyectoParcialTucoCrud.Aplication;
using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Venta.Aplication;
using Ventas = ProyectoParcialTucoCrud.Domain.Entities.Venta;
using System;
using System.Windows.Forms;

namespace ProyectoParcialTucoCrud
{
    public partial class VentaForm : Form
    {
        private readonly CrearVentaHandler _crearVentaHandler;
        private readonly EliminarVentaHandler _eliminarVentaHandler;
        private static int contadorIdVenta = 1001; 

        public VentaForm(CrearVentaHandler crearVentaHandler, EliminarVentaHandler eliminarVentaHandler)
        {
            _crearVentaHandler = crearVentaHandler;
            _eliminarVentaHandler = eliminarVentaHandler;
            InitializeComponent();
        }

        // Event handler for saving a new sale
        private async void guardarBoton_Click(object sender, EventArgs e)
        {

            string cliente = textBoxCliente.Text;
            string metodoPago = textBoxMetodoPago.Text;
            decimal totalVenta;


            if (!decimal.TryParse(textBoxTotalVenta.Text, out totalVenta))
            {
                MessageBox.Show("Por favor ingrese un total válido.");
                return;
            }

            var nuevaVenta = new Ventas
            {
                Cliente = cliente,
                MetodoPago = metodoPago,
                TotalVenta = totalVenta,
                Fecha = DateTime.Now,
                IdVenta = ObtenerNuevoIdVenta() 
            };

            dataGridView1.Rows.Add(nuevaVenta.IdVenta, nuevaVenta.Fecha, nuevaVenta.Cliente, nuevaVenta.MetodoPago, nuevaVenta.TotalVenta);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBoxCliente.Clear();
            textBoxMetodoPago.Clear();
            textBoxTotalVenta.Clear();
        }

        private int ObtenerNuevoIdVenta()
        {
           
            return contadorIdVenta++; 
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            textBoxCliente.Clear();
            textBoxMetodoPago.Clear();
            textBoxTotalVenta.Clear();
        }
    }
}
