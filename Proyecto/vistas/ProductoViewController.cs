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
    public partial class ProductoViewController : UserControl
    {
        public ProductoController controller;
        public TipoController tipoController;
        public ModeloController modeloController;

        private List<Tipo> mTiposList;
        private List<Modelo> mModeloList;

        private Tipo mCurrentTipo;
        private Modelo mCurrentModelo;

        public NotificationMessagess notificationMesagess;

        public ProductoViewController()
        {
            InitializeComponent();
        }

        private void ProductoViewController_Load(object sender, EventArgs e)
        {
            mTiposList = tipoController.obtenerTodosLosTiposDisponibles();

            mModeloList = modeloController.obtenerTodosLosModelosDisponibles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mTiposList == null)
            {
                notificationMesagess.showTitleAndMessage("Error", "Aun no has seleccionado un tipo");
                return;
            }
            else if (mModeloList == null)
            {
                notificationMesagess.showTitleAndMessage("Error", "Aun no has seleccionado un modelo");
                return;
            }
            else
            {
                Producto producto = new Producto();
                producto.Nombre = mNombre.Text;
                producto.Costo = float.Parse(mCosto.Text);
                producto.Precio = float.Parse(mPrecio.Text);
                producto.Stock = int.Parse(mStock.Text);
                producto.idTipo = mCurrentTipo.Identificador;
                producto.idModelo = mCurrentModelo.Identificador;
                if (producto.Precio < producto.Costo)
                {
                    notificationMesagess.showTitleAndMessage("Error", "Es ilogico que el precio sea menor al costo.");
                    return;
                }

                controller.agregarProducto(producto, mCurrentTipo, mCurrentModelo);
            }
        }

        private void mTipoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mTiposList != null && mTiposList.Count > 0)
            {
                mCurrentTipo = mTiposList.ElementAt(mTipoSelector.SelectedIndex);
            }
        }

        private void mModeloSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mModeloList != null && mModeloList.Count > 0)
            {
                mCurrentModelo = mModeloList.ElementAt(mModeloSelector.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = mNombre.Text;
            producto.Costo = float.Parse(mCosto.Text);
            producto.Precio = float.Parse(mPrecio.Text);
            producto.Stock = int.Parse(mStock.Text);

            controller.modificarProducto(producto);
        }
    }
}
