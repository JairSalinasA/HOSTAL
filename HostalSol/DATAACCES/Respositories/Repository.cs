using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCES.Respositories
{
    public abstract class Repository
    {
        //Este Campo se susa para guardar la cadena de conexion
        //Solo puede ser usado por la misma clase
        private readonly string connectionString;
        
        //Constructor 
        public Repository()
        {
            //cadena de conecxion del administrador
            connectionString = ConfigurationManager.ConnectionStrings["ConnHostel"].ToString();
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
