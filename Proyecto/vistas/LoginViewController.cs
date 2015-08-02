using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.servicios;

namespace Proyecto.vistas
{
    public partial class LoginViewController : UserControl
    {
        private MasterViewController mMasterViewController;

        public void setMasterViewController(MasterViewController masterController)
        {
            mMasterViewController = masterController;
        }

        public LoginViewController()
        {
            InitializeComponent();
        }

        private void LoginViewController_Load(object sender, EventArgs e)
        {
            mUsername.Text = Constantes.USERNAME;

            mPassword.Text = Constantes.PASSOWORD;
        }

        private void mLogin_Click(object sender, EventArgs e)
        {
            if (mLogin.Text == Constantes.USERNAME && mPassword.Text == Constantes.USERNAME)
            {
                mMasterViewController.usuarioAutentificado();
            }
        }
    }
}
