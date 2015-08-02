using Proyecto.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.controladores
{
    public class AbstractController
    {
        protected MySQLContection mSQLService;

        public void setSQLService(MySQLContection service)
        {
            mSQLService = service;
        }
    }
}
