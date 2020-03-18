using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using House.Classes;

/* Create a class "House", with an attribute "area", a constructor that sets its value and a method "ShowData" to display "I am a house, my area is 200 m2" (instead of 200, it will show the real surface). Include getters an setters for the area, too.

The "House" will contain a door. Each door will have an attribute "color" (a string), and a method "ShowData" wich will display "I am a door, my color is brown" (or whatever color it really is). Include a getter and a setter. Also, create a "GetDoor" in the house.

A "SmallApartment" is a subclass of House, with a preset area of 50 m2.

Also create a class Person, with a name (string). Each person will have a house. The method "ShowData" for a person will display his/her name, show the data of his/her house and the data of the door of that house.

Write a Main to create a SmallApartment, a person to live in it, and to show the data of the person. */

namespace House.Classes
{
    class Home
    {


        private int length { get; set; }
        private int width { get; set; }
        private int area { get; set; }
        private Door Door { get; set; }

        public Home()
        {
            this.area = 50;
        }

        public string getData(int area)
        {
            return "The area of the house is " + area + "m2";
        }
    }
}
