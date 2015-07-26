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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            CenterToParent(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void Inventario_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           Nuevo_articulo fr2 = new Nuevo_articulo();
            fr2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nueva_mercancia fr2 = new Nueva_mercancia();
            fr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modificar_mercancia fr2 = new Modificar_mercancia();
            fr2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          Eliminar_mercancia fr2 = new Eliminar_mercancia();
            fr2.Show();
        }
    }
}
