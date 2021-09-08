using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> name = new Employee<string>();
            List<string> Things = new List<string>(){ "Bob", "Carol"};

            Employee<int> ID = new Employee<int>();
            List<int> Things = new List<int>() { 1, 2 };

          
            
        }
    }
}
