using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Corte_caja : Form
    {
        public Corte_caja()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Corte_caja_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.icon_128;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
