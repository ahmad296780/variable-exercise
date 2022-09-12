using System;

namespace Variable_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Ralph";
            int dogAge = 10;
            char dog = 'D';
            bool myDog = true;
            double dogHeight = 2.2;
            decimal dogLength = 7.7m;
            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old");
            Console.WriteLine($"My dog's char is {dog}, He is {myDog} dog");
            Console.WriteLine($"My dog's height is {dogHeight}, He is {dogLength} long dog");
            Console.ReadLine();

        }
    }
}
