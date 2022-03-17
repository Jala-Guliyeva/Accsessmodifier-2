using System;
using System.Collections.Generic;
using System.Text;

namespace accsess_modifier_2.Models
{
    class Student : Person
    {
        private int _point;
        

        public int Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value > 0 && value <= 100)
                    _point = value;
                else
                    Console.WriteLine("Secim edin");
            }

        }



        public Student(double Point)
        {
            this.Point = _point;
        }



        public Student()
        {


        }
}
    }
