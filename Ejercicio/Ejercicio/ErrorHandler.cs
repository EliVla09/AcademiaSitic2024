using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class ErrorHandler
    {
        #region Properties
        private static List<User> UserList { get; set; } = GetUsers();
        #endregion

        #region Variables
        private const int MIN_AGE = 10;
        private const int MAX_AGE = 100;
        #endregion

        #region classes
        public class User
        {
            #region Properties
            public int UserId { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            #endregion

            #region Constructors
            public User() { }
            public User(int userId, string userName, string password)
            {
                UserId = userId;
                Username = userName;
                Password = password;
            }
            public User(string userName, string password)
            {
                Username = userName;
                Password = password;
            }
            #endregion
        }
        #endregion

        private static List<User> GetUsers()
        {
            return new()
            {
                new (1, "admin", "admin"),
                new(2,  "sa", "12345"),
                new(3, "john doe", "123"),
                new(4, "admin", "admin"),
            };

        }
        public static void Main(string[] args)
        {
            const string UserName = "Eli22";
            const string Password = "admin";

            Console.ReadKey();
        }

        public static int RegisterUserWithoutValidations(string username, string password, string ageInput)
        {
            int userId;
            Console.WriteLine("Conexión a la base de datos");
            Console.WriteLine("Abrimos Transacción");

            age = Convert.ToInt32(ageInpt);
            Console.WriteLine("Ejecutamos acciones en la base de datos");

            if (!IsExistingUser(username)) { 
            InsertUser(new(username, password));
            }

            return userId;
        }

        public static bool IsExistingUser(string username)
        {
            return (UserList?.Any(user => user.Username == username)).GetValueOrDefault();
        }
        
        public static bool InsertUser(User user)
        {
            user.UserId = UserList != null ?(UserList.Max(user => user.UserId)+1 : 1;
            if (UserList != null) { 
            UserList.Add(user);
            }
            //else
            //{
            //    UserList = new();
            //    UserList.Add(user);
            //}
            UserList.Add(user);
            Console.WriteLine("Accion ejecutada en base de datos => usuario insertao");
            return true;
        }
    }
}
