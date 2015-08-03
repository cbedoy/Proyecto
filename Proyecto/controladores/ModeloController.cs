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
    public class ModeloController : AbstractController
    {
        private ModeloViewController mPresenter;

        public void setPresenter(ModeloViewController presenter)
        {
            mPresenter = presenter;
        }

        public List<Modelo> obtenerTodosLosModelosDisponibles()
        {
            List<Modelo> modelos = new List<Modelo>();

            String sql = "select * from Modelo;";

            MySqlCommand command = new MySqlCommand(sql);

            MySqlDataReader reader = mSQLService.performQueryWithSQLComand(command);

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
            String sql = "insert into Modelo values(@id, @Nombre);";

            MySqlCommand command = new MySqlCommand(sql);

            command.Parameters.Add("@id", null);

            command.Parameters.Add("@Nombre", modelo.Talla);

            mSQLService.performNoQueryWithSQLComandAndNotification(command);
        }

        public void modificarUnModelo(Modelo modelo)
        {
            String sql = "update Modelo set Talla = @Talla where idModelo = @id;";

            MySqlCommand command = new MySqlCommand(sql);

            command.Parameters.Add("@id", modelo.Identificador);

            command.Parameters.Add("@Talla", modelo.Talla);

            mSQLService.performNoQueryWithSQLComandAndNotification(command);
        }

    }
}
