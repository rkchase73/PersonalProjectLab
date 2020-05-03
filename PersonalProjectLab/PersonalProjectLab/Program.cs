using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Runner's Helper***");

            int Choice;
            string input = "";
            int MilesRan = 0;
            decimal run = 0.0m;
            decimal timeHours = 0.0m;
            decimal timeMinutes = 0.0m;

            do
            {
                Console.WriteLine("Would you like to track miles or find average time per mile?");
                Console.WriteLine("Write '1' for tracking miles and '2' for finding an average.");
                input = Console.ReadLine();
                Choice = int.Parse(input);
                if (Choice == 1)
                {

                    Console.WriteLine("Your current miles for the week are 0");
                    
                    do
                    {
                        CurrentMiles = TotalMiles
                        Console.WriteLine("Enter the number of miles ran");
                        input = Console.ReadLine();
                        MilesRan = int.Parse(input);
                        MathClass Numbers = new MathClass();
                        Console.WriteLine("The total number of miles ran are " + Numbers.CalculateTotalMiles(MilesRan));

                        Console.WriteLine("Would you like to enter another run");
                        input = Console.ReadLine();
                    } while (input == "yes");
                }
                else
                {
                    do
                    {

                        Console.WriteLine("Enter the distance ran");
                        input = Console.ReadLine();
                        run = decimal.Parse(input);

                        Console.WriteLine("Enter the time it took to run the distance(number of hours)");
                        input = Console.ReadLine();
                        timeHours = decimal.Parse(input);

                        Console.WriteLine("Enter the time it took to run the distance(number of minutes)");
                        input = Console.ReadLine();
                        timeMinutes = decimal.Parse(input);

                        MathClass Numbers = new MathClass();
                        Console.WriteLine("The average time it took to run a mile is " + Numbers.CalculateAverageTime(run, timeHours, timeMinutes));

                        Console.WriteLine("Would you like to find another average?");
                        input = Console.ReadLine();
                    } while (input == "yes");
                }
                Console.WriteLine("Would you like to go back to the beginning ?");
                input = Console.ReadLine();
            } while (input == "yes");
            Console.WriteLine("Program has ended, Thank you.");
        }
    }
}