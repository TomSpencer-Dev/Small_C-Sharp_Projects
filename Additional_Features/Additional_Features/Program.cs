using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Program
    {
        const int a = 10;

        static void Main(string[] args)
        {

            const int b = 20;
            const int c = b + a;
            Console.WriteLine(c);
            Console.ReadLine();

            var name = "Tom";
            var age = "36";

            Constructor obj = new Constructor();
            Constructor obj1 = new Constructor(12);
            Constructor obj2 = new Constructor(36, "Tom");
            


        }
    }
}
