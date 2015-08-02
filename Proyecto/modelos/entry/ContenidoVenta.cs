using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelos
{
    public class ContenidoVenta
    {
        //Identificador autoincremental
        public int Identificador;
        //Necesitamos saber que vendimos no?
        public int idProducto;
        //Tambien a que venta pertenece, de aquí nace la magia
        public int idVenta;

        public int cantidad;

        public float precioUnitario;

        public float costoUnitario;
    }
}
