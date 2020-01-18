using System;
using System.Collections.Generic;
using System.Text;

namespace sprint2oop
{
    public class Cat
    {

        //Here are the Properties
        public string Name { get; set; }
        public string FurColor { get; set; }
        public int Age { get; set; }
        public int Lives { get; set; }


        //Add the Class Contstructor for Default Object Creation
        public Cat(string name, string furColor, int age, int lives)
        {
            Name = name;
            FurColor = furColor;
            Age = age;
            Lives = lives;
        }

        public void Greeting()
        {
            Console.WriteLine("My Name is " + Name + " I have " +
              FurColor + " Furr." + " I am " + Age +
              " years old. " + " I have " + Lives + " lives.");

        }




    }
}
