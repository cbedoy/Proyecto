using Proyecto.servicios;
using Proyecto.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.controladores
{
    class MasterController
    {
        private MasterViewController mViewController;

        private ModeloViewController mModeloViewController;

        private ProductoViewController mProductoViewController;

        private TipoViewController mTipoViewController;

        private VentaViewController mVentaViewController;

        public MasterController(MasterViewController viewController)
        {
            NotificationMessagess notificationMessages = new NotificationMessagess();
            MySQLContection SQLService = new MySQLContection();
            SQLService.setNotificationMessages(notificationMessages);
            mViewController = viewController;

            ModeloController modeloController = new ModeloController();
            mModeloViewController = new ModeloViewController();
            modeloController.sqlService = SQLService;
            modeloController.presenter = mModeloViewController;
            mModeloViewController.controller = modeloController;

            ProductoController productoController = new ProductoController();
            mProductoViewController = new ProductoViewController();
            productoController.sqlService = SQLService;
            productoController.presenter = mProductoViewController;
            mProductoViewController.controller = productoController;

            TipoController tipoController = new TipoController();
            mTipoViewController = new TipoViewController();
            tipoController.sqlService = SQLService;
            tipoController.presenter = mTipoViewController;
            mTipoViewController.controller = tipoController;

            VentaController ventaController = new VentaController();
            ventaController.sqlService = SQLService;     
        }
    }
}
