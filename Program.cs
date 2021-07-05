using System;
using System.Globalization;
using System.Collections.Generic;
using System.Timers;

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

        public static void printList()
        {
            Console.WriteLine();

            List<int> rooms = new List<int>()
            {
                105, 106, 107, 108, 109, 110,
                205, 206, 207, 208, 209, 210,
                305, 306, 307, 308, 309, 310,
                405, 406, 407, 408, 409, 410,
            };
            //List<int> rooms = new List<int>();
            //rooms.Add(105);
            //rooms.Add(106);
            //rooms.Add(107);
            //rooms.Add(108);
            //rooms.Add(109);
            //rooms.Add(110);

            Console.WriteLine();

            foreach (int aRooms in rooms)
            {
                Console.WriteLine(aRooms);
            }

            //int[,] rooms;

            //rooms = new int[,]
            //{
            //    { 105, 106, 107, 108, 109, 110 },
            //    { 205, 206, 207, 208, 209, 210 },
            //    { 305, 306, 307, 308, 309, 310 },
            //    { 405, 406, 407, 408, 409, 410 },
            //};

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        Console.WriteLine(rooms[i,j]);
            //    }
            //    Console.WriteLine();
            //}
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
                    Console.WriteLine();

                    printList();

                    Console.WriteLine();

                    Console.WriteLine("Enter room number: ");
                    int numroom = Int32.Parse(Console.ReadLine());

                    Console.WriteLine();

                    printTime();

                    Console.WriteLine();

                    Console.WriteLine("Enter notes: ");
                    string name = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Reservation was created!");

                    //Timer timer = new Timer();
                    //timer.Interval = 5000;

                    Console.Clear();
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
