using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee quit = new IQuittable();
            quit.Quit();         
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
