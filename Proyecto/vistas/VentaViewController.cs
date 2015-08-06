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
using Proyecto.modelos.decorated;
using Proyecto.servicios;

namespace Proyecto.vistas
{
    public partial class VentaViewController : UserControl, IViewController
    {
        private VentaController mBusinessController;
        private ProductoController mProductoController;

        private Venta mCurrentVenta;
        private List<Producto> mProductoList;

        private Producto mProductoActualSeleccionado;

        private float mTotalAPagar;

        private bool isPresented;

        private Dictionary<int, Producto> mDiccionarioProductosAVender;
        private Dictionary<int, ProductoVenta> mDiccionarioProductosARepresentar;

        public void setBusinessController(VentaController controller)
        {
            mBusinessController = controller;
        }

        public void setBusinessController(ProductoController controller)
        {
            mProductoController = controller;
        }

        public VentaViewController()
        {
            InitializeComponent();
        }

        private void VentaViewController_Load(object sender, EventArgs e)
        {
        }

        private void mProductoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mProductoSelector.SelectedItem != null)
            {
                mProductoActualSeleccionado = mProductoList.ElementAt(mProductoSelector.SelectedIndex);

                mCantidadSelector.Items.Clear();

                for (int i = 0; i < mProductoActualSeleccionado.Stock; i++)
                {
                    mCantidadSelector.Items.Add((i + 1) + "");
                }

            }
        }



        private void mBuscarAction_Click(object sender, EventArgs e)
        {
            String concidencia = mProductoBuscador.Text;

            List<Producto> template = mProductoController.buscarProductoConCoincidencia(concidencia);

            //Valido si la busqueda trae por lo menos un elemento si no tiene nada, pues ignoro la busqueda
            //Osea no hay concidencias
            if (template.Count > 0)
            {
                //Limpio el combo box
                mProductoSelector.Items.Clear();

                foreach (Producto unProductoDeLasConcidencia in template)
                {
                    mProductoSelector.Items.Add(unProductoDeLasConcidencia.Nombre);
                }

                
            }
           
        }

        private void mConfirmAction_Click(object sender, EventArgs e)
        {
            if (mCantidadSelector.SelectedItem != null)
            {
                //Sacas la cantidad de productos que se van a vender segun el producto seleccionado
                int cantidad = int.Parse(mCantidadSelector.SelectedItem.ToString());

                //Añades a esa lista de productos seleecionado el producto
                //Estos son los que envias a dar de alta en la venta

                if (!mDiccionarioProductosAVender.ContainsKey(mProductoActualSeleccionado.Identificador))
                {
                    mDiccionarioProductosAVender.Add(mProductoActualSeleccionado.Identificador, mProductoActualSeleccionado);

                    //Este producto venta se va a añadir a una lista de este tipo
                    //Sirve para mostrar al usuarios los productos
                    ProductoVenta productoVenta = new ProductoVenta();
                    productoVenta.Identificador = mProductoActualSeleccionado.Identificador;
                    productoVenta.Nombre = mProductoActualSeleccionado.Nombre;
                    productoVenta.Precio = mProductoActualSeleccionado.Precio;
                    productoVenta.Costo = mProductoActualSeleccionado.Costo;
                    productoVenta.Cantidad = cantidad;

                    mDiccionarioProductosARepresentar.Add(productoVenta.Identificador, productoVenta);
                }
                else
                {

                    ProductoVenta productoVenta = mDiccionarioProductosARepresentar[mProductoActualSeleccionado.Identificador];
                    productoVenta.Cantidad = cantidad;

                    mDiccionarioProductosARepresentar.Remove(mProductoActualSeleccionado.Identificador);

                    mDiccionarioProductosARepresentar.Add(productoVenta.Identificador, productoVenta);
                }

                refrescarLosCalculosYLaVista(cantidad);

            }

            mCantidadSelector.SelectedItem = null;

        }

        private void refrescarLosCalculosYLaVista(int cantidad)
        {

            List<ProductoVenta> elementosQueSeMuestranEnElTicket = mDiccionarioProductosARepresentar.Values.ToList();




            //Refrescas el grid view con la informacion :)
            mDetalleVentaGridView.DataSource = null;
            mDetalleVentaGridView.DataSource = elementosQueSeMuestranEnElTicket;

            //Tambien recalculas el Precio y costo que te aparecera en la venta

            float __subtotal = 0;
            float __iva = 0;
            float __total = 0;

            //Iteras cada producto seleccionado y le sumas el precio

            //Tambien lo vas a meteren el objeto de la venta we
            //Limpias lasvariables para evitar pedos
            mCurrentVenta.PrecioBruto = 0;
            mCurrentVenta.CostoBruto = 0;
            foreach (ProductoVenta cadaProducto in elementosQueSeMuestranEnElTicket)
            {
                __subtotal += cadaProducto.Precio;

                //Objectode laventa
                mCurrentVenta.CostoBruto += cadaProducto.Costo;
                mCurrentVenta.PrecioBruto += cadaProducto.Precio;

            }

            __subtotal *= cantidad;

            //Multiplicas el IVA definido en la clase constantes
            //Por el subtotal que lleves
            //Por ejemplo 0.15 * 100 te daría 15 pesos
            __iva = Constantes.IVA * __subtotal;

            __total = __iva + __subtotal;

            mSubTotal.Text = String.Format("$ {0:0.00} pesos", __subtotal);
            mIVA.Text = String.Format("$ {0:0.00} pesos", __iva);
            mTotal.Text = String.Format("$ {0:0.00} pesos", __total);

            mTotalAPagar = __total;
        }

        private void mConfirmarPagoAction_Click(object sender, EventArgs e)
        {
            try
            {
                float pago = float.Parse(mPagoCliente.Text);

                if (pago < mTotalAPagar)
                {
                    MessageBox.Show("Parece que el pago es inferior al monto a pagar", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    float cambio = pago - mTotalAPagar;
                    //TODO imprimir pago
                    //Todo imprimir cambio

                    String mensajito =
                        "Total a Pagar " + String.Format("$ {0:0.00} pesos", mTotalAPagar) + "\n" +
                        "Su Pago fue " + String.Format("$ {0:0.00} pesos", pago) + "\n" +
                        "Su Cambio es " + String.Format("$ {0:0.00} pesos", cambio) + "\n";


                    MessageBox.Show(mensajito, "Gracias por la compra!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //En parelelo vamos a crear la ventaaquí

                    List<ContenidoVenta> contenidosDeLaVenta = new List<ContenidoVenta>();

                    List<ProductoVenta> elementosQueSeMuestranEnElTicket = mDiccionarioProductosARepresentar.Values.ToList();

                    foreach (ProductoVenta unProductoDeQueSeVaAVender in elementosQueSeMuestranEnElTicket)
                    {
                        ContenidoVenta contenidoVenta = new ContenidoVenta();
                        contenidoVenta.idProducto = unProductoDeQueSeVaAVender.Identificador;
                        contenidoVenta.cantidad = unProductoDeQueSeVaAVender.Cantidad;
                        contenidoVenta.costoUnitario = unProductoDeQueSeVaAVender.Costo;
                        contenidoVenta.precioUnitario = unProductoDeQueSeVaAVender.Precio;
                        contenidosDeLaVenta.Add(contenidoVenta);
                    }



                    mBusinessController.agregarUnaNuevaAlHistorial(mCurrentVenta, contenidosDeLaVenta);

                }

            }
            catch (Exception excp)
            {
                MessageBox.Show("Verifique la el monto ingresado", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }



        public void onReloadData()
        {
            mProductoList = mProductoController.obtenerListaDeProductos();

            mProductoSelector.Items.Clear();

            mProductoSelector.SelectedItem = null;

            foreach (Producto unProducto in mProductoList)
            {
                mProductoSelector.Items.Add(unProducto.Nombre);
            }

            mDiccionarioProductosAVender = new Dictionary<int, Producto>();

            mDiccionarioProductosARepresentar = new Dictionary<int, ProductoVenta>();

            DateTime today = DateTime.Today;

            mFecha.Text = String.Format("A la fecha: {0:MM/dd/yy}", today);

            mCurrentVenta = new Venta();
            mCurrentVenta.Fecha = today;

            mCantidadSelector.SelectedItem = null;
            mProductoSelector.SelectedItem = null;

            List<ProductoVenta> elementosQueSeMuestranEnElTicket = mDiccionarioProductosARepresentar.Values.ToList();

            //Refrescas el grid view con la informacion :)
            mDetalleVentaGridView.DataSource = null;
            mDetalleVentaGridView.DataSource = elementosQueSeMuestranEnElTicket;

            mSubTotal.Text = String.Format("$ {0:0.00} pesos", 0.0f);
            mIVA.Text = String.Format("$ {0:0.00} pesos", 0.0f);
            mTotal.Text = String.Format("$ {0:0.00} pesos", 0.0f);
        }

        private void mDetalleVentaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                if (mDetalleVentaGridView.Rows[e.RowIndex].DataBoundItem != null)
                {
                    ProductoVenta productillo = (ProductoVenta)mDetalleVentaGridView.Rows[e.RowIndex].DataBoundItem;


                    String advertenciaWe = 
                        "¿Deseas eliminar este producto?\n\n"+
                        "Identificador: " + productillo.Identificador + "\n\nNombre: " + productillo.Nombre + "";

                    DialogResult result = MessageBox.Show(advertenciaWe, "Espera!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);


                    if (result == DialogResult.Yes)
                    {
                        //...
                        mDiccionarioProductosARepresentar.Remove(productillo.Identificador);

                        refrescarLosCalculosYLaVista(1);
                    }
                    
                }
            }
        }
    }
}
