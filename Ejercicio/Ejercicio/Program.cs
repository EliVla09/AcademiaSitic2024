using System;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string courseNaame = "Academia SITIC";
            string courseNaame2 = "Academia SITIC 2";

            int studentCount = 28;

            bool isStartingNow = true;
            int? age = null;

            //1
            Console.WriteLine(age != null ? age :  0);

            if (age != null)

                Console.WriteLine(age);
            else
                Console.WriteLine(0);

            Console.WriteLine(age.GetValueOrDefault(0));
            Console.ReadKey();

         

        }
        public class User
        {
            //private string _name;
            ////forma corta
            //public int IdUser { get; set; }

            ////forma media
            //private string _password;
            //public string Password
            //{
            //    get
            //    {
            //        return _password;
            //    }

            //    set
            //    {
            //        _password = value;
            //    }
            //}

            ////Forma larga
            //public string GetName()
            //{
            //    return _name;
            //}

            //public void SetName(string name)
            //{
            //    _name = name;
            //}

            private int _iduser;
            private string _name;
            private string _password;
            
            public string Password { get => _password; set => _password = value;}
        }

        public class Person
        {
            public int _PersonId { get; set; }
            public string Name { get; set; }
        }
    }
}
