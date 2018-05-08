using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Car
    {
        private int Speed { get; set; }
        private string Make { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }

        public Car(string make, string model, int year, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Speed = speed;
        }

        public int SpeedUp()
        {
            //if (this.Speed > 0)
            {
                this.Speed++;
            }

            return Speed;
        }

        public int SlowDown()
        {
            if (this.Speed > 0)
            {
                this.Speed--;
            }

            return Speed;
        }

        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + "MPH.");
        }
    }
}
