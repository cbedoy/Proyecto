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
    public partial class VentaViewController : UserControl
    {
        private VentaController mBusinessController;
        private ProductoController mProductoController;

        private Venta mCurrentVenta;
        private List<Producto> mProductoList;
        private List<Producto> mProductosSeleccionados;
        private List<ProductoVenta> mProductosSeleccionadosVenta;

        private Producto mProductoActualSeleccionado;

        private float mTotalAPagar;

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
            mProductoList = mProductoController.obtenerListaDeProductos();

            foreach (Producto unProducto in mProductoList)
            {
                mProductoSelector.Items.Add(unProducto.Nombre);
            }

            mProductosSeleccionados = new List<Producto>();
            mProductosSeleccionadosVenta = new List<ProductoVenta>();

            DateTime today = DateTime.Today;

            mFecha.Text = String.Format("The current date and time: {0:MM/dd/yy H:mm:ss}", today);

            mCurrentVenta = new Venta();
            mCurrentVenta.Fecha = today;

        }

        private void mProductoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            mProductoActualSeleccionado = mProductoList.ElementAt(mProductoSelector.SelectedIndex);

            mCantidadSelector.Items.Clear();

            for (int i = 0; i < mProductoActualSeleccionado.Stock; i++)
            {
                mCantidadSelector.Items.Add((i+1)+"");
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
            //Sacas la cantidad de productos que se van a vender segun el producto seleccionado
            int cantidad = mCantidadSelector.SelectedIndex + 1;

            //Añades a esa lista de productos seleecionado el producto
            //Estos son los que envias a dar de alta en la venta
            mProductosSeleccionados.Add(mProductoActualSeleccionado);

            //Este producto venta se va a añadir a una lista de este tipo
            //Sirve para mostrar al usuarios los productos
            ProductoVenta productoVenta = new ProductoVenta();
            productoVenta.Identificador = mProductoActualSeleccionado.Identificador;
            productoVenta.Nombre = mProductoActualSeleccionado.Nombre;
            productoVenta.Precio = mProductoActualSeleccionado.Precio;
            productoVenta.Costo = mProductoActualSeleccionado.Costo;
            productoVenta.Cantidad = cantidad;

            mProductosSeleccionadosVenta.Add(productoVenta);

            //Refrescas el grid view con la informacion :)
            mDetalleVentaGridView.DataSource = null;
            mDetalleVentaGridView.DataSource = mProductosSeleccionadosVenta;

            //Tambien recalculas el Precio y costo que te aparecera en la venta

            float __subtotal = 0;
            float __iva = 0;
            float __total = 0;

            //Iteras cada producto seleccionado y le sumas el precio

            //Tambien lo vas a meteren el objeto de la venta we
            //Limpias lasvariables para evitar pedos
            mCurrentVenta.PrecioBruto = 0;
            mCurrentVenta.CostoBruto = 0;
            foreach (Producto cadaProducto in mProductosSeleccionados)
            {
                __subtotal += cadaProducto.Precio;

                //Objectode laventa
                mCurrentVenta.CostoBruto += cadaProducto.Costo;
                mCurrentVenta.PrecioBruto += cadaProducto.Precio;

            }

            //Multiplicas el IVA definido en la clase constantes
            //Por el subtotal que lleves
            //Por ejemplo 0.15 * 100 te daría 15 pesos
            __iva = Constantes.IVA * __subtotal;

            __total = __iva + __total;

            mSubTotal.Text = String.Format("$ {0:0.00} pesos", __subtotal);
            mIVA.Text = String.Format("$ {0:0.00} pesos", __iva);
            mTotal.Text = String.Format("$ {0:0.00} pesos", __total);

            mTotalAPagar = __total;

        }

        private void mConfirmarPagoAction_Click(object sender, EventArgs e)
        {

                float pago = float.Parse(mPagoCliente.Text);

                if (pago < mTotalAPagar)
                {
                    //Error
                }
                else
                {
                    float cambio = pago - mTotalAPagar;
                    //TODO imprimir pago
                    //Todo imprimir cambio

                    //En parelelo vamos a crear la ventaaquí

                    List<ContenidoVenta> contenidosDeLaVenta = new List<ContenidoVenta>();

                    foreach(ProductoVenta unProductoDeQueSeVaAVender in mProductosSeleccionadosVenta){
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

        
    }
}
