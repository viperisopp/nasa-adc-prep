using System;
using System.Collections.Generic;
namespace Learning
{
    class Test
    {
        public static void Main(string[] args)
        {
            // basic start
            // Console.WriteLine("Hello World!");

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

            // Random rand = new Random(); // create object rand of class random, Next, NextBytes, NextDouble
            // int num1 = rand.Next(); // non neg random int
            // double num2 = rand.NextDouble(); // 0.0 <= x < 1.0, double data type better than float dt??
            // Console.WriteLine(num1 + num2);

            // Console.WriteLine("Enter your age:");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Do you have a permit? (yes/no)");
            // bool hasPermit = (Console.ReadLine() == "yes");
            // if (16 <= age && age < 18) // cant do 16 < age < 18, CS0019
            // {
            //     Console.WriteLine(hasPermit? "You can get a Provisional DL!" : "You need a permit before getting a DL");
            // }
            // else if (age < 16)
            // {
            //     Console.WriteLine("We got nba YOUNGboy over here");
            // }
            // else
            // {
            //     Console.WriteLine(!hasPermit? "You don't need a permit anyways" : "You can get the full DL package");
            // }

            // switches
            // Console.WriteLine("yes or no");
            // string answer = Console.ReadLine()!;
            // switch (answer)
            // {
            //     case "yes":
            //         Console.WriteLine("said yes");
            //         break;
            //     case "no":
            //         Console.WriteLine("said no");
            //         break;
            //     default:
            //         Console.WriteLine("didn't listen to the command");
            //         break;
            // } // if statements >>>>>

            // loops
            //for (int looper = 0; looper < 10; looper++) also works
            // int looper = 0;
            // for (; looper < 10; looper++) // in order to use an outside variable for the loop, outside must be left empty, but just use a while loop atp
            // {
            //     Console.WriteLine(looper);
            // }

            // looper = 0;
            // while (looper < 3)
            // {
            //     Console.WriteLine(looper);
            //     looper++;
            // }

            // Arrays
            int[] numbers_list = new int[5];
            numbers_list = new int[] { 0, 1, 2, 3, 4 }; // must use new dtype {list items}; for reassignment aswell
            string[] flowers = { "rose", "peony", "dandelion", "tulip" }; // new listdtype[length] not required if providing the whole list at assignment
            numbers_list[2] = 6;
            foreach (int numb in numbers_list)
            {
                Console.WriteLine(numb);
            }
            for (int i = 0; i < flowers.Length; i++)
            {
                Console.WriteLine(flowers[i]);
            }
        }
    }
}