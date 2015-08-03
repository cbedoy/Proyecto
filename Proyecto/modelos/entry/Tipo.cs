using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelos
{
    public class Tipo
    {
        //Identificador autoincremental
        public int Identificador { get; set; }
        //Nombre del tipo de producto, osea sirve para identificar si es un huarache, bolsa bla bla bla
        public String Nombre { get; set; }
        //
        public String Descripcion { get; set; }
    }
}
