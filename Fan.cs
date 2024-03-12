using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    internal class Fan
    {
        public  const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int HIGH = 3;

        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "red";


        public string Color
        {
            set

            {
                color = value;  
            }

            get
            {
                return color;
            }

           
        }

        public double Radius
        {
            set { radius = value; }
            get
            {
                return radius;  
            }
        }

        public int Speed
        {
            set { speed = value; }
            get
            {
                return speed;
            }
        }

        public bool ON
        {
            set => on = value;  
            get
            {
                return on;
            }
        }

        public override string ToString()
        {
            var d = on == true ? "ON" : "OFF";
            return $"Currently fan is {d} and running on speed of {speed} and it has color of {color}";
        }

    }
}
