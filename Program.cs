using System;

namespace sprint2oop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Create a new Cat Annoying
            Cat annoying = new Cat("Annoying", "blue", 4, 9);

            Console.WriteLine("Hello Kitty, Tell me about yourself!");

            //Ask the Cat to explain who it is
            annoying.Greeting();

            annoying.CheckLives();
          
        }
    }
}
