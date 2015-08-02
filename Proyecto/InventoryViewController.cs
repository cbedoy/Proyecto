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

namespace Proyecto
{
    public partial class InventoryViewController : UserControl
    {
        private ProductoController mController;

        public InventoryViewController()
        {
            InitializeComponent();
        }

        private void InventoryViewController_Load(object sender, EventArgs e)
        {
            List<Producto> productoList = mController.obtenerListaDeProductos();

            
        }
    }
}
