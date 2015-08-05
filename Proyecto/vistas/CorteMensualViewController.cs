using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.controladores;
using Proyecto.servicios;
using Proyecto.modelos;

namespace Proyecto.vistas
{
    public partial class CorteMensualViewController : UserControl, IViewController
    {
        private VentaController mBusinessController;

        public void setBusinessController(VentaController controller)
        {
            mBusinessController = controller;
        }

        public CorteMensualViewController()
        {
            InitializeComponent();
        }

        private void CorteMensualViewController_Load(object sender, EventArgs e)
        {

        }

        public void onReloadData()
        {
            List<Venta> ventas = mBusinessController.obtenerCorteDelMensual();

            float __costoUnitario = 0;
            float __precioUnitario = 0;
            float __precioUnitarioConIVA = 0;
            float __ganancias;

            foreach (Venta deCadaVenta in ventas)
            {
                __costoUnitario += deCadaVenta.CostoBruto;
                __precioUnitario += deCadaVenta.PrecioBruto;
            }

            __precioUnitarioConIVA = __precioUnitario * Constantes.IVA;

            __ganancias = __precioUnitario - __costoUnitario;

            mCostoTotal.Text = String.Format("$ {0:0.00} pesos", __costoUnitario);

            mPrecioTotalMasIva.Text = String.Format("$ {0:0.00} pesos", __precioUnitarioConIVA);

            mPrecioTotal.Text = String.Format("$ {0:0.00} pesos", __precioUnitario);

            mGanancias.Text = String.Format("$ {0:0.00} pesos", __ganancias);

            DateTime today = DateTime.Today;

            DateTime desdeFecha = new DateTime(today.Year, today.Month, 1);

            DateTime hasterFecha = new DateTime(today.Year, today.Month + 1, 1);

            String fechaABuscarDesde = String.Format("{0:yyyy-MM-dd}", desdeFecha);

            String fechaABuscarHasta = String.Format("{0:yyyy-MM-dd}", hasterFecha);

            mTitleView.Text = "Del " +fechaABuscarDesde + " hasta " + fechaABuscarHasta;

            mVentaGridView.DataSource = ventas;

        }
    }
}
