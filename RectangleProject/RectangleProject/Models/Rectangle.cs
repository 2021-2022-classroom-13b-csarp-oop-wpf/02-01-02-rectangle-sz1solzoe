using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        private double sideA, sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                sideA = value;
            }
        }
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                sideB = value;
            }
        }
        public double Area
        {
            get
            {
                return Math.Round((sideA * sideB), 2);
            }
        }
        public double Perimeter
        {
            get
            {
                return Math.Round((2 * (sideA + sideB)), 2);
            }
        }
        public override string ToString()
        {
            return "A téglalap oldalai: " + sideA + ", " + sideB + "\n Kerülete: " + Area + "\n Területe: " + Perimeter;
        }
    }
}
