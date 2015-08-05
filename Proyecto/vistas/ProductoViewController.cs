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
    public partial class ProductoViewController : UserControl, IViewController
    {
        private ProductoController mBusinessController;
        private TipoController mTipoController;
        private ModeloController mModeloController;

        private List<Tipo> mTiposList;
        private List<Modelo> mModeloList;
        private List<Producto> mProductoList;

        private Tipo mCurrentTipo;
        private Modelo mCurrentModelo;
        private Producto mCurrentProducto;

        public NotificationMessagess notificationMesagess;


        public void setBusinessController(ProductoController controller)
        {
            mBusinessController = controller;
        }

        public void setBusinessController(TipoController controller)
        {
            mTipoController = controller;
        }


        public void setBusinessController(ModeloController controller)
        {
            mModeloController = controller;
        }


        public ProductoViewController()
        {
            InitializeComponent();
        }

        private void ProductoViewController_Load(object sender, EventArgs e)
        {
            mIdentificador.Enabled = false;
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

                mBusinessController.agregarProducto(producto, mCurrentTipo, mCurrentModelo);
            }

            onReloadData();
        }

        private void mTipoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mTipoSelector.SelectedIndex >= 0)
            {
                if (mTiposList != null && mTiposList.Count > 0)
                {
                    mCurrentTipo = mTiposList.ElementAt(mTipoSelector.SelectedIndex);
                }
            }
        }

        private void mModeloSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mModeloSelector.SelectedIndex >= 0)
            {
                if (mModeloList != null && mModeloList.Count > 0)
                {
                    mCurrentModelo = mModeloList.ElementAt(mModeloSelector.SelectedIndex);
                }
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
            if (producto.Precio < producto.Costo)
            {
                notificationMesagess.showTitleAndMessage("Error", "Es ilogico que el precio sea menor al costo.");
                return;
            }

            mBusinessController.modificarProducto(producto);

            onReloadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mNombre.Text = mCurrentProducto != null ? mCurrentProducto.Nombre.ToString() : "";
            mIdentificador.Text = mCurrentProducto != null ? mCurrentProducto.Identificador.ToString() : "";
            mCosto.Text = mCurrentProducto != null ? mCurrentProducto.Costo.ToString() : "";
            mPrecio.Text = mCurrentProducto != null ? mCurrentProducto.Precio.ToString() : "";
            mStock.Text = mCurrentProducto != null ? mCurrentProducto.Stock.ToString() : "";

            mModeloSelector.SelectedItem = null;

            mTipoSelector.SelectedItem = null;

            mTipoSelector.SelectedText = null;

            mModeloSelector.SelectedText = null;

            onReloadData();
        }

        private void mProductoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            mCurrentProducto = mProductoList.ElementAt(mProductoSelector.SelectedIndex);

            mNombre.Text = mCurrentProducto != null ? mCurrentProducto.Nombre.ToString() : "";
            mIdentificador.Text = mCurrentProducto != null ? mCurrentProducto.Identificador.ToString() : "";
            mCosto.Text = mCurrentProducto != null ? mCurrentProducto.Costo.ToString() : "";
            mPrecio.Text = mCurrentProducto != null ? mCurrentProducto.Precio.ToString() : "";
            mStock.Text = mCurrentProducto != null ? mCurrentProducto.Stock.ToString() : "";

            foreach (Tipo tipo in mTiposList)
            {
                if (tipo.Identificador == mCurrentProducto.idTipo)
                {
                    mTipoSelector.SelectedText = tipo.Nombre;
                    break;
                }
            }

            foreach (Modelo modelo in mModeloList)
            {
                if (modelo.Identificador == mCurrentProducto.idModelo)
                {
                    mModeloSelector.SelectedText = modelo.Talla;
                    break;
                }
            }



            //TODO clear and setup focus to combo box
            onReloadData();

        }

        public void onReloadData()
        {
            mTipoSelector.Items.Clear();
            mModeloSelector.Items.Clear();
            mProductoSelector.Items.Clear();

            mTiposList = null;
            mModeloList = null;
            mProductoList = null;
            mCurrentTipo = null;
            mCurrentModelo = null;
            mCurrentProducto = null;

            mTiposList = mTipoController.obtenerTodosLosTiposDisponibles();

            //Iteras y pones valores
            foreach (Tipo unTipoPitero in mTiposList)
            {
                mTipoSelector.Items.Add(unTipoPitero.Nombre);
            }

            //El backend hace el query 
            mModeloList = mModeloController.obtenerTodosLosModelosDisponibles();
            //Iteras y pones valores
            foreach (Modelo unModeloCulero in mModeloList)
            {
                mModeloSelector.Items.Add(unModeloCulero.Talla);
            }

            //El backend hace el query 
            mProductoList = mBusinessController.obtenerListaDeProductos();
            //Iteras y pones valores
            foreach (Producto unProductoFellote in mProductoList)
            {
                mProductoSelector.Items.Add(unProductoFellote.Nombre);
            }
        }

        private void mNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void mStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (mStock.Text.Length > 3)
            {
                MessageBox.Show("Ha exedido el limite de 9999 piezas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
