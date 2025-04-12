namespace ProyectoParcialTucoCrud.FormulariosVista
{
    partial class FrmProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblCategoria = new Label();
            lblStock = new Label();
            lblUnidadMedida = new Label();
            lblPrecioUnitario = new Label();

            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            cbCategoria = new ComboBox();
            txtStock = new TextBox();
            cbUnidadMedida = new ComboBox();
            txtPrecioUnitario = new TextBox();

            dgvProductos = new DataGridView();
            btnCrear = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();

            SuspendLayout();

            Font fuente = new Font("Century Gothic", 9F, FontStyle.Bold);

            // Estilo común
            BackColor = Color.WhiteSmoke;
            Font = fuente;
            ClientSize = new Size(900, 500);

            int leftLabel = 100;
            int leftInput = 220;
            int top = 60;
            int spacing = 40;


            // Labels
            Label[] labels = { lblCodigo, lblNombre, lblDescripcion, lblCategoria, lblStock, lblUnidadMedida, lblPrecioUnitario };
            string[] textos = { "Código", "Nombre", "Descripción", "Categoría", "Stock", "Unidad", "Precio" };
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = textos[i];
                labels[i].Location = new Point(leftLabel, top + spacing * i);
                labels[i].AutoSize = true;
                Controls.Add(labels[i]);
            }

            // Inputs
            txtCodigo.SetBounds(leftInput, top + spacing * 0, 200, 22);
            txtNombre.SetBounds(leftInput, top + spacing * 1, 200, 22);
            txtDescripcion.SetBounds(leftInput, top + spacing * 2, 200, 22);
            cbCategoria.SetBounds(leftInput, top + spacing * 3, 200, 22);
            txtStock.SetBounds(leftInput, top + spacing * 4, 200, 22);
            cbUnidadMedida.SetBounds(leftInput, top + spacing * 5, 200, 22);
            txtPrecioUnitario.SetBounds(leftInput, top + spacing * 6, 200, 22);

            Controls.AddRange(new Control[] {
                txtCodigo, txtNombre, txtDescripcion, cbCategoria,
                txtStock, cbUnidadMedida, txtPrecioUnitario
            });

            // Botones
            btnCrear.Text = "Crear";
            btnModificar.Text = "Modificar";
            btnEliminar.Text = "Eliminar";
            btnLimpiar.Text = "Limpiar";

            Button[] botones = { btnCrear, btnModificar, btnEliminar, btnLimpiar };
            Color[] colores = {
                Color.FromArgb(0,174,255),
                Color.FromArgb(255,163,34),
                Color.FromArgb(184,50,37),
                Color.FromArgb(200, 200, 200)
            };

            for (int i = 0; i < botones.Length; i++)
            {
                botones[i].BackColor = colores[i];
                botones[i].ForeColor = Color.White;
                botones[i].FlatStyle = FlatStyle.Flat;
                botones[i].SetBounds(leftInput + (i * 95), top + spacing * 7 + 10, 85, 28);
                Controls.Add(botones[i]);
            }

            // poner Limpiar mas abajo
            btnLimpiar.SetBounds(leftInput, top + spacing * 8 + 20, 85, 28);


            btnCrear.Click += btnCrear_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            // DataGridView
            dgvProductos.Location = new Point(500, 60);
            dgvProductos.Size = new Size(500, 360);
            dgvProductos.BackgroundColor = Color.Gainsboro;
            Controls.Add(dgvProductos);
            dgvProductos.CellClick += dgvProductos_CellClick;


            // Nombre del formulario
            Name = "FrmProducto";
            Text = "Productos";
            Load += FrmProducto_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblCodigo, lblNombre, lblDescripcion, lblCategoria, lblStock, lblUnidadMedida, lblPrecioUnitario;
        private TextBox txtCodigo, txtNombre, txtDescripcion, txtStock, txtPrecioUnitario;
        private ComboBox cbCategoria, cbUnidadMedida;
        private DataGridView dgvProductos;
        private Button btnCrear, btnModificar, btnEliminar, btnLimpiar;

        

    }
}

