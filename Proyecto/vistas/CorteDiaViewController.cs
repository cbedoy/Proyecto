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
using Proyecto.modelos;
using Proyecto.servicios;

namespace Proyecto.vistas
{
    public partial class CorteDiaViewController : UserControl, IViewController
    {
        private VentaController mBusinessController;

        public void setBusinessController(VentaController controller)
        {
            mBusinessController = controller;
        }

        public CorteDiaViewController()
        {
            InitializeComponent();
        }

        private void CorteDiaViewController_Load(object sender, EventArgs e)
        {
        }

        public void onReloadData()
        {
            List<Venta> ventas = mBusinessController.obtenerCorteDelDia();

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

            String fechaABuscar = String.Format("{0:yyyy-MM-dd}", today);

            mTitleView.Text = fechaABuscar;

            mVentasGridView.DataSource = ventas;

        }
    }
}
