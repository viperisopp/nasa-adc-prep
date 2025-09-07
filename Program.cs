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
            // int num = 69;
            // string name = "michael";
            // float funny_num = 69.420f;
            // // declaration of vars
            // bool male;
            // male = true;

            // Print and Input
            // Console.WriteLine($"The number I choose was {num}, the name I choose was {name} and the float I choose was {funny_num}. Am I a male? {male}");
            // Console.WriteLine("What is your favorite song:");
            // string text = Console.ReadLine()!; // learned that ! to suppress CS8600 error
            // Console.WriteLine($"My favorite song is: {text}");

            // Data type conversion
            // float num = 67.49f;
            // Console.WriteLine(num);
            // string text_num = Convert.ToString(num);
            // Console.WriteLine(text_num);
            // float num_again = Convert.ToSingle(text_num);
            // Console.WriteLine(num_again);
            // int funky_num = Convert.ToInt32(num_again); // rounds a flaot
            // Console.WriteLine(funky_num);

            // Console.WriteLine("Yo, enter a int please:");
            // int myInt = Convert.ToInt32(Console.ReadLine()); // can put zeros in front
            // Console.WriteLine(funky_num + myInt); // C# allows this, int + float, and operations within prints

            Random rand = new Random(); // create object rand of class random, Next, NextBytes, NextDouble
            int num1 = rand.Next(); // non neg random int
            double num2 = rand.NextDouble(); // 0.0 <= x < 1.0, double data type better than float dt??
            Console.WriteLine(num1 + num2);

        }
    }
}