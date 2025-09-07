using System;
namespace Learning
{
    class Test
    {
        public static void Main(string[] args)
        {
            // basic start
            Console.WriteLine("Hello World!");

            //creating/learing data types
            int num = 69;
            string name = "michael";
            float funny_num = 69.420f;
            // declaration of vars
            bool male;
            male = true;

            // Print and Input
            Console.WriteLine($"The number I choose was {num}, the name I choose was {name} and the float I choose was {funny_num}. Am I a male? {male}");
            Console.WriteLine("What is your favorite song:");
            string text = Console.ReadLine()!; // learned that ! to suppress CS8600 error
            Console.WriteLine($"My favorite song is: {text}");
        }
    }
}