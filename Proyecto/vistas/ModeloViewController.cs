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
    public partial class ModeloViewController : UserControl
    {
        public ModeloController controller;

        public ModeloViewController()
        {
            InitializeComponent();
        }

        private void ModeloViewController_Load(object sender, EventArgs e)
        {

        }
    }
}
