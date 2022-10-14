using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Students
    {
        public string name;
        public string surname;
        public int age;


        public Students()
        {

        }


        public Students(string Hello)
        {
            Console.WriteLine("Hello Student");
        }


        public Students(string name, string surname)
        {                           


            Console.WriteLine(this.name + " " + this.surname);

        }


        public Students(string name, string surname, int age)
        {

            this.name = name;
            this.surname = surname;
            this.age = age;

            Console.WriteLine(this.name + " " + this.surname + " " + this.age);

        }

    }
}
