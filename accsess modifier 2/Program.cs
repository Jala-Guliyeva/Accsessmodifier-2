using System;
using accsess_modifier_2.Models;

namespace accsess_modifier_2
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Jale";
            Console.WriteLine(student.Name);
            student.SurName = "Quliyeva";
            Console.WriteLine(student.SurName);
            student.Point = 25;
            Console.WriteLine(student.Point);

        }
    }
}
