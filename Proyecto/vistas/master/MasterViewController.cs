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

        }
    }
}
