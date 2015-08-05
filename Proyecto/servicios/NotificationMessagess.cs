using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.servicios
{
    public class NotificationMessagess
    {
        public void showTitleAndMessage(String title, String message)
        {
            MessageBox.Show(
                message, 
                title == "Error" ? "Oops!!" : "Bien Hecho!!", 
                MessageBoxButtons.OK, 
                title == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.None);
        }
    }
}
