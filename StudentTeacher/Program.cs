﻿using System;

/* Create a new project, and include in it the class Person that you just created.

Create a class "Student" and another class "Teacher", both descendants of "Person".

The class "Student" will have a public method "GoToClasses", which will write on screen "I’m going to class."

The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begins". Also, it will have a private attribute "subject", a string.

The class Person must have a method "SetAge (int n)" which will indicate the value of their age(eg, 20 years old).

The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number).

You must create another test class called "StudentAndTeacherTest" that will contain "Main" and:
Create a Person and make it say hello
Create a student, set his age to 21, tell him to Greet and display his age
Create a teacher, 30 years old, ask him to say hello and then explain. */


namespace StudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personJulian = new Person("Julian", 19);
            Person person = new Person(21);
            Console.WriteLine(person.Greet());
            Console.WriteLine(personJulian.Greet());
            Student student = new Student();
            Console.WriteLine(student.ShowAge(student.setAge(21)));
            Teacher teacher = new Teacher();
            teacher.setAge(30);
            Console.WriteLine(teacher.Greet());
            Console.WriteLine(teacher.Explain());
        }
    }
}
