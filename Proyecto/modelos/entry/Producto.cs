using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelos
{
    class Producto
    {
        //Identificador automatico
        public int Identificador;
        //Nombre del producto
        public String Nombre;
        //Cantidad de productos de este disponibles 
        public int Stock;
        //Costo del producto (lo que te cuesta.... a ti como empresa)
        public float Costo;
        //Precio previo del producto //En otra parte decoro para obtener el precio + IVA 
        //Este se crea en tiempo de ejecusion no tiene caso guardarlo en la DDB
        public float Precio;
        //Tipo al que esta asociado osea no recuerdo bien que pedo
        //Pero podia ser Huarache, Bolsa bla bla
        public int idTipo;
        //Aqui es donde seleccionar el modelo --> tambien te dice la talla
        public int idModelo;
    }
}
