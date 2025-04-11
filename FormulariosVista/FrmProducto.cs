using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoParcialTucoCrud.Domain.Entities;

namespace ProyectoParcialTucoCrud.FormulariosVista
{
    public partial class FrmProducto : Form
    {
        private List<Producto> listaProductos = new List<Producto>();
        private int? idSeleccionado = null;

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cbCategoria.Items.AddRange(new string[] { "Bebidas", "Snacks", "Dulces", "Otros" });
            cbUnidadMedida.Items.AddRange(new string[] { "Unidad", "Caja", "Litro" });

            if (cbCategoria.Items.Count > 0)
                cbCategoria.SelectedIndex = 0;

            if (cbUnidadMedida.Items.Count > 0)
                cbUnidadMedida.SelectedIndex = 0;
        }

        private void CargarTabla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
        }

        private void LimpiarCampos()
        {
            // Limpia texto
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtPrecioUnitario.Text = string.Empty;

            // Limpia ComboBoxes correctamente
            cbCategoria.SelectedItem = null;
            cbCategoria.Text = string.Empty;

            cbUnidadMedida.SelectedItem = null;
            cbUnidadMedida.Text = string.Empty;

            // Deselecciona fila del DataGridView si hay alguna
            dgvProductos.ClearSelection();

            // Reinicia ID de selección
            idSeleccionado = null;
        }




        private void btnCrear_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto
            {
                IdProducto = listaProductos.Count + 1,
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Categoria = cbCategoria.Text,
                Stock = int.TryParse(txtStock.Text, out int s) ? s : 0,
                UnidadMedida = cbUnidadMedida.Text,
                PrecioUnitario = decimal.TryParse(txtPrecioUnitario.Text, out decimal p) ? p : 0
            };

            listaProductos.Add(nuevo);
            CargarTabla();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Selecciona una fila para modificar.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || !decimal.TryParse(txtPrecioUnitario.Text, out decimal precio))
            {
                MessageBox.Show("Stock debe ser un número entero y Precio un decimal válido.");
                return;
            }

            var producto = listaProductos.Find(p => p.IdProducto == idSeleccionado);

            if (producto != null)
            {
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Categoria = cbCategoria.Text;
                producto.Stock = stock;
                producto.UnidadMedida = cbUnidadMedida.Text;
                producto.PrecioUnitario = precio;

                CargarTabla();       // Refresca la tabla con los nuevos valores
                LimpiarCampos();     // Limpia los campos luego de modificar
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
                return;
            }

            // Obtener ID de la fila seleccionada
            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

            // Buscar en la lista y eliminar
            var producto = listaProductos.Find(p => p.IdProducto == id);
            if (producto != null)
            {
                listaProductos.Remove(producto);
                CargarTabla();
                LimpiarCampos();
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Producto seleccionado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                idSeleccionado = seleccionado.IdProducto;

                txtCodigo.Text = seleccionado.Codigo;
                txtNombre.Text = seleccionado.Nombre;
                txtDescripcion.Text = seleccionado.Descripcion;
                cbCategoria.Text = seleccionado.Categoria;
                txtStock.Text = seleccionado.Stock.ToString();
                cbUnidadMedida.Text = seleccionado.UnidadMedida;
                txtPrecioUnitario.Text = seleccionado.PrecioUnitario.ToString();
            }
        }
        private void dgvProductos_CellClick(object sender, EventArgs e)
        {

        }
    }
}
