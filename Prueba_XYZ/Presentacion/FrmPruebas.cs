using Prueba_XYZ.Datos;
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
    public partial class FrmPruebas : Form
    {
        public FrmPruebas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProbarStock_Click(object sender, EventArgs e)
        {
            int stock = ProductoDAL.ObtenerStock(1); // prueba con un id real
            MessageBox.Show("Stock del producto 1: " + stock);
        }

        private void btnProbarClientes_Click(object sender, EventArgs e)
        {
            var clientes = ClienteDAL.ListarActivos();
            MessageBox.Show("Clientes activos: " + clientes.Count);
        }

        private void btnProbarPagos_Click(object sender, EventArgs e)
        {
            var pagos = TipoPagoDAL.Listar();
            MessageBox.Show("Tipos de pago: " + pagos.Count);
        }

        private void btnValidarVentasOK_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta()
            {
                Fecha = DateTime.Now,
                MontoTotal = 5.00m,
                Id_Cliente = 1,
                Id_TipoPago = 1
            };

            var detalles = new List<DetalleVenta>()
    {
        new DetalleVenta()
        {
            Id_Producto = 1,
            Cantidad = 0,
            PrecioUnitario = 5.00m,
            SubTotal = 5.00m
        }
    };

            var r = VentaBLL.ValidarVenta(venta, detalles);

            MessageBox.Show(r.Mensaje);
        }

        private void btnProbarVentaTransaccional_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta()
            {
                Fecha = DateTime.Now,
                MontoTotal = 10.00m,
                Id_Cliente = 1, // usa tu Cliente por defecto
                Id_TipoPago = 1 // efectivo (o el que tengas)
            };

            var detalles = new List<DetalleVenta>()
    {
        new DetalleVenta()
        {
            Id_Producto = 1,  // debe existir
            Cantidad = 9999,
            PrecioUnitario = 10.00m,
            SubTotal = 10.00m
        }
    };

            var r = VentaDAL.RegistrarVentaTransaccional(venta, detalles);

            MessageBox.Show(r.Mensaje);
        }
    }
}
