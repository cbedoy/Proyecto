using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelos.decorated
{
    public class ProductoVenta
    {
        public int Identificador {get; set;}
        public String Nombre { get; set; }
        public int Cantidad { get; set; }
        public float Costo { get; set; }
        public float Precio { get; set; }
    }
}
