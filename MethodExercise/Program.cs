using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("What is your favorite color?");
            //string favColor = Console.ReadLine();
            //Console.WriteLine("What is your favorite animal?");
            //string favAnimal = Console.ReadLine();
            //Console.WriteLine("What is your favorite band?");
            //string favBand = Console.ReadLine();
            //Console.WriteLine($"There was a kid named {userName}.");
            //Console.WriteLine($"Every day he would jam along with {favBand} on his guitar.");
            //Console.WriteLine($"The guitar was a birthday gift it was a {favColor} gibson, with a bunch of {favAnimal} stickers all over the back.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Now give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Now give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Sum(num1, num2);
            Console.WriteLine($"The sum is: {product}");
        }
        public static int Sum(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;

        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
