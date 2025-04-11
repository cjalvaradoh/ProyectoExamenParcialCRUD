using ProyectoParcialTucoCrud.Aplication;
using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Venta.Aplication;
using Ventas = ProyectoParcialTucoCrud.Domain.Entities.Venta;
using System;
using System.Windows.Forms;
using ProyectoParcialTucoCrud.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProyectoParcialTucoCrud.Domain;
using System.Diagnostics;
using System.ComponentModel;

namespace ProyectoParcialTucoCrud
{
    public partial class VentaForm : Form
    {
        private readonly BindingList<Ventas> _ventasTemporales = new();
        private readonly CrearVentaHandler _crearVentaHandler;
        private readonly ModificarVentaHandler _modificarVentaHandler;
        private readonly EliminarVentaHandler _eliminarVentaHandler;
        private readonly IVentaRepository _ventaRepository;
        public VentaForm(
         CrearVentaHandler crearVentaHandler,
         ModificarVentaHandler modificarVentaHandler,
         EliminarVentaHandler eliminarVentaHandler,
         IVentaRepository ventaRepository)
        {
            InitializeComponent();

            _crearVentaHandler = crearVentaHandler;
            _modificarVentaHandler = modificarVentaHandler;
            _eliminarVentaHandler = eliminarVentaHandler;
            _ventaRepository = ventaRepository;
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            // Configurar columnas manualmente con DataPropertyName
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdVenta",
                HeaderText = "ID Venta",
                DataPropertyName = "IdVenta" // Nombre de la propiedad en la clase Ventas
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "Fecha"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cliente",
                HeaderText = "Cliente",
                DataPropertyName = "Cliente"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MetodoPago",
                HeaderText = "Método de Pago",
                DataPropertyName = "MetodoPago"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalVenta",
                HeaderText = "Total Venta",
                DataPropertyName = "TotalVenta"
            });

            dataGridView1.DataSource = _ventasTemporales;
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

            _ventasTemporales.Add(nuevaVenta);
            MessageBox.Show("Venta guardada correctamente en memoria temporal!", "Éxito",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);


            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            textBoxIdVenta.Clear();
            textBoxFecha.Clear();
            textBoxCliente.Clear();
            textBoxMetodoPago.Clear();
            textBoxTotalVenta.Clear();
            textBoxIdVenta.Focus();
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
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0 &&
                dataGridView1.CurrentRow.Index < _ventasTemporales.Count)
            {
                try
                {
                    var venta = _ventasTemporales[dataGridView1.CurrentRow.Index];
                    venta.IdVenta = int.Parse(textBoxIdVenta.Text);
                    venta.Fecha = DateTime.Parse(textBoxFecha.Text).ToString("yyyy-MM-dd");
                    venta.Cliente = textBoxCliente.Text;
                    venta.MetodoPago = textBoxMetodoPago.Text;
                    venta.TotalVenta = decimal.Parse(textBoxTotalVenta.Text);

                    _ventasTemporales.ResetBindings();
                    MessageBox.Show("Venta modificada correctamente en memoria temporal!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta válida para modificar");
            }
        }


        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                textBoxIdVenta.Text = selectedRow.Cells["IdVenta"].Value?.ToString() ?? "";
                textBoxFecha.Text = selectedRow.Cells["Fecha"].Value?.ToString() ?? "";
                textBoxCliente.Text = selectedRow.Cells["Cliente"].Value?.ToString() ?? "";
                textBoxMetodoPago.Text = selectedRow.Cells["MetodoPago"].Value?.ToString() ?? "";
                textBoxTotalVenta.Text = selectedRow.Cells["TotalVenta"].Value?.ToString() ?? "";
            }
        }

        private void eliminarBoton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index < _ventasTemporales.Count)
            {
                _ventasTemporales.RemoveAt(dataGridView1.CurrentRow.Index);
                MessageBox.Show("Venta eliminada de memoria temporal!");
            }
        }

        private async void guardarCambiosBoton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Archivos CSV (*.csv)|*.csv";
                saveDialog.Title = "Guardar ventas como CSV";
                saveDialog.FileName = "ventas.csv";
                saveDialog.DefaultExt = "csv";
                saveDialog.AddExtension = true;


                saveDialog.AutoUpgradeEnabled = true;
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await _ventaRepository.GuardarVentasAsync(saveDialog.FileName, _ventasTemporales.ToList());
                        MessageBox.Show($"Archivo guardado correctamente en:\n{saveDialog.FileName}",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar archivo: {ex.Message}",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}