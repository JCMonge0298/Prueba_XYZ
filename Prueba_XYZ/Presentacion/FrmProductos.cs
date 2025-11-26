using Prueba_XYZ.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_XYZ.Presentacion
{
    public partial class FrmProductos : Form
    {
        // Lista estática para simular persistencia en memoria durante la ejecución
        private static List<Producto> listaProductos = new List<Producto>();
        public FrmProductos()
        {
            InitializeComponent();

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            // Carga inicial: poblar con datos de ejemplo (opcional)
            if (!listaProductos.Any())
            {
                listaProductos.Add(new Producto { Id = 1, Nombre = "Café Expreso", Descripcion = "Café Expreso", Precio = 1.50M, Stock = 50, Estado = true });
                listaProductos.Add(new Producto { Id = 2, Nombre = "Croissant", Descripcion = "Café Expreso", Precio = 0.90M, Stock = 30, Estado = true });
            }

            RefrescarGrid(); // muestra la lista en el DataGridView

            /* Deshabilitamos el botón al principio porque los campos están vacíos
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = false;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // RefrescarGrid: asigna la lista como DataSource del GridView
    private void RefrescarGrid()
        {
            dgvProductos.DataSource = null; // rompe enlace previo
            dgvProductos.DataSource = listaProductos; // re-asigna la lista completa
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                //MessageBox.Show("El nombre es obligatorio.");
                MessageBox.Show("El nombre es obligatorio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (!Validaciones.EsDecimal(txtPrecio.Text))
            {
                MessageBox.Show("Precio inválido.");
                txtPrecio.Focus();
                return;
            }

            if (!Validaciones.EsEntero(txtStock.Text))
            {
                MessageBox.Show("Stock inválido.");
                txtStock.Focus();
                return;
            }

            // Crear objeto producto y asignar ID incremental manual
            int nuevoId = listaProductos.Any() ? listaProductos.Max(x => x.Id) + 1 : 1;
            var p = new Producto
            {
                Id = nuevoId,
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                Estado = chkEstado.Checked
            };

            listaProductos.Add(p); // añade a la lista en memoria
            RefrescarGrid();       // actualiza la vista
            LimpiarCampos();       // limpia controles para una nueva entrada
        }
        // Limpia los controles del formulario (preparar para nueva entrada)
        private void LimpiarCampos()
        {
            txtId.Clear(); txtNombre.Clear(); txtDescripcion.Clear(); txtPrecio.Clear(); txtStock.Clear(); chkEstado.Checked = true;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;
            txtId.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
            txtPrecio.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtStock.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            chkEstado.Checked = Convert.ToBoolean(dgvProductos.CurrentRow.Cells[5].Value);
        }

        // Evento editar: busca el producto por Id y actualiza sus campos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto válido para editar.");
                return;
            }
            var prod = listaProductos.FirstOrDefault(x => x.Id == id);
            if (prod == null) { MessageBox.Show("Producto no encontrado."); return; }

            // Validaciones iguales a Agregar
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) { MessageBox.Show("Nombre requerido."); txtNombre.Focus(); return; }
            if (!Validaciones.EsDecimal(txtPrecio.Text)) { MessageBox.Show("Precio inválido."); txtPrecio.Focus(); return; }
            if (!Validaciones.EsEntero(txtStock.Text)) { MessageBox.Show("Stock inválido."); txtStock.Focus(); return; }

            // Actualiza campos en memoria
            prod.Nombre = txtNombre.Text.Trim();
            prod.Descripcion = txtDescripcion.Text.Trim();
            prod.Precio = decimal.Parse(txtPrecio.Text);
            prod.Stock = int.Parse(txtStock.Text);
            prod.Estado = chkEstado.Checked;

            MessageBox.Show("Producto actualizado con exito.");
            RefrescarGrid();
            LimpiarCampos();
        }

        // Evento eliminar: confirma y elimina el producto de la lista
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id)) { MessageBox.Show("Seleccione un producto válido."); return; }
            var prod = listaProductos.FirstOrDefault(x => x.Id == id);
            if (prod == null) { MessageBox.Show("Producto no encontrado."); return; }
            if (MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaProductos.Remove(prod);
                RefrescarGrid();
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id)) { MessageBox.Show("Seleccione un producto válido."); return; }
            var prod = listaProductos.FirstOrDefault(x => x.Id == id);
            if (prod == null) { MessageBox.Show("Producto no encontrado."); return; }
            if (MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaProductos.Remove(prod);
                RefrescarGrid();
                LimpiarCampos();
            }
        }
    }
}
