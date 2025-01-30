using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Overload
    {
        public int length;
        public int width;
        public int bases;
        public int height;
        public int area;
        public double triangle = 0.5;

        public int CalculateArea(int width, int length)
        {
            return width * length;
        }

        public double CalculateArea(double length, double height, double triangle)
        {
            return triangle * length * height;
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
