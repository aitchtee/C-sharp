﻿using System;
using System.Drawing;

namespace The_Life_Game{
    class Meal{
        private Point location;
        private SolidBrush color;
        public Point Location { get => location; }
        public SolidBrush Color { get => color; }
        public static int Radius { get => 10; }
        public Meal(){
            var randLocation = new Random();
            var borderLeft = 0;
            var borderRight = 1366;
            var borderUp = 0;
            var borderDown = 768;
            var border = 5;

            location = new Point(randLocation.Next(borderLeft + border, borderRight - border)
                                ,randLocation.Next(borderUp + border, borderDown - border));
            color = new SolidBrush(System.Drawing.Color.LightGreen);
        }
    }
}
