using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLight
{
    public class TrafficLight
    {
        public enum Color
        {
            Red,
            Green,
            Yellow
        }

        public Color CurrentColor { get; set; }

        public void Change()
        {
            switch(CurrentColor)
            {
                case Color.Red:
                    CurrentColor = Color.Green;
                    break;
                case Color.Green:
                    CurrentColor = Color.Yellow;
                    break;
                default:
                    CurrentColor = Color.Red;
                    break;
            }
        }
    }
}
