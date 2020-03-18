using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTeacher
{
    class Student : Person
    {

        public string ShowAge(int age)
        {
            return "My age is " + age;
        }

        public string GoToClasses()
        {
            return "I'm going to class";
        }
    }
}
