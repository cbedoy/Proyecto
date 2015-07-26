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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToParent();
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolT1 = new ToolTip();
            toolTip1.AutoPopDelay = 3000;
            toolTip1.InitialDelay = 200;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button2, " Presione INGRESAR PARA ENTRAR AL SISTEMA.");
            toolTip1.SetToolTip(this.textBox3, "Ingrese USUARIO.");
            toolTip1.SetToolTip(this.textBox4, " Ingrese CONTRASEÑA."); this.BackgroundImage = Properties.Resources.icon_128;

         
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            String u = textBox3.Text;
            String c = textBox4.Text;
            if (u=="admin" && c=="admin")
                {
                Menuprincipal fr2 = new Menuprincipal();
                fr2.Show();
                textBox3.Clear();
                textBox4.Clear();

            }
            else
            {
                MessageBox.Show("Nombre ó Contraseña incorrecto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox3.Clear();
                textBox4.Clear();
                return;
            }
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}



       

