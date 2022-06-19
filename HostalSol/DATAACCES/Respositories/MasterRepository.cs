using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCES.Respositories
{
    public abstract class MasterRepository : Repository
    {
        protected List<SqlParameter> parameters;

        //este metodo se encarga de ejecutar comando de no con sulta es decir
        //Comando para crear, editar, eliminar datos
        protected int ExecuteNonQuery(string transactSql)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;

                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    int result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }
        //este metodo se encarga de hacer consultas
        // es decir leer filas de datos en las tablas
        protected DataTable ExecuteReader(string transactSql)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader ();
                    using(var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }
    }
}
