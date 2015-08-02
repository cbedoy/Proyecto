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
        public int Identificador;
        //Fecha de ejecusion
        public DateTime Fecha;
        //Costo
        public float CostoBruto;
        //Precio bruto es decir sin iva
        public float PrecioBruto;
    }
}
