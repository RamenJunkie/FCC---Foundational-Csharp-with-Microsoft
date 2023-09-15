using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello C#!");
            //Create new Random Object
            Random dice = new Random();
            //Next is used to refresh the random seed
            int roll = dice.Next(1, 7);
            //Write out the Roll
            Console.WriteLine(roll);
        }
    }
}