using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Employee> Employees = new List<Employee>();



            List<string> firstnames = new List<string>()
            {
                "Joe", "Sarah", "Robert", "Carl", "Crystal", "Joe", "Erica", "Tommy", "Burt", "Rebecca"
            };

            List<string> lastnames = new List<string>()
            {
                "Jackson", "Smith", "Miller", "Turner", "Johnson", "Becker", "Harrington", "Eglington", "Seastorm", "McDonald"
            };

            List<int> IDs = new List<int>()
            {
                34332, 54754, 43523, 87012, 43158, 56784, 56876, 32231, 46786, 23457
            };






            foreach (string firstname in firstnames)
            {
                foreach (string lastname in lastnames)
                {
                    foreach (int ID in IDs)
                    {


                        if (firstname == "Joe")
                        {
                            Employee EmployeeJoe = new Employee();
                            EmployeeJoe.firstname = firstname;
                            EmployeeJoe.lastname = lastname;
                            EmployeeJoe.ID = ID;
                            Employees.Add(EmployeeJoe);

                            foreach (Employee Employee in Employees)
                            {
                                Console.WriteLine(EmployeeJoe.firstname + " " + EmployeeJoe.lastname + " " + EmployeeJoe.ID);

                            }
                            Console.ReadLine();
                        }
                    }
                


                }

            }
        }
    }
}
