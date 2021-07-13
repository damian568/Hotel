using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static Hotel1.Room;
using System.Globalization;
using Hotel1;

namespace Hotel1Project
{
    class Program
    {
        static void printfunction()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Rooms";
                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("id:" + reader[0] + " number: " + reader[1] + " beds: " + reader[2] + " breakfast: " + reader[3] + " vision: " + reader[4] + " baby crib: " + reader[5]);
                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Reservation";
                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("id:" + reader[0] + " start date: " + reader[1] + " end date: " + reader[2] + " number for rooms: " + reader[3] + " notes: " + reader[4]);
                }

            }
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "SELECT * FROM Reservation";
            //    var command = new SqlCommand(query, connection);
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("id:" + reader[0] + " start date: " + reader[1] + " end date: " + reader[2] + " number for rooms: " + reader[3] + " Notes: " + reader[4]);
            //    }

            //}
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string reservation = "INSERT INTO Reservation (start date, end date, number for rooms, Notes) VALUES (2021-08-21, 2021-09-05, 205, 'Aleks')";
            //    using (SqlCommand Command = new SqlCommand(reservation, connection))
            //    {
            //        Command.ExecuteNonQuery();
            //    }
            //}
            //Console.WriteLine("Inserting....");

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "INSERT INTO Rooms (number, beds, breakfast, vision, baby) VALUES (305, 4, 1, 'Sea', 1)";
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }
            //}
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string room = "INSERT INTO Rooms (number, beds, breakfast, vision, baby) VALUES (304, 2, 0, 'Sea', 0)";
            //    using (SqlCommand command = new SqlCommand(room, connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }
            //}

            //Console.WriteLine("Chetene sled insert.");

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "SELECT * FROM Rooms";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("id:" + reader[0] + " number: " + reader[1] + " beds: " + reader[2] + " breakfast: " + reader[3] + " vision: " + reader[4] + " baby crib: " + reader[5]);
            //    }
            //}

            //Console.WriteLine("Updating id 3....");

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "UPDATE Hotel SET vision = 'sea' WHERE ID = 1";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }
            //}

            //Console.WriteLine("Chetene sled update.");

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "SELECT * FROM Rooms";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("id:" + reader[0] + " number: " + reader[1] + " beds: " + reader[2] + " breakfast: " + reader[3] + " vision: " + reader[4] + " baby crib: " + reader[5]);
            //    }
            //}

            //3 izbor
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "SELECT  Reservation.start_Date, Reservation.end_Date FROM Reservation";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("id:" + reader[0] + " number: " + reader[1] + " start date: " + reader[2] + " end date: " + reader[3]);
            //    }
            //}
        }
        //3 izbor
        //static void selectFunction()
        //{
        //    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT  Rooms.beds, Reservation.start_Date, Reservation.end_Date FROM Rooms.beds = Rooms.number";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Console.WriteLine("id:" + reader[0] + " beds: " + reader[1] + " start date: " + reader[2] + " end date: " + reader[3]);
        //        }
        //    }
        //}

        static void deletefunction()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Start date and hour( like this 13:45:32) for delete your reservation");
                DateTime startdate = DateTime.Parse(Console.ReadLine());
                string query = "DELETE  FROM Reservations WHERE start_date = @startdate";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@startdate", startdate);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("id:" + reader[0] + " start date: " + reader[1] + " end date: " + reader[2] + " number for rooms: " + reader[3] + " notes: " + reader[4]);
                }

            }
        }
        static void resrvationFunction()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query = "SELECT * FROM Reservations";
                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("id:" + reader[0] + " start date: " + reader[1] + " end date: " + reader[2] + " number for rooms: " + reader[3] + " notes: " + reader[4]);
                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Number for rooms");
                int numroom = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Start date and hour( like this 13:45:32)");
                DateTime startdate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ënd date and hour( like this 13:45:32)");
                DateTime enddate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Notes");
                string name = Console.ReadLine();
                string room = "INSERT INTO Reservations (number_for_rooms, start_date, end_date, notes) VALUES (@numroom, @startdate, @enddate, @name)";
                using (SqlCommand command = new SqlCommand(room, connection))
                {
                    command.Parameters.AddWithValue("@numroom", numroom);
                    command.Parameters.AddWithValue("@startdate", startdate);
                    command.Parameters.AddWithValue("@enddate", enddate);
                    command.Parameters.AddWithValue("@name", name);
                    command.ExecuteNonQuery();
                }
            }
        }
        static void updateFunction()
        {
            //Console.WriteLine("Updating id 3....");
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                Console.WriteLine("Number for rooms");
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Count of beds");
                int beds = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Do you want breakfast(1-Yes/0-No): ");
                int breakfast = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vision (sea/mountain/garden");
                string view = Console.ReadLine();
                Console.WriteLine("Do you want baby crib(1-Yes/0-No): ");
                int baby = Int32.Parse(Console.ReadLine());
                string Query = "UPDATE Rooms SET beds = @beds, has_breakfast = @breakfast, vision = @view, has_baby = @baby WHERE number = @number";
                var Command = new SqlCommand(Query, connection);
                Command.Parameters.AddWithValue("@number", number);
                Command.Parameters.AddWithValue("@beds", beds);
                Command.Parameters.AddWithValue("@breakfast", breakfast);
                Command.Parameters.AddWithValue("@view", view);
                Command.Parameters.AddWithValue("@baby", baby);
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Id:" + reader[0] + " number: " + reader[1] + " beds: " + reader[2] + " has_breakfast: " + reader[3] + " vision: " + reader[4] + " has_baby" + reader[5]);
                }

            }
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    Console.WriteLine("Number for rooms");
            //    int number = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Count of beds");
            //    int beds = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Do you want breakfast: ");
            //    string breakfast = Console.ReadLine();
            //    Console.WriteLine("Vision (sea/mountain/garden");
            //    string view = Console.ReadLine();
            //    Console.WriteLine("Do you want baby crib: ");
            //    string baby = Console.ReadLine();
            //    string Rooms = "INSERT INTO Rooms (number, beds, has_breakfast, vision, has_baby) VALUES (@number, @beds, @breakfast, @view, @baby)";
            //    using (SqlCommand command = new SqlCommand(Rooms, connection))
            //    {
            //        command.Parameters.AddWithValue("@numroom", number);
            //        command.Parameters.AddWithValue("@startdate", beds);
            //        command.Parameters.AddWithValue("@enddate", breakfast);
            //        command.Parameters.AddWithValue("@view", view);
            //        command.Parameters.AddWithValue("@baby", baby);
            //        command.ExecuteNonQuery();
            //    }
            //}

        }
        static void statsfunction()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Start date ");
                DateTime startdate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("End date ");
                DateTime enddate = DateTime.Parse(Console.ReadLine());
                string query = "SELECT * FROM Reservations WHERE Reservations.start_date = @startdate, Reservation.end_date = @enddate";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@startdate", startdate);
                command.Parameters.AddWithValue("@enddate", enddate);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("id:" + reader[0] + " start date: " + reader[1] + " end date: " + reader[2] + " number for rooms: " + reader[3]);
                }
            }
        }
        static void selectFunction()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Start date and hour( like this 13:45:32)");
                DateTime startdate = DateTime.Parse(Console.ReadLine());
                string query = "SELECT * FROM Reservations WHERE @startdate NOT BETWEN start_date AND end_date";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@startdate", startdate);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("id:" + reader[0] + " start date: " + reader[1] + " end date: " + reader[2] + " number for rooms: " + reader[3]);
                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Start date and hour( like this 13:45:32)");
                DateTime start_date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ënd date and hour( like this 13:45:32)");
                DateTime enddate = DateTime.Parse(Console.ReadLine());
                string room = "INSERT INTO Reservations (start_date, end_date) VALUES ( @start_date, @enddate)";
                using (SqlCommand command = new SqlCommand(room, connection))
                {
                    
                    command.Parameters.AddWithValue("@start_date", start_date);
                    command.Parameters.AddWithValue("@enddate", enddate);
                 
                    command.ExecuteNonQuery();
                }
            }
        }
        private static void CreateCommand(string queryString,
              string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void printQuestions()
        {
            Console.WriteLine();
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
        public static void printRooms()
        {
            Console.WriteLine();

            //Rooms 105 - 110
            Room room105 = new Room(105, 2, 0, "\' Garden\'", 0);
            Console.WriteLine(room105);
            room105.insertRoom();
            Room room106 = new Room(106, 2, 1, "\'Mountain\'", 0);
            Console.WriteLine(room106);
            room106.insertRoom();
            Room room107 = new Room(107, 2, 1, "\'Mountain\'", 0);
            Console.WriteLine(room107);
            room107.insertRoom();
            Room room108 = new Room(108, 2, 1, "\' Garden\'", 1);
            Console.WriteLine(room108);
            room108.insertRoom();
            Room room109 = new Room(109, 2, 0, "\'Mountain\'", 1);
            Console.WriteLine(room109);
            room109.insertRoom();
            Room room110 = new Room(110, 2, 0, "\'Sea\'", 0);
            Console.WriteLine(room110);
            room110.insertRoom();

            Console.WriteLine();

            //Rooms 205 - 210
            Room room205 = new Room(205, 3, 1, "\'Sea\'", 0);
            Console.WriteLine(room205);
            room205.insertRoom();
            Room room206 = new Room(206, 3, 1, "\' Garden\'", 0);
            Console.WriteLine(room206);
            room206.insertRoom();
            Room room207 = new Room(207, 3, 0, "\'Mountain\'", 1);
            Console.WriteLine(room207);
            room207.insertRoom();
            Room room208 = new Room(208, 3, 1, "\'Sea\'", 1);
            Console.WriteLine(room208);
            room208.insertRoom();
            Room room209 = new Room(209, 3, 0, "\' Garden\'", 0);
            Console.WriteLine(room209);
            room209.insertRoom();
            Room room210 = new Room(210, 3, 1, "\' Garden\'", 0);
            Console.WriteLine(room210);
            room210.insertRoom();

            Console.WriteLine();

            //Rooms 305 - 310
            Room room305 = new Room(305, 4, 1, "\'Sea\'", 1);
            Console.WriteLine(room305);
            room305.insertRoom();
            Room room306 = new Room(306, 4, 0, "\'Mountain\'", 0);
            Console.WriteLine(room306);
            room306.insertRoom();
            Room room307 = new Room(307, 4, 1, "\' Garden\'", 0);
            Console.WriteLine(room307);
            room307.insertRoom();
            Room room308 = new Room(308, 4, 1, "\'Mountain\'", 0);
            Console.WriteLine(room308);
            room308.insertRoom();
            Room room309 = new Room(309, 4, 0, "\'Sea\'", 1);
            Console.WriteLine(room309);
            room309.insertRoom();
            Room room310 = new Room(310, 4, 0, "\'Sea\'", 1);
            Console.WriteLine(room310);
            room310.insertRoom();

            Console.WriteLine();

            //Rooms 405 - 410
            Room room405 = new Room(405, 5, 1, "\' Garden\'", 0);
            Console.WriteLine(room405);
            room405.insertRoom();
            Room room406 = new Room(406, 5, 0, "\'Mountain\'", 1);
            Console.WriteLine(room406);
            room406.insertRoom();
            Room room407 = new Room(407, 5, 1, "\'Sea\'", 1);
            Console.WriteLine(room407);
            room407.insertRoom();
            Room room408 = new Room(408, 5, 0, "\'Mountain\'", 0);
            Console.WriteLine(room408);
            room408.insertRoom();
            Room room409 = new Room(409, 5, 1, "\'Mountain\'", 0);
            Console.WriteLine(room409);
            room409.insertRoom();
            Room room410 = new Room(410, 5, 0, "\'Sea\'", 0);
            Console.WriteLine(room410);
            room410.insertRoom();
            Console.WriteLine("0 is No!");
            Console.WriteLine("1 is Yes!");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                printQuestions();
                Console.WriteLine();
                int number = Int32.Parse(Console.ReadLine());

                if (number == 1)
                {
                    printRooms();
                    Console.WriteLine();
                    

                    Console.WriteLine();

                    //Console.WriteLine("Enter room number: ");
                    //int numroom = Int32.Parse(Console.ReadLine());

                    //Console.WriteLine();

                    //printTime();

                    //Console.WriteLine();

                    //Console.WriteLine("Enter count of beds: ");
                    //int beds = Int32.Parse(Console.ReadLine());

                    //Console.WriteLine();

                    //Console.WriteLine("Want breakfast 1(Yes)/0(No): ");
                    //int breakfast = Int32.Parse(Console.ReadLine());

                    //Console.WriteLine();

                    //Console.WriteLine("Which view want (sea, mountain, garden): ");
                    //string view = Console.ReadLine();

                    //Console.WriteLine();

                    //Console.WriteLine("Want baby crib 1(Yes)/0(No): ");
                    //int baby = Int32.Parse(Console.ReadLine());

                    //Console.WriteLine();

                    //Console.WriteLine("Enter notes: ");
                    //string name = Console.ReadLine();

                    //Console.WriteLine();

                    //Room firstRoom = new Room(numroom, beds, breakfast, view, baby);
                    //Console.WriteLine(firstRoom);

                    //Console.WriteLine();

                    resrvationFunction();
                    Console.WriteLine("Reservation was created!");
                    //Timer timer = new Timer();
                    //timer.Interval = 5000;

                    //Console.Clear();
                }
                else if (number == 2)
                {
                    //printTime();
                    Console.WriteLine("This is reservation: ");
                    Console.WriteLine( );
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        //Console.WriteLine("Start date and hour( like this 13:45:32)");
                        //DateTime startdate = DateTime.Parse(Console.ReadLine());
                        string query = "SELECT * FROM Reservations";
                        var command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("id:" + reader[0] + " start date: " + reader[1] + " end date: " + reader[2] + " number for rooms: " + reader[3] + " notes: " + reader[4]);
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("And this is another rooms: ");
                    printRooms();

                    Console.WriteLine();
                }
                else if (number == 3)
                {
                    Console.WriteLine("This is reservation: ");
                    Console.WriteLine();
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        //Console.WriteLine("Start date and hour( like this 13:45:32)");
                        //DateTime startdate = DateTime.Parse(Console.ReadLine());
                        string query = "SELECT * FROM Reservations";
                        var command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("id:" + reader[0] + " start date: " + reader[1] + " end date: " + reader[2] + " number for rooms: " + reader[3] + " notes: " + reader[4]);
                        }

                    }
                    deletefunction();
                    //Console.WriteLine("Enter count of beds: ");
                    //int beds = Int32.Parse(Console.ReadLine());

                    //Console.WriteLine();
                    //printTime();
                    //Console.WriteLine();
                    
                    ////selectFunction();
                    //printRooms();
                    ////selectFunction();
                }
                else if (number == 4)
                {
                    statsfunction();
                    //printTime();
                    ////printRooms();
                    //Console.WriteLine();
                }
                else if (number == 5)
                {
                    //Console.WriteLine();

                    //Console.WriteLine("Enter number of beds: ");
                    //int beds = Int32.Parse(Console.ReadLine());

                    //Console.WriteLine();

                    //printTime();

                    //Console.WriteLine();

                    //Console.WriteLine("Available rooms: ");
                    //printRooms();
                    selectFunction();
                    Console.WriteLine();
                }
                else if (number == 6)
                {
                    //Console.WriteLine("Enter room number: ");
                    //int numroom = Int32.Parse(Console.ReadLine());
                    //Console.WriteLine();
                    //Console.WriteLine("Enter count of beds: ");
                    //int beds = Int32.Parse(Console.ReadLine());
                    //Console.WriteLine();
                    //Console.WriteLine("Want breakfast 1(Yes)/0(No): ");
                    //int breakfast = Int32.Parse(Console.ReadLine());
                    //Console.WriteLine();
                    //Console.WriteLine("Which view want (sea, mountain, garden): ");
                    //string view = Console.ReadLine();
                    //Console.WriteLine();
                    //Console.WriteLine("Want baby crib 1(Yes)/0(No): ");
                    //int baby = Int32.Parse(Console.ReadLine());
                    //Console.WriteLine();
                    //Console.WriteLine("Enter notes: ");
                    //string name = Console.ReadLine();
                    //Console.WriteLine();
                    //Room secondRoom = new Room(numroom, beds, breakfast, view, baby);
                    //Console.WriteLine(secondRoom);
                    updateFunction();
                    Console.WriteLine("Reservation was update!");
                }
                else if (number == 7)
                {
                    Environment.Exit(0);
                }
            }
        }


    }
}