using MySql.Data.MySqlClient;
using Proyecto.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.controladores
{
    class TipoController : AbstractController
    {
        public List<Tipo> obtenerTodosLosTiposDisponibles(){
            List<Tipo> tipos = new List<Tipo>();

            String sql = "select * from Tipo;";

            MySqlCommand command = new MySqlCommand(sql);

            MySqlDataReader reader = sqlService.performQueryWithSQLComand(command);

            if (reader != null)
            {
                while (reader.Read())
                {
                    Tipo tipo = new Tipo();
                    tipo.Identificador = reader.GetInt32(0);
                    tipo.Nombre = reader.GetString(1);
                    tipos.Add(tipo);
                }
            }

            return tipos;
        }

        public void agregarUnNuevoTipo(Tipo tipo)
        {
            String sql = "insert into Tipo values(@id, @Nombre);";

            MySqlCommand command = new MySqlCommand(sql);

            command.Parameters.Add("@id", null);

            command.Parameters.Add("@Nombre", tipo.Nombre);

            sqlService.performNoQueryWithSQLComandAndNotification(command);
        }

        public void modifcarUnTipo(Tipo tipo)
        {
            String sql = "update Tipo set idTipo = @id, Nombre = @Nombre;";

            MySqlCommand command = new MySqlCommand(sql);

            command.Parameters.Add("@id", tipo.Nombre);

            command.Parameters.Add("@Nombre", tipo.Nombre);

            sqlService.performNoQueryWithSQLComandAndNotification(command);
        }
    }
}
