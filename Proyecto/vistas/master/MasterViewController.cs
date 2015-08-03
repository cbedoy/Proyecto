using Proyecto.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.vistas
{
    public partial class MasterViewController : Form
    {

        private MasterController masterController;

        private ModeloViewController mModeloViewController;
        private ProductoViewController mProductoViewController;
        private TipoViewController mTipoViewController;
        private VentaViewController mVentaViewController;
        private LoginViewController mLoginViewController;
        private InventoryViewController mInventoryViewController;
        private CorteDiaViewController mCorteDiaViewController;
        private CorteMensualViewController mCorteMesViewController;

        public void setViewController(InventoryViewController controller)
        {
            mInventoryViewController = controller;
        }

        public void setViewController(ModeloViewController viewController)
        {
            mModeloViewController = viewController;
        }

        public void setViewController(ProductoViewController viewController)
        {
            mProductoViewController = viewController;
        }

        public void setViewController(TipoViewController viewController)
        {
            mTipoViewController = viewController;
        }

        public void setViewController(VentaViewController viewController)
        {
            mVentaViewController = viewController;
        }

        public void setViewController(LoginViewController viewController)
        {
            mLoginViewController = viewController;
        }

        public MasterViewController()
        {
            InitializeComponent();
        }

        private void MasterViewController_Load(object sender, EventArgs e)
        {
            masterController = new MasterController(this);
        }

        public void presentViewController(Control control)
        {
            mFormContainer.Controls.Clear();

            //Pequeña operacion para centrar el formulario we
            control.Left = (mFormContainer.Width - control.Width) / 2;
            control.Top = (mFormContainer.Height - control.Height) / 2;

            //Este es para checar que view controller vas a presentar
            //Si ese view controller implementa la interfaz
            //IViewController entonces haces un poliformismo
            //De esa clase en tiempo de ejecusion para que mande
            //A llamar ese metodo oculto y recargar la informacion
            //Cada vez que seleeciones la vista, y evitar que se
            //Muestre N veces y multiples instancias
            //Que puede hacer que te chinge el proyecto :D
            if (control is IViewController)
            {
                IViewController viewControl = (IViewController)control;

                viewControl.onReloadData();
            }

            mFormContainer.Controls.Add(control);
        }

        public void init()
        {
            presentViewController(mLoginViewController);

            mTallaAction.Enabled = false;
            mModeloAction.Enabled = false;
            mVenderAction.Enabled = false;
            mProductoAction.Enabled = false;
            mInventarioAction.Enabled = false;
            mCorteDelDiaAction.Enabled = false;
            mCorteDelMesAction.Enabled = false;
            mSalirAction.Enabled = true;
        }

        public void usuarioAutentificado()
        {
            mFormContainer.Controls.Clear();

            mTallaAction.Enabled = true;
            mModeloAction.Enabled = true;
            mVenderAction.Enabled = true;
            mProductoAction.Enabled = true;
            mInventarioAction.Enabled = true;
            mCorteDelDiaAction.Enabled = true;
            mCorteDelMesAction.Enabled = true;
            mSalirAction.Enabled = true;
        }

        private void mTallaAction_Click(object sender, EventArgs e)
        {
            presentViewController(mModeloViewController);
        }

        private void mModeloAction_Click(object sender, EventArgs e)
        {
            presentViewController(mTipoViewController);
        }

        private void mProductoAction_Click(object sender, EventArgs e)
        {
            presentViewController(mProductoViewController);
        }

        private void mVenderAction_Click(object sender, EventArgs e)
        {
            presentViewController(mVentaViewController);
        }

        private void mInventarioAction_Click(object sender, EventArgs e)
        {
            presentViewController(mInventoryViewController);
        }

        private void mCorteDelDiaAction_Click(object sender, EventArgs e)
        {
            presentViewController(mCorteDiaViewController);
        }

        public void setViewController(CorteDiaViewController viewController)
        {
            mCorteDiaViewController = viewController;
        }

        public void setViewController(CorteMensualViewController viewController)
        {
            mCorteMesViewController = viewController;
        }

        private void mCorteDelMesAction_Click(object sender, EventArgs e)
        {
            presentViewController(mCorteMesViewController);
        }
    }
}
