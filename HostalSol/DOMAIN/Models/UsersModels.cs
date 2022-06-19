using DATAACCES.Contracts;
using DOMAIN.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace DOMAIN.Models
{
    public class UsersModels
    {
        private int userid;
        private string loginname;
        private string password;
        private string firstname;
        private string lastname;
        private string position;
        private string email;

        private IUserRepository usersRepository;
        public EntityState State { private get; set; }

        //Propiedades
        public int Userid { get => userid; set => userid = value; }
        public string Loginname { get => loginname; set => loginname = value; }
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Position { get => position; set => position = value; }
        public string Email { get => email; set => email = value; }
    }
}
