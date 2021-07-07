using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Rooms
    {
        private int number;
        private int beds;
        private string breakfast;
        private string view;
        private string baby_crib;

        public Rooms(int n, int b, string bfast, string v, string bb)
        {
            this.Number = n;
            this.Beds = b;
            this.Breakfast = bfast;
            this.View = v;
            this.Baby_crib = bb;
        }

        public int Number
        {
            get { return this.number; }
            set
            {
                if((value >= 105 && value <= 110) || (value >= 205 && value <= 210) || (value >= 305 && value <= 310) || (value >= 405 && value <= 410))
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
                if(value >= 2 && value <= 5)
                {
                    this.beds = value;
                }
                else
                {
                    Console.WriteLine("Don't have count of bed! ");
                }
            }
        }

        public string Breakfast
        {
            get { return this.breakfast; }
            set
            {
                if(value == "Yes")
                {
                    this.breakfast = value;
                }
                else if(value == "No")
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
                if(value == "sea" || value == "mountain" || value == "garden")
                {
                    this.view = value;
                }
                else
                {
                    Console.WriteLine("Don't have that view! ");
                }
            }
        }

        public string Baby_crib
        {
            get { return this.baby_crib; }
            set
            {
                if (value == "Yes")
                {
                    this.baby_crib = value;
                }
                else if(value == "No")
                {
                    this.baby_crib = value;
                }
            }
        }

        public override string ToString()
        {
            return "Number of room: " + this.Number + "| Count of beds: " + this.Beds + "| Breakfast: " + this.Breakfast + "| View: " + this.View + "| Baby crib: " + this.Baby_crib;
        }
    }
}
