﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.EmpID = 1;
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.EmpID = 1;
            employee.SayName();
            Console.ReadLine();
            employee.SayName();
            Console.ReadLine();

        
        }
    }
}
