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
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
            CenterToParent();
        }
        
        private void Menuprincipal_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas fr2 = new Ventas();
            fr2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario fr3 = new Inventario();
            fr3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reporte_ventas fr3 = new Reporte_ventas();
            fr3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Corte_caja fr4 = new Corte_caja();
            fr4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             Reporte_ganancias fr5 = new Reporte_ganancias();
            fr5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void corteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
    }
}
