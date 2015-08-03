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

namespace Proyecto.vistas
{
    public partial class CorteMensualViewController : UserControl, IViewController
    {
        private VentaController mBusinessController;

        public void setBusinessController(VentaController controller)
        {
            mBusinessController = controller;
        }

        public CorteMensualViewController()
        {
            InitializeComponent();
        }

        private void CorteMensualViewController_Load(object sender, EventArgs e)
        {

        }

        public void onReloadData()
        {

        }
    }
}
