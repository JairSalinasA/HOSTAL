using DATAACCES.Contracts;
using DATAACCES.Entities;
using DATAACCES.Respositories;
using DOMAIN.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Se requiere nombre de usuario")]
        [StringLength(16, ErrorMessage = "Debe tener entre 3 y 16 caracteres", MinimumLength = 3)]
        public string Loginname { get => loginname; set => loginname = value; }
        [Required(ErrorMessage = "Se requiere contraseña")]
        [StringLength(255, ErrorMessage = "Debe tener entre 5 y 255 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)] 
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Position { get => position; set => position = value; }
        [Required(ErrorMessage = "Correo electronico es requerido")]
        [StringLength(16, ErrorMessage = "Debe tener entre 5 y 50 caracteres", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Email { get => email; set => email = value; }


        public UsersModels()
        {
            usersRepository = new UsersRepository();
        }

        public string StateChanges()
        {
            string message=null;
            try
            {
                var userDataModel = new Users();
                userDataModel.userid = userid;
                userDataModel.loginname = loginname;
                userDataModel.password = password;
                userDataModel.firstname = firstname;
                userDataModel.lastname = lastname;
                userDataModel.position = position;
                userDataModel.email = email;

                switch (State)
                {
                    case EntityState.Added:
                        usersRepository.Add(userDataModel);
                        message = "El Usuario se agregó correctamente";
                        break;
                    case EntityState.Deleted:
                        usersRepository.Add(userDataModel);
                        message = "El Usuario se eliminó correctamente";
                        break;
                    case EntityState.Modified:
                        usersRepository.Add(userDataModel);
                        message = "El Usuario se modificó correctamente";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx!=null && sqlEx.Number==2627)
                {
                    message = "El registro esta duplicado";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }

        public List<UsersModels> GetAll()
        {
            var usersDataModel = usersRepository.GetAll();
            var listUsers = new List<UsersModels>();
            foreach (Users item in usersDataModel)
            {
                listUsers.Add(new UsersModels
                {


                });
            }
        }
    }
}
