using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
namespace Learning
{
    // class Test
    // {
    // public static void Main(string[] args)
    // {
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
    // int[] numbers_list = new int[5];
    // numbers_list = new int[] { 0, 1, 2, 3, 4 }; // must use new dtype {list items}; for reassignment aswell
    // string[] flowers = { "rose", "peony", "dandelion", "tulip" }; // new listdtype[length] not required if providing the whole list at assignment
    // numbers_list[2] = 6;
    // foreach (int numb in numbers_list)
    // {
    //     Console.WriteLine(numb);
    // }
    // for (int i = 0; i < flowers.Length; i++)
    // {
    //     Console.WriteLine(flowers[i]);
    // }

    // lists, arrays but dynamically sized
    // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 }; // cant just assign the values like in array, have to use new list<dtype>
    // numbers.Add(10);
    // numbers.Add(101);
    // numbers.Add(50);
    // numbers.Insert(1, 100);
    // Console.WriteLine(numbers.Contains(101));
    // numbers.Sort();
    // numbers.Remove(101);
    // numbers.RemoveAt(numbers.Count - 1);
    // foreach (int num in numbers)
    // { 
    //     Console.WriteLine(num);
    // }

    // P1
    // Console.WriteLine("Please enter in a decimal");
    // double userInput = Convert.ToDouble(Console.ReadLine());
    // int truncator = Convert.ToInt32(userInput);
    // double decimal_part = userInput - truncator < 0 ? -1 * (userInput - truncator) : userInput - truncator;
    // Console.WriteLine(decimal_part);
    // only works on positives bruh

    // P2
    // Random rand = new Random();
    // int num1 = rand.Next(0,100);
    // int num2 = rand.Next(0,100);
    // Console.WriteLine(num1 * num2);

    // P3
    // Console.WriteLine("Please enter an integer");
    // int num = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Please enter an integer");
    // int num2 = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Please enter an integer");
    // int num3 = Convert.ToInt32(Console.ReadLine());
    // int output = num < num2 ? num2 : num;
    // output = output < num3 ? num3 : output;
    // Console.WriteLine(output);

    // P4
    // Console.WriteLine("What color is the light?");
    // string lightColor = Console.ReadLine()!;
    // if (lightColor == "green")
    // {
    //     Console.WriteLine("It's time to go");
    // }
    // else if (lightColor == "yellow")
    // {
    //     Console.WriteLine("Make a decision to stop or go base on distance");
    // }
    // else if (lightColor == "red")
    // {
    //     Console.WriteLine("Stop before the intersection");
    // }
    // else
    // { 
    //     Console.WriteLine("That's not a light color!");
    // }

    // P5
    // Console.WriteLine("What's your favorite animal?");
    // string userInput = Console.ReadLine()!;
    // switch (userInput)
    // {
    //     case "dog":
    //         Console.WriteLine("Woof Woof!");
    //         break;

    //     case "cat":
    //         Console.WriteLine("MeoWWWW");
    //         break;

    //     case "bird":
    //         Console.WriteLine("Ca CawwwwWW");
    //         break;

    //     default:
    //         Console.WriteLine("idk abt that pluh");
    //         break;
    // }

    // P6
    // Console.WriteLine("what score did you get?");
    // int userInput = Convert.ToInt32(Console.ReadLine());
    // switch (userInput)
    // {   
    //     case var x when x > 100:
    //         Console.WriteLine("You can't get over 100% silly!");
    //         break;

    //     case var x when x >= 90:
    //         Console.WriteLine("You got an A!");
    //         break;

    //     case var x when x >= 80:
    //         Console.WriteLine("You got an B!");
    //         break;

    //     case var x when x >= 70:
    //         Console.WriteLine("You got an C!");
    //         break;

    //     case var x when x >= 60:
    //         Console.WriteLine("You got an D!");
    //         break;

    //     case var x when x >= 0:
    //         Console.WriteLine("You got an F!");
    //         break;

    //     default:
    //         Console.WriteLine("idk abt that pluh");
    //         break;
    //}

    // P7
    // int sum = 0;
    // Random rand = new Random();
    // for (int i = 0; i < 10; i++)
    // {
    //     sum = sum + rand.Next(0, 100);
    // }
    // Console.WriteLine(sum);

    // P8
    // for (int i = 2000; i <= 3000; i++)
    // {
    //     if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }

    // P9
    // string password = "password";
    // while (true) 
    // {
    //     Console.WriteLine("Enter password");
    //     string userInput = Console.ReadLine()!;
    //     if (userInput == password)
    //     {
    //         Console.WriteLine("access granted");
    //         break;
    //     }
    //     else
    //     {
    //         Console.WriteLine("try again");
    //     }
    // }

    // P10
    // while (true)
    // {
    //     for (int i = 1; i < 10; i++)
    //     {
    //         Console.WriteLine(i);
    //     }
    //     for (int i = 10; i > 1; i--)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }

    // P11
    // Test.average();

    // P12
    // Console.WriteLine(Test.calculate(5,9,"/"));

    // P13
    // int[] numberList = new int[5];
    // Random rand = new Random();
    // for (int i = 0; i < 5; i++)
    // {
    //     numberList[i] = rand.Next(0, 100);
    // }
    // foreach (int num in numberList)
    // {
    //     Console.WriteLine(num);
    // }

    // P14
    // List<string> colors = new List<string> { "red", "green", "blue", "orange", "yellow" };
    // colors.Add("pink");
    // colors.Add("purple");
    // Random rand = new Random();
    // colors.RemoveAt(rand.Next(colors.Count));
    // foreach (string color in colors)
    // {
    //     Console.WriteLine(color);
    // }



    // }

    // public static void average() // P11
    // {
    //     int sum = 0;
    //     Random rand = new Random();
    //     for (int i = 0; i < 5; i++)
    //     {
    //         sum = sum + rand.Next(0, 5); // please don't make me do console.writeline anymore :sob:
    //     }
    //     Console.WriteLine(sum/5.0f);
    // }

    // public static double calculate(int num1, int num2, string operation) // p12
    // {
    //     if (operation == "+")
    //     {
    //         return num1 + num2;
    //     }
    //     else if (operation == "-")
    //     {
    //         return num1 - num2;
    //     }
    //     else if (operation == "*")
    //     {
    //         return num1 * num2;
    //     }
    //     else
    //     {
    //         return num1*1.0f / num2;
    //     }
    // }
    // }

    // P15 & 16
    // class Vehicle
    // {
    //     public string vehicleType = "unknown";
    //     public string name = "unknown";
    //     public int wheelCount = 0;

    //     public Vehicle()
    //     {

    //     }
    //     public Vehicle(string enteredVehicleType, string enteredName, int enteredWheelCount)
    //     {
    //         vehicleType = enteredVehicleType;
    //         name = enteredName;
    //         wheelCount = enteredWheelCount;
    //     }

    //     public void displayVehicle()
    //     {
    //         Console.WriteLine($"Vehicle type: {vehicleType}");
    //         Console.WriteLine($"Vehicle name: {name}");
    //         Console.WriteLine($"Wheel count: {wheelCount}");
    //     }

    //     public static void Main(string[] Args)
    //     {
    //         Vehicle vehicle1 = new Vehicle();
    //         vehicle1.displayVehicle();
    //         Vehicle vehicle2 = new Vehicle("Sedan", "Toyota Prius", 4);
    //         vehicle2.displayVehicle();
    //         Car car1 = new Car("Michael", "white", 2025, 12345);
    //         car1.displayCar();
    //     }
    // }

    // class Car : Vehicle
    // {
    //     public string owner;
    //     public string color;
    //     public int ManufactureYear;
    //     public int licensePlate;

    //     public Car()
    //     {
    //         owner = "unknown";
    //         color = "unknown";
    //         ManufactureYear = 0;
    //         licensePlate = 0;
    //     }

    //     public Car(string enteredOwner, string enteredColor, int enteredManufactureYear, int enteredLicensePlate)
    //     {
    //         owner = enteredOwner;
    //         color = enteredColor;
    //         ManufactureYear = enteredManufactureYear;
    //         licensePlate = enteredLicensePlate;
    //     }

    //     public void displayCar()
    //     {
    //         Console.WriteLine($"Owner: {owner}");
    //         Console.WriteLine($"Color: {color}");
    //         Console.WriteLine($"ManufactureYear: {ManufactureYear}");
    //         Console.WriteLine($"licensePlate: {licensePlate}");
    //     }
    //}

    // P17
    class Motorcycle
    {
        public string model;
        public string color;
        public string owner;
        public int topSpeed;


        public Motorcycle()
        {
            model = "unknown";
            color = "unknown";
            owner = "unknown";
            topSpeed = 0;
        }
        public Motorcycle(string _model, string _color, string _owner, int _topSpeed)
        {
            model = _model;
            color = _color;
            owner = _owner;
            topSpeed = _topSpeed;
        }
        public static void Main(string[] args)
        {
            Motorcycle moto1 = new Motorcycle("vespa", "red", "Michael", 40);
            moto1.displayMotorcycle();
            moto1.sprayPaint("black");
            moto1.displayMotorcycle();
        }
        public void displayMotorcycle()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine($"Top speed: {topSpeed}");
        }
        public void sprayPaint(string newColor)
        {
            color = newColor;
            Console.WriteLine($"Color: {color}");
        }
    }
}