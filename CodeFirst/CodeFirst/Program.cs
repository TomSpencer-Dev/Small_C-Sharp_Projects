using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;
using EF6Console;
using CodeFirst;

namespace EF6Console
{ 

   public class Program
        {
            public static void Main(string[] args)
            {
            
                using (var ctx = new SchoolContext())
                {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student saved successfully!");

               
                
            }
            }
        }
}
