using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string text = (Console.ReadLine());
            File.WriteAllText(@"C:\Users\Thomas\Desktop\Coding\Coding\Web Pages\GitHub\Small_C-Sharp_Projects\log.txt", text);
            
        }
    }
}
