using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelos
{
    public class Venta
    {
        //Autoincremental
        public int Identificador {get; set;}
        //Fecha de ejecusion
        public DateTime Fecha {get; set;}
        //Costo
        public float CostoBruto;
        //Precio bruto es decir sin iva
        public float PrecioBruto;

        public float GananciaBruta;

        public String Costo { get; set; }
        public String Precio { get; set; }
        public String PrecioMasIVA {get; set;}
        public String Ganancia { get; set; }
    }
}
