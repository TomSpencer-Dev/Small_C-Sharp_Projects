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
            Employee emp1 = new Employee();
            emp1.firstName = "Joe";
            emp1.lastName = "Stalin";
            emp1.ID = 1;
            Employees.Add(emp1);
            Employee emp2 = new Employee();
            emp2.firstName = "Joe";
            emp2.lastName = "Becker";
            emp2.ID = 2;
            Employees.Add(emp2);
            Employee emp3 = new Employee();
            emp3.firstName = "Sarah";
            emp3.lastName = "Calwell";
            emp3.ID = 3;
            Employees.Add(emp3);
            Employee emp4 = new Employee();
            emp4.firstName = "Crystal";
            emp4.lastName = "Parker";
            emp4.ID = 4;
            Employees.Add(emp4);
            Employee emp5 = new Employee();
            emp5.firstName = "Derek";
            emp5.lastName = "Jeeter";
            emp5.ID = 5;
            Employees.Add(emp5);
            Employee emp6 = new Employee();
            emp6.firstName = "Tom";
            emp6.lastName = "Sales";
            emp6.ID = 6;
            Employees.Add(emp6);
            Employee emp7 = new Employee();
            emp7.firstName = "Spencer";
            emp7.lastName = "Smith";
            emp7.ID = 7;
            Employees.Add(emp7);
            Employee emp8 = new Employee();
            emp8.firstName = "Barnaby";
            emp8.lastName = "Williams";
            emp8.ID = 8;
            Employees.Add(emp8);
            Employee emp9 = new Employee();
            emp9.firstName = "Star";
            emp9.lastName = "Wilson";
            emp9.ID = 9;
            Employees.Add(emp9);
            Employee emp10 = new Employee();
            emp10.firstName = "Janet";
            emp10.lastName = "Joplin";
            emp10.ID = 10;
            Employees.Add(emp10);


            List<Employee> EmpJoe = new List<Employee>();
            foreach (Employee Emp in Employees)
            {
                            if (Emp.firstName == "Joe")
                            {
                            
                            EmpJoe.Add(Emp);
                            
            }

                List<Employee> EmpJoe2 = new List<Employee>();
                foreach (Employee Emp1 in Employees.FindAll(e => (e.firstName == "Joe")).ToList())
                {
                    EmpJoe2.Add(Emp1);
                }

                List<Employee> EmpID = new List<Employee>();
                foreach (Employee Emp2 in Employees.FindAll(x => (x.ID > 5)).ToList())
                {
                    EmpID.Add(Emp2);
                }



               







            }
        }
    }
}
