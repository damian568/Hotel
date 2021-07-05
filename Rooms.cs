using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Rooms
    {
        private int number;
        private int beds;
        private bool breakfast;
        private string view;
        private bool baby;

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
                if(value >= 1 && value <= 5)
                {
                    this.beds = value;
                }
                else
                {
                    Console.WriteLine("Don't have count of bed! ");
                }
            }
        }

        public bool Breakfast
        {
            get { return this.breakfast; }
            set { this.breakfast = value; }
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

        public bool Baby
        {
            get { return this.baby; }
            set { this.baby = value; }
        }
    }
}
