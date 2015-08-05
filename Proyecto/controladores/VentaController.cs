using MySql.Data.MySqlClient;
using Proyecto.modelos;
using Proyecto.servicios;
using Proyecto.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.controladores
{
    public class VentaController : AbstractController
    {
        public VentaViewController mPresenter;

        public void setPresenter(VentaViewController presenter)
        {
            mPresenter = presenter;
        }

        public void agregarUnaNuevaAlHistorial(Venta venta, List<ContenidoVenta> contenidoVenta)
        {
            //Primero tienes que crear una venta para 
            crearUnaVenta(venta);
            //Despues crear el contenido delticket
            //Este necesita tener como referencia un id de venta we
            venta = obtenerLaUltimaVenta();

            anadirLosContenidosDelTicket(venta, contenidoVenta);
        }

        private void anadirLosContenidosDelTicket(Venta venta, List<ContenidoVenta> contenidoVenta)
        {
            //Iteras la lista de productos para agregarlos
            foreach (ContenidoVenta contenidoDelTicket in contenidoVenta)
            {

                String sql = "insert into ContenidoVenta values(@id, @idVenta, @idProducto, @Cantidad, @Precio, @Costo);";

                MySqlCommand command = new MySqlCommand(sql);

                command.Parameters.Add("@id", null);
                command.Parameters.Add("@idVenta", venta.Identificador);
                command.Parameters.Add("@idProducto", contenidoDelTicket.idProducto);
                command.Parameters.Add("@Cantidad", contenidoDelTicket.cantidad);
                command.Parameters.Add("@Precio", contenidoDelTicket.precioUnitario);
                command.Parameters.Add("@Costo", contenidoDelTicket.costoUnitario);

                mSQLService.performNoQueryWithSQLComandAndNotification(command);

            }
        }

        public List<Venta> obtenerTodasLasVentas()
        {
            String sql = "select * from Venta;";

            MySqlCommand command = new MySqlCommand(sql);

            MySqlDataReader reader = mSQLService.performQueryWithSQLComand(command);

            List<Venta> ventas = new List<Venta>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    Venta venta = new Venta();
                    venta.Identificador = reader.GetInt32(0);
                    venta.Fecha = reader.GetDateTime(1);
                    venta.CostoBruto = reader.GetFloat(2);
                    venta.PrecioBruto = reader.GetFloat(3);
                    ventas.Add(venta);
                }
            }

            return ventas;
        }

        public List<Venta> obtenerCorteDelDia()
        {
            DateTime today = DateTime.Today;

            String fechaABuscar = String.Format("{0:yyyy-MM-dd}", today);

            String sql = "select * from Venta WHERE Fecha =  '"+fechaABuscar+"';";

            
            //String sql = "select * from Venta where Fecha = '2015-08-01';";

            MySqlCommand command = new MySqlCommand(sql);

            MySqlDataReader reader = mSQLService.performQueryWithSQLComand(command);

            List<Venta> ventas = new List<Venta>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    Venta venta = new Venta();
                    venta.Identificador = reader.GetInt32(0);
                    venta.Fecha = reader.GetDateTime(1);
                    venta.CostoBruto = reader.GetFloat(2);
                    venta.PrecioBruto = reader.GetFloat(3);
                    venta.GananciaBruta = venta.PrecioBruto * (Constantes.IVA + 1) - venta.CostoBruto;

                    venta.Costo = String.Format("$ {0:0.00} pesos", venta.CostoBruto);
                    venta.Precio = String.Format("$ {0:0.00} pesos", venta.PrecioBruto);
                    venta.PrecioMasIVA = String.Format("$ {0:0.00} pesos", venta.PrecioBruto * (Constantes.IVA + 1));
                    venta.Ganancia = String.Format("$ {0:0.00} pesos", venta.GananciaBruta);


                    ventas.Add(venta);
                }
            }

            return ventas;

        }


        public List<Venta> obtenerCorteDelMensual()
        {
            DateTime today = DateTime.Today;

            DateTime desdeFecha = new DateTime(today.Year, today.Month, 1);

            DateTime hasterFecha = new DateTime(today.Year, today.Month + 1, 1);

            String fechaABuscarDesde = String.Format("{0:yyyy-MM-dd}", desdeFecha);

            String fechaABuscarHasta = String.Format("{0:yyyy-MM-dd}", hasterFecha);

            String sql = "select * from Venta WHERE Fecha >=  '" + fechaABuscarDesde + "' AND '" + fechaABuscarHasta + "';";

            MySqlCommand command = new MySqlCommand(sql);

            MySqlDataReader reader = mSQLService.performQueryWithSQLComand(command);

            List<Venta> ventas = new List<Venta>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    Venta venta = new Venta();
                    venta.Identificador = reader.GetInt32(0);
                    venta.Fecha = reader.GetDateTime(1);
                    venta.CostoBruto = reader.GetFloat(2);
                    venta.PrecioBruto = reader.GetFloat(3);

                    venta.GananciaBruta = venta.PrecioBruto * (Constantes.IVA + 1) - venta.CostoBruto;

                    venta.Costo = String.Format("$ {0:0.00} pesos", venta.CostoBruto);
                    venta.Precio = String.Format("$ {0:0.00} pesos", venta.PrecioBruto);
                    venta.PrecioMasIVA = String.Format("$ {0:0.00} pesos", venta.PrecioBruto * (Constantes.IVA + 1));
                    venta.Ganancia = String.Format("$ {0:0.00} pesos", venta.GananciaBruta);

                    ventas.Add(venta);
                }
            }

            return ventas;

        }

        private void crearUnaVenta(Venta venta)
        {
            String sql = "insert into Venta values(@id, @Fecha, @Costo, @Precio);";

            MySqlCommand command = new MySqlCommand(sql);

            command.Parameters.Add("@id", null);
            command.Parameters.Add("@Fecha", venta.Fecha);
            command.Parameters.Add("@Costo", venta.CostoBruto);
            command.Parameters.Add("@Precio", venta.PrecioBruto);

            mSQLService.performNoQueryWithSQLComandAndNotification(command);
        }

        private Venta obtenerLaUltimaVenta()
        {
            String sql = "select * from Venta order by idVenta DESC limit 1;";

            MySqlCommand command = new MySqlCommand(sql);

            MySqlDataReader reader = mSQLService.performQueryWithSQLComand(command);

            Venta venta = new Venta();

            if (reader != null)
            {
                while (reader.Read())
                {
                    venta.Identificador = reader.GetInt32(0);
                    venta.Fecha = reader.GetDateTime(1);
                    venta.CostoBruto = reader.GetFloat(2);
                    venta.PrecioBruto = reader.GetFloat(3);
                }
            }

            return venta;
        }
    }
}
