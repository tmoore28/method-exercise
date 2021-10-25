using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine($"There was a kid named {userName}.");
            Console.WriteLine($"Every day he would jam along with {favBand} on his guitar.");
            Console.WriteLine($"The guitar was a birthday gift it was a {favColor} gibson, with a bunch of {favAnimal} stickers all over the back.");

        }
    }
}
