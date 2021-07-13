using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

namespace Hotel1
{
    public class Room
    {
        private int number;
        private int beds;
        private int breakfast;
        private string view;
        private int baby;

        public Room(int n, int b, int bfast, string v, int ba)
        {
            this.number = n;
            this.beds = b;
            this.breakfast = bfast;
            this.view = v;
            this.baby = ba;
        }
        public void insertRoom()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Rooms (number, beds, has_breakfast, vision, has_baby) VALUES (" + this.Number + " ," + this.Beds + ", " + this.Breakfast + "," + this.View + "," + this.BabyCrib + ")";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public int Number
        {
            get { return this.number; }
            set
            {
                if ((value >= 105 && value <= 110) || (value >= 205 && value <= 210) || (value >= 305 && value <= 310) || (value >= 405 && value <= 410))
                {
                    this.number = value;
                }
                else
                {
                    Console.WriteLine("Don't have this number of room! ");
                }
            }
        }

        public int Beds
        {
            get { return this.beds; }
            set
            {
                if (value >= 2 && value <= 5)
                {
                    this.beds = value;
                }
                else
                {
                    Console.WriteLine("Don't have count of bed! ");
                }
            }
        }

        public int Breakfast
        {
            get { return this.breakfast; }
            set
            {
                if (value == 1)
                {
                    this.breakfast = value;
                }
                else if (value == 0)
                {
                    this.breakfast = value;
                }
            }
        }

        public string View
        {
            get { return this.view; }
            set
            {
                if (value == "sea" || value == "mountain" || value == "garden")
                {
                    this.view = value;
                }
                else
                {
                    Console.WriteLine("Don't have that view! ");
                }
            }
        }

        public int BabyCrib
        {
            get { return this.baby; }
            set
            {
                if (value == 1)
                {
                    this.baby = value;
                }
                else if (value == 0)
                {
                    this.baby = value;
                }
            }
        }

        public override string ToString()
        {
            return "Number of room: " + this.Number + "| Count of beds: " + this.Beds + "| Breakfast: " + this.Breakfast + "| View: " + this.View + "| Baby crib: " + this.BabyCrib;
        }

        public static void printList()
        {

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
                Console.Write(aRooms + " ");
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

        public static void printTime()
        {
            Console.WriteLine("Start date: ");

            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("dd - MM - yyyy Format: " + "\n" + startDate.ToString("dd/MM/yyyy"));
            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine("End date: ");

            var endDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("dd - MM - yyyy Format: " + "\n" + endDate.ToString("dd/MM/yyyy"));
            Console.ResetColor();
        }
    }
}
