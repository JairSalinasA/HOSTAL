using DATAACCES.Contracts;
using DATAACCES.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCES.Respositories
{
    public class UsersRepository:MasterRepository, IUserRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public UsersRepository()
        {
            selectAll = "SELECT * FROM USERS";
            insert = "INSERT INTO USERS VALUES(@loginName,@password,@firstName,@lastName,@position,@email)";
            update = "UPDATE USERS SET LoginName=@loginName,Password=@password,FirstName=@firstName,LastName=@lastName,Position=@position,Email=@email";
            delete = "DELETE FROM USERS WHERE UserID=@userID";
    }

        public int Add(Users entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@loginName", entity.loginname));
            parameters.Add(new SqlParameter("@password", entity.password));
            parameters.Add(new SqlParameter("@firstName", entity.firstname));
            parameters.Add(new SqlParameter("@lastname", entity.lastname));
            parameters.Add(new SqlParameter("@position", entity.position));
            parameters.Add(new SqlParameter("@email", entity.email));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Users entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@loginName", entity.loginname));
            parameters.Add(new SqlParameter("@password", entity.password));
            parameters.Add(new SqlParameter("@firstName", entity.firstname));
            parameters.Add(new SqlParameter("@lastname", entity.lastname));
            parameters.Add(new SqlParameter("@position", entity.position));
            parameters.Add(new SqlParameter("@email", entity.email));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Users> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listUsers = new List<Users>();
            foreach (DataRow item in tableResult.Rows)
            {
                listUsers.Add(new Users
                {
                    userid = Convert.ToInt32(item[0]),
                    loginname = item[1].ToString(),
                    password = item[2].ToString(),
                    firstname = item[3].ToString(),
                    lastname = item[4].ToString(),
                    position = item[5].ToString(),
                    email = item[6].ToString(),
                });
            }
            return listUsers;
        }
          
        public int Remove(int userID)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@userID",userID));
            return ExecuteNonQuery(delete);
        }
    }
}
