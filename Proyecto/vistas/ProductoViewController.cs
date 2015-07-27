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
        private List<Producto> mProductoList;

        private Tipo mCurrentTipo;
        private Modelo mCurrentModelo;
        private Producto mCurrentProducto;

        public NotificationMessagess notificationMesagess;

        public ProductoViewController()
        {
            InitializeComponent();
        }

        private void ProductoViewController_Load(object sender, EventArgs e)
        {
            //El backend hace el query 
            mTiposList = tipoController.obtenerTodosLosTiposDisponibles();

            //Iteras y pones valores
            foreach(Tipo unTipoPitero in mTiposList){
                mTipoSelector.Items.Add(unTipoPitero.Nombre);
            }

            //El backend hace el query 
            mModeloList = modeloController.obtenerTodosLosModelosDisponibles();
            //Iteras y pones valores
            foreach (Modelo unModeloCulero in mModeloList)
            {
                mTipoSelector.Items.Add(unModeloCulero.Talla);
            }

            //El backend hace el query 
            mProductoList = controller.obtenerListaDeProductos();
            //Iteras y pones valores
            foreach (Producto unProductoFellote in mProductoList)
            {
                mTipoSelector.Items.Add(unProductoFellote.Nombre);
            }

            
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
            producto.Identificador = int.Parse(mIdentificador.Text);
            producto.Nombre = mNombre.Text;
            producto.Costo = float.Parse(mCosto.Text);
            producto.Precio = float.Parse(mPrecio.Text);
            producto.Stock = int.Parse(mStock.Text);

            controller.modificarProducto(producto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mNombre.Text = mCurrentProducto != null ? mCurrentProducto.Nombre.ToString() : "";
            mIdentificador.Text = mCurrentProducto != null ? mCurrentProducto.Identificador.ToString() : "";
            mCosto.Text = mCurrentProducto != null ? mCurrentProducto.Costo.ToString() : "";
            mPrecio.Text = mCurrentProducto != null ? mCurrentProducto.Precio.ToString() : "";
            mStock.Text = mCurrentProducto != null ? mCurrentProducto.Stock.ToString() : "";
            
            //TODO clear and setup focus to combo box
        }

        private void mProductoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            mCurrentProducto = mProductoList.ElementAt(mProductoSelector.SelectedIndex);

            mNombre.Text = mCurrentProducto != null ? mCurrentProducto.Nombre.ToString() : "";
            mIdentificador.Text = mCurrentProducto != null ? mCurrentProducto.Identificador.ToString() : "";
            mCosto.Text = mCurrentProducto != null ? mCurrentProducto.Costo.ToString() : "";
            mPrecio.Text = mCurrentProducto != null ? mCurrentProducto.Precio.ToString() : "";
            mStock.Text = mCurrentProducto != null ? mCurrentProducto.Stock.ToString() : "";

            //TODO clear and setup focus to combo box
        }
    }
}
