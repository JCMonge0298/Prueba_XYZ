using Prueba_XYZ.Negocio;
using System;
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
    public partial class FrmCategoria : Form
    {
        CategoriaBLL bll = new CategoriaBLL();

        int categoriaID = 0;  // Guarda el ID seleccionado
        string Modo = "Nuevo"; // Nuevo o Editar
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
            HabilitarBotones();
        }
        //METODO PARA HABILITAR BOTONES EDITAR Y ELIMINAR
        void HabilitarBotones()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvCategoria.ClearSelection();
            dgvCategoria.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dgvCategoria.SelectedRows.Count > 0;
                btnEditar.Enabled = filaSeleccionada;
                btnEliminar.Enabled = filaSeleccionada;
            };
        }
        void CargarDatos()
        {
            dgvCategoria.DataSource = bll.Listar();
            dgvCategoria.ClearSelection();
            categoriaID = 0;   // Reiniciar ID seleccionado
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = bll.Buscar(txtFiltrar.Text);
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clickeamos una fila válida
            if (e.RowIndex >= 0)
            {
                categoriaID = Convert.ToInt32(dgvCategoria.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCategoriaGestion frm = new FrmCategoriaGestion(); //Aca dará error hasta que construyamos el Formulario llamado  FrmCategoriaGestion

            // MODO CREAR NUEVA CATEGORIA
            frm.Modo = "Nuevo"; //definimos por defecto que sea “nuevo”
            frm.Id = 0; //Guardara el Id que traigamos  del FrmCategoriaGestion

            frm.ShowDialog();  // Abrir como modal
            CargarDatos();     // Refrescar al cerrar
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (categoriaID == 0)
            {
                MessageBox.Show("Seleccione una categoría",
                   "Información",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
            FrmCategoriaGestion frm = new FrmCategoriaGestion();
            // MODO EDITAR
            frm.Modo = "Editar";
            frm.Id = categoriaID;
            // Pasar información desde el DGV
            frm.Nombre = dgvCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.Descripcion = dgvCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (categoriaID == 0)
            {
                MessageBox.Show("Seleccione una categoría",
                   "Información",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }

            // Abrir formulario de eliminación
            FrmCategoriaEliminar frm = new FrmCategoriaEliminar();

            frm.Id = categoriaID;
            frm.Nombre = dgvCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.Descripcion = dgvCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
