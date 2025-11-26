using Prueba_XYZ.Entidades;
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
    public partial class FrmClientes : Form
    {
        int id = 0;//inicializamos variable para almacenar ID
        ClienteBLL bll = new ClienteBLL();//instanciamos la capa de negocio
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();//cargamos los datos al iniciar el formulario
            Limpiar();//limpiamos los campos
        }

        void CargarDatos()
        {
            dgvClientes.DataSource = bll.Listar();//cargamos los datos en el datagridview
        }
        void Limpiar()
        {
            id = 0;
            txtNombre.Clear();
            txtDui.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            chkEstado.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente()
                {
                    Id = this.id,
                    Nombre = txtNombre.Text,
                    Dui = txtDui.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Estado = chkEstado.Checked
                };
                int id = bll.Guardar(c);
                MessageBox.Show("Cliente guardado con exito.!");
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                id= Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Id"].Value);
                txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDui.Text = dgvClientes.Rows[e.RowIndex].Cells["Dui"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvClientes.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(dgvClientes.Rows[e.RowIndex].Cells["Estado"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }
            if(MessageBox.Show("¿Está seguro de eliminar el cliente seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bll.Eliminar(id);
                    CargarDatos();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = bll.Buscar(txtBuscar.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
