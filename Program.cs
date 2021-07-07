using System;
using System.Globalization;
using System.Collections.Generic;
using System.Timers;
using static Hotel.Rooms;

namespace Hotel
{
    class Program
    {
        public static void printTime()
        {
            Console.WriteLine("Start date: ");

            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("dd - MM - yyyy Format: " + "\n" + startDate.ToString("dd - MM - yyyy"));
            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine("End date: ");

            var endDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("dd - MM - yyyy Format: " + "\n" + endDate.ToString("dd - MM - yyyy"));
            Console.ResetColor();
        }

        public static void printQuestions()
        {
            Console.WriteLine("Please select what you want to do:");
            Console.WriteLine("1 - Make a reservation;");
            Console.WriteLine("2 - List free rooms;");
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
                    printList();

                    Console.WriteLine();

                    Console.WriteLine("Enter room number: ");
                    int numroom = Int32.Parse(Console.ReadLine());

                    Console.WriteLine();

                    printTime();

                    Console.WriteLine();

                    Console.WriteLine("Enter count of beds: ");
                    int beds = Int32.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Want breakfast Yes/No: ");
                    string breakfast = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Which view want (sea, mountain, garden): ");
                    string view = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Want baby crib Yes/No: ");
                    string baby = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Enter notes: ");
                    string name = Console.ReadLine();

                    Console.WriteLine();

                    Rooms firstRoom = new Rooms(numroom, beds, breakfast, view, baby);
                    Console.WriteLine(firstRoom);

                    Console.WriteLine();

                    Console.WriteLine("Reservation was created!");

                    //Timer timer = new Timer();
                    //timer.Interval = 5000;

                    //Console.Clear();
                }
                else if (number == 2)
                {
                    printList();

                    Console.WriteLine();
                }
                else if (number == 3)
                {

                }
                else if (number == 4)
                {
                    printTime();

                    Console.WriteLine();
                }
                else if (number == 5)
                {
                    Console.WriteLine();

                    Console.WriteLine("Enter number of beds: ");
                    int beds = Int32.Parse(Console.ReadLine());

                    Console.WriteLine();

                    printTime();

                    Console.WriteLine();

                    Console.WriteLine("Available rooms: ");

                    Console.WriteLine();
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
