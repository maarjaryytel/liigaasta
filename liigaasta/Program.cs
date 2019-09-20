using System;

namespace liigaasta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            int yearOfBirth;
            Console.WriteLine("Enter Your year of birth: ");
            yearOfBirth = Int32.Parse(Console.ReadLine());

            if (yearOfBirth % 4 == 0)
            {
                Console.WriteLine($"{yearOfBirth} was a leap year.");
            }
            else
            {
                Console.WriteLine($"{yearOfBirth} was not a leap year.");
            }
            Console.ReadLine();
        
        //Ternary Operator- kui on ainult 2 vastusevarianti

            string answer = (yearOfBirth % 4 == 0) ? "Leap Year." : "Not a Leap Year";
            Console.WriteLine (answer);
            Console.ReadLine();*/


            Console.WriteLine("What would be Your poison? Whisky or wine?");
            string userChoice = Console.ReadLine();
            string choice = userChoice == "whisky" ? "Here is Your whisky." : "Here is your wine";
            Console.WriteLine(choice);
            Console.ReadLine();




        }
    }
}
