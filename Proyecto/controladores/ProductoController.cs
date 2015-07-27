using MySql.Data.MySqlClient;
using Proyecto.modelos;
using Proyecto.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.controladores
{
    class ProductoController : AbstractController
    {
        public ProductoViewController presenter;

        public void agregarProducto(Producto producto, Tipo tipo, Modelo modelo)
        {
            String sql = "insert into Producto values(@id, @Nombre, @Stock, @Costo, @Precio, @Tipo, @Modelo);";

            MySqlCommand command = new MySqlCommand(sql);

            command.Parameters.Add("@id", null);
            command.Parameters.Add("@Nombre", producto.Nombre);
            command.Parameters.Add("@Stock", producto.Stock);
            command.Parameters.Add("@Costo", producto.Costo);
            command.Parameters.Add("@Precio", producto.Precio);
            command.Parameters.Add("@Tipo", tipo.Identificador);
            command.Parameters.Add("@Modelo", modelo.Identificador);

            sqlService.performNoQueryWithSQLComandAndNotification(command);
        }

        public void modificarProducto(Producto producto)
        {
            String sql = "update Producto set Nombre = @Nombre, Stock = @Stock, Costo = @Costo, Precio = @Precio";

            MySqlCommand command = new MySqlCommand(sql);
            command.Parameters.Add("@Nombre", producto.Nombre);
            command.Parameters.Add("@Stock", producto.Stock);
            command.Parameters.Add("@Costo", producto.Costo);
            command.Parameters.Add("@Precio", producto.Precio);

            sqlService.performNoQueryWithSQLComandAndNotification(command);

        }

        public List<Producto> obtenerListaDeProductos()
        {
            List<Producto> productos = new List<Producto>();

            String sql = "select * from Producto;";

            MySqlCommand command = new MySqlCommand(sql);

            MySqlDataReader reader = sqlService.performQueryWithSQLComand(command);

            if (reader != null)
            {
                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.Identificador = reader.GetInt32(0);
                    producto.Nombre = reader.GetString(1);
                    producto.Stock = reader.GetInt32(2);
                    producto.Costo = reader.GetFloat(3);
                    producto.Precio = reader.GetFloat(4);
                    producto.idTipo = reader.GetInt32(5);
                    producto.idModelo = reader.GetInt32(6);

                    productos.Add(producto);
                }
            }


            return productos;
        }

    }
}
