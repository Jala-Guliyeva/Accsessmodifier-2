using System;
using System.Collections.Generic;
using System.Text;

namespace accsess_modifier_2.Models
{
    class Person
    {
        private string _name;
        private string _surName;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    _name = value;
                    Console.WriteLine(UpperLetter(_name));
                }
                else
                {
                    Console.WriteLine("Name length type min 3 max 30");
                }
                if (UpperLetter(_name) == false)
                {
                    Console.WriteLine("Name start big letter ");
                    return;
                }
            }
        }

        public string SurName
        {
            get
            {
                return _surName;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 35)
                {
                    _surName = value;
                    Console.WriteLine(UpperLetter(_surName));
                }
                else
                {
                    Console.WriteLine("Surname length type min 3 max 35");
                }
                if (UpperLetter(_surName) == false)
                {
                    Console.WriteLine("Surname start big letter ");
                    return;
                }

            }
        }


        public Person()
        {

        }

        public Person(string Name, int Age)
        {
            this._name = Name;
            this._age = Age;
        }

        private bool UpperLetter(string Name)
        {
            foreach (char upper in Name)
            {
                if (char.IsUpper(upper))
                    return true;
            }
            return false;
        }

    }
}

