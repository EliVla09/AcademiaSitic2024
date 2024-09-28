using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class ListLINQ
    {
        class Program
        {
            //Listas con LinQ

            public class People
            {
                #region Properties
                public string Name { get; set; }
                public int Age { get; set; }
                public eGender Gender { get; set; }
                #endregion

                #region Constructors

                public People() { }

                public People(string name, int age, eGender gender)
                {
                    Name = name;
                    Age = age;
                    Gender = gender;
                }
                #endregion

                #region Methods

                public override string ToString()
                {
                    return $"Nombre: {Name}, Edad: {Age}, Género: {this.GetStringGender(Gender)}";
                }

                #region genderIf

                private string GetStringGender(eGender gender)
                {
                    string genderString;
                    //if (gender == eGender.Undefined)
                    //{
                    //    genderString = "Indefinido";
                    //}

                    //else if (gender == eGender.Female)
                    //{
                    //    genderString = "Femenino";
                    //}
                    //else if (gender == eGender.Male)
                    //{
                    //    genderString = "Masculino";
                    //}



                    #endregion

                    #region switchCase

                    //switch (gender)
                    //{
                    //    case eGender.Undefined:
                    //      genderString = "Indefinidio";
                    //      break;
                    //    case eGender.Female:
                    //      genderString = "Femenino";
                    //      break;
                    //    case eGender.Male:
                    //      genderString = "Masculino";
                    //      break;
                    //} 

                    #endregion

                    #region switchLambda

                    genderString = gender switch
                    {
                        eGender.Undefined => "Indefinido",
                        eGender.Female => "Femenino",
                        eGender.Male => "Masculino",
                        _ => "No válido"
                    };
                    return genderString;
                }
            #endregion

        
            #endregion



            #region Enums

            public enum eGender
                {
                    Undefined = 0,
                    Female = 1,
                    Male = 2,
                }

                #endregion

                static void Main(string[] args)
                {
                    List<People> employeers = new()
                {
                    new People
                    {
                        Name = "María",
                        Age= 18,
                        Gender = eGender.Female
                    },
                    new People
                    {
                        Name = "Eli",
                        Age= 23,
                        Gender = eGender.Female
                    },

                };

                    if (employeers != null)
                    {
                        employeers.Add(new("Ricardo", 34, eGender.Male));
                        employeers.Add(new("María", 12, eGender.Female));
                        employeers.Add(new("Sebastian", 24, eGender.Male));
                        employeers.Add(new("Iris", 23, eGender.Female));
                        employeers.Add(new("Oscar", 27, eGender.Male));
                        employeers.Add(new("Antonio", 27, eGender.Male));
                    }

                    List<People> students = new()
                {
                    new("Iris", 23, eGender.Female),
                    new("Jesús", 26, eGender.Male),
                    new("Maye", 29, eGender.Female),
                    new("Eli", 23, eGender.Female),
                    new("Fabio", 32, eGender.Male),
                    new("Antonio", 22, eGender.Male),
                };

                    #region WHERE
                    Console.WriteLine("\nWHERE - Filtrar los nombres que comiencen con la letra 'A'");
                    List<People> filteredEmployeers = employeers.Where(employeer => employeer.Name.StartsWith("A")).ToList();

                    //foreach (People filteredEmployeer in filteredEmployeers)
                    //{
                    //    Console.WriteLine(filteredEmployeer.Name);
                    //}

                    Console.WriteLine("\nWHERE - Filtrar empleados mayores a 30 años");
                    filteredEmployeers = employeers.Where(employeer => employeer.Age > 30).ToList();

                    foreach (People filteredEmployeer in filteredEmployeers)
                    {
                        Console.WriteLine(filteredEmployeer.ToString());
                    }

                    foreach (People employeer in employeers)
                    {
                        Console.WriteLine($"Nombre: {employeer.Name}");

                    }
                    #endregion

                    #region select
                    Console.WriteLine("\nWHERE - Tomar el nombre (sirve para seleccionar una propiedad en especifico).");
                    List<string> filteredEmployeersNames = employeers.Select(employeers => employeers.Name).ToList();
                    foreach (string name in filteredEmployeersNames)
                    {
                        Console.WriteLine(name);
                    }
                    #endregion

                    #region OrderBy & OrderByDescending
                    Console.WriteLine("\nOrderBy - Ordenamiento por nombre vs la diferencia de la lista original.");
                    List<People> filteredStudentsByName = students.OrderBy(student => student.Name).ToList();
                    int i = 0;
                    People originalStudent = null;

                    foreach (var filteredStudent in filteredStudentsByName)
                    {
                        originalStudent = students[i];
                        Console.WriteLine($"{filteredStudent.Name} - {originalStudent.Name}");
                        i++;
                    }

                    // Ordenar por edad
                    Console.WriteLine("\nOrderByDescending - Ordenar por edad y compararlo con la lista original.");
                    List<People> filteredStudentsByAge = students.OrderByDescending(student => student.Age).ToList();
                    i = 0; // Reiniciar el contador

                    foreach (var filteredStudent in filteredStudentsByAge)
                    {
                        originalStudent = students[i];
                        Console.WriteLine($"{filteredStudent.Name} - {originalStudent.Name}");
                        i++;
                    }
                    #endregion

                    #region GroupBy
                    Console.WriteLine("\nGroupBy - Agrupamiento por género");
                    var groupedByGneder = students.GroupBy(student => student.Gender);
                    foreach(var group in groupedByGneder)
                    {
                        Console.WriteLine($"Género (grupo): {group.Key}");
                        foreach (var person in group)
                        {
                            Console.WriteLine($"{person.Name}");
                        }
                    }

                    Console.WriteLine("\nGroupBy - Agrupamiento por Edades y total de personas con esa edad");
                    var groupedByAge = employeers.GroupBy(employeer => employeer.Age);
                    int contador = 0;
                    foreach (var group in groupedByAge)
                    {
                        Console.WriteLine($"Edades (grupo): {group.Key}");
                        foreach (var person in group)
                        {
                            Console.WriteLine($"{person.Name}, {person.Age}");
                        }
                    }
                    #endregion

                    #region Any
                    Console.WriteLine("\nAny Verifica si hay valores o no dentro de la lista");
                    Console.WriteLine($"Existen Valores en employeers: {employeers.Any()}");
                    Console.WriteLine($"Existen empleados mayores de 30: {employeers.Any(i=> i.Age>30)}");
                    #endregion

                    Console.ReadKey();
                }


            }
        }
    }
}