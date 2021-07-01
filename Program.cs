using System;

namespace Hotel
{
    class Program
    {
        public static void printQuestions()
        {
            Console.WriteLine("Please select what you want to do:");
            Console.WriteLine("1 - Make a reservation;");
            Console.WriteLine("2- List free rooms;");
            Console.WriteLine("3 - Checkout room;");
            Console.WriteLine("4 - Stats;");
            Console.WriteLine("5 - Find a room;");
            Console.WriteLine("6 - Update a room;");
            Console.WriteLine("7 - Exit;");

            Console.WriteLine();

            Console.WriteLine("Choose number: ");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                printQuestions();

                int number = Int32.Parse(Console.ReadLine());

                if(number == 1)
                {

                }
                else if (number == 2)
                {

                }
                else if (number == 3)
                {

                }
                else if (number == 4)
                {

                }
                else if (number == 5)
                {

                }
                else if (number == 6)
                {

                }
                else if (number == 7)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
