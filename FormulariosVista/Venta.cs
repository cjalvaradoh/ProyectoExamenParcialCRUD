using ProyectoParcialTucoCrud.Aplication;
using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Venta.Aplication;
using Ventas = ProyectoParcialTucoCrud.Domain.Entities.Venta;
using System;
using System.Windows.Forms;
using ProyectoParcialTucoCrud.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoParcialTucoCrud
{
    public partial class VentaForm : Form
    {
        private readonly CrearVentaHandler _crearVentaHandler;
        private readonly ModificarVentaHandler _modificarVentaHandler;
        private readonly EliminarVentaHandler _eliminarVentaHandler;

        public VentaForm(CrearVentaHandler crearVentaHandler, ModificarVentaHandler modificarVentaHandler)
        {
            _crearVentaHandler = crearVentaHandler;
            _modificarVentaHandler = modificarVentaHandler;
            InitializeComponent();
        }

        // Event handler for saving a new sale
        private async void guardarBoton_Click(object sender, EventArgs e)
        {
            // Corregir la obtención de valores de los TextBox
            if (!int.TryParse(textBoxIdVenta.Text, out int idVenta))
            {
                MessageBox.Show("Por favor ingrese un ID de venta válido.");
                return;
            }

            string fecha = textBoxFecha.Text;
            string cliente = textBoxCliente.Text;
            string metodoPago = textBoxMetodoPago.Text;
            decimal totalVenta;


            if (!decimal.TryParse(textBoxTotalVenta.Text, out totalVenta))
            {
                MessageBox.Show("Por favor ingrese un total válido.");
                return;
            }

            // Validar Fecha (debe tener formato válido)
            if (!DateTime.TryParse(textBoxFecha.Text, out DateTime fechaVenta))
            {
                MessageBox.Show("Por favor ingrese una fecha válida.");
                return;
            }

            var nuevaVenta = new Ventas
            {
                IdVenta = idVenta,
                Cliente = cliente,
                MetodoPago = metodoPago,
                TotalVenta = totalVenta,
                Fecha = fechaVenta.ToString("yyyy-MM-dd") // O el formato que desees
            };

            dataGridView1.Rows.Add(nuevaVenta.IdVenta, nuevaVenta.Fecha, nuevaVenta.Cliente, nuevaVenta.MetodoPago, nuevaVenta.TotalVenta);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBoxIdVenta.Clear();
            textBoxFecha.Clear();
            textBoxCliente.Clear();
            textBoxMetodoPago.Clear();
            textBoxTotalVenta.Clear();
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            textBoxIdVenta.Clear();
            textBoxFecha.Clear();
            textBoxCliente.Clear();
            textBoxMetodoPago.Clear();
            textBoxTotalVenta.Clear();
        }

        private void modificarBoton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Asignar los nuevos valores a las celdas
                selectedRow.Cells[0].Value = textBoxIdVenta.Text; // Cliente
                selectedRow.Cells[1].Value = textBoxFecha.Text; // Fecha
                selectedRow.Cells[2].Value = textBoxCliente.Text; // Cliente
                selectedRow.Cells[3].Value = textBoxMetodoPago.Text; // MetodoPago
                selectedRow.Cells[4].Value = textBoxTotalVenta.Text; // TotalVenta
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
            }
        }


        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay filas seleccionadas
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada
                var selectedRow = dataGridView1.SelectedRows[0];

                // Asignar valores a los TextBox
                textBoxIdVenta.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                textBoxFecha.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                textBoxCliente.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                textBoxMetodoPago.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                textBoxTotalVenta.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
            }
        }

        private void eliminarBoton_Click(object sender, EventArgs e)
        {

        }
    }
}
