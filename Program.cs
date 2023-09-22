using System;

namespace project101

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getting the Sum of the 2 numbers
            /*Console.WriteLine("Enter First Number; ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number; ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            sum *= 2;
            Console.WriteLine("the double of sum is "+ sum);*/

            //increment "friends" variable and using Math method
            /*double friends = 10;
            friends++;
            //double a = Math.Pow(friends, 2);
            double b = Math.Sqrt(friends);
            Console.WriteLine(b);*/

            //Generate random numbers
            /*Random random = new Random();
            //int x=random.Next(1,7);
            double y = random.NextDouble();
            Console.WriteLine(y);*/

            //input two variables and generate hypothenius
            /*Console.WriteLine("Enter first number; ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number; ");
            double y = Convert.ToDouble(Console.ReadLine());

            double z = Math.Sqrt((Math.Pow(x,2)) + (Math.Pow(y,2)));
            Console.WriteLine(z);*/

            //Learning methods of c#
            /*String fullName = "Ishara Wije";
            fullName = fullName.ToUpper();
            fullName = fullName.ToLower();
            String userName = fullName.Insert(0, "@");
            Console.WriteLine(fullName);
            Console.WriteLine(userName);*/

            //if statement
            /*Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 21)
                Console.WriteLine("You can vote");
            else
                Console.WriteLine("You can't vote");*/

            /*Console.WriteLine("What's your favorite exercise");
            String fav_Exercise = Console.ReadLine();

            switch (fav_Exercise)
            {
                case "Bench Press":
                    Console.WriteLine("Your chest will be big");
                    break;
                case "Shoulder Press":
                    Console.WriteLine("Your shoulder will be big");
                    break ;
                case "Crunches":
                    Console.WriteLine("You will have abs ASAP");
                    break;
                default:
                    Console.WriteLine(fav_Exercise + " is not a exercide");
                    break;




            }*/

            /*Console.WriteLine("What's the tempreture outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm out there");
            }
            else if (temp > 25 && temp <= 40)
            {
                Console.WriteLine("It's hot out there");
            }
            else if (temp < 10 && temp >= 0)
            {
                Console.WriteLine("It's cold out there");
            }
            else if (temp < 0)
            {
                Console.WriteLine("It's ice cold");
            }
            else
                Console.WriteLine("It's soo hot");*/

            Console.ReadKey();


        }
    }
}