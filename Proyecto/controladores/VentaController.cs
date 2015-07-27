using Proyecto.modelos;
using Proyecto.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.controladores
{
    class VentaController : AbstractController
    {
        public VentaViewController presenter;

        public void agregarUnaNuevaAlHistorial(Venta venta, List<ContenidoVenta> contenidoVenta)
        {

        }

        public List<Venta> obtenerTodasLasVentas()
        {
            return null;
        }
    }
}
