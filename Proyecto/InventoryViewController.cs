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

namespace Proyecto
{
    public partial class InventoryViewController : UserControl
    {
        private ProductoController controller;

        public InventoryViewController()
        {
            InitializeComponent();
        }

        private void InventoryViewController_Load(object sender, EventArgs e)
        {
            mGridInventory = controller.obtenerListaDeProductos();
        }
    }
}
