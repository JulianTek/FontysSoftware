using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTeacher
{
    class Person
    {
        protected string name { get; set; }
        protected int age { get; set; }


        public int setAge(int age)
        {
            this.age = age;
            return age;
        }

        public Person(string name, int age)
        {

        }

        public Person(int age)
        {

        }
        
        public Person()
        {

        }

        public string Greet()
        {
            return "Hello!";
        }
    }
}
