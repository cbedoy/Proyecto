using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.servicios
{
    class NotificationMessagess
    {
        public void showTitleAndMessage(String title, String message)
        {
            MessageBox.Show(title, message); 
        }
    }
}
