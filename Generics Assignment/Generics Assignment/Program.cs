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
            List<string> names = new List<string>(){ "Bob", "Carol"};
            name.things = names;

            Employee<int> ID = new Employee<int>();
            List<int> IDS = new List<int>() { 1, 2 };
            ID.things = IDS;

            foreach (string item in name.things)
            {
                Console.WriteLine(item);

            }

            foreach (int item in ID.things)
            {
                Console.WriteLine(item);

            }

            Console.ReadLine();
        }
    }
}
