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

            control.Left = (mFormContainer.Width - control.Width) / 2;
            control.Top = (mFormContainer.Height - control.Height) / 2;

            mFormContainer.Controls.Add(control);
        }

        public void init()
        {
            presentViewController(mLoginViewController);
        }

        public void usuarioAutentificado()
        {
            mFormContainer.Controls.Clear();
        }
    }
}
