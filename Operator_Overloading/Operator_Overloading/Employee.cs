using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Employee
    {
        public int id { get; set; }
        public static bool operator==(Employee employee, Employee employee1)
        {
            return employee.id == employee1.id;

        }

        public static bool operator!=(Employee employee, Employee employee1)
        {
            return employee.id != employee1.id;

        }
    }
}
