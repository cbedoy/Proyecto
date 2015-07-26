using MySql.Data.MySqlClient;
using Proyecto.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.controladores
{
    class ModeloController : AbstractController
    {
        public List<Modelo> obtenerTodosLosModelosDisponibles()
        {
            List<Modelo> modelos = new List<Modelo>();

            String sql = "select * from Modelo;";

            MySqlCommand command = new MySqlCommand(sql);

            MySqlDataReader reader = sqlService.performQueryWithSQLComand(command);

            if (reader != null)
            {
                while (reader.Read())
                {
                    Modelo modelo = new Modelo();
                    modelo.Identificador = reader.GetInt32(0);
                    modelo.Talla = reader.GetString(1);
                    modelos.Add(modelo);
                }
            }


            return modelos;
        }

        public void agregarUnNuevoModelo(Modelo modelo)
        {

        }
    }
}
