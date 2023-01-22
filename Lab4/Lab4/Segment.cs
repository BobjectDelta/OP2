using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Segment
    {
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;

        public Segment(double x1, double y1, double x2, double y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public Segment(double x2, double y2)
        {
            _x1 = 0;
            _y1 = 0;
            _x2 = x2;
            _y2 = y2;
        }

        public Segment()
        {
            _x1 = 0;
            _y1 = 0;
            _x2 = 2;
            _y2 = 2;
        }

        public static double GetX1(Segment segment)
        {
            return segment._x1;
        }

        public static double GetY1(Segment segment)
        {
            return segment._y1;
        }

        public static double GetX2(Segment segment)
        {
            return segment._x2;
        }

        public static double GetY2(Segment segment)
        {
            return segment._y2;
        }

        public static Segment InputCoords()
        {          
            string coordsLine = "";          

            Console.WriteLine("Enter 0, 2 or 4 coordinates of points (divide by Space):");
            coordsLine = Console.ReadLine();
            string[] coords = coordsLine.Split(' ');
            if (coords.Length == 4)
                return new Segment(Convert.ToDouble(coords[0]), Convert.ToDouble(coords[1]), Convert.ToDouble(coords[2]), Convert.ToDouble(coords[3]));
            else
                if (coords.Length == 2)
                return new Segment(Convert.ToDouble(coords[0]), Convert.ToDouble(coords[1]));
            else
                return new Segment();
         
        }

        public static void PrintInfo(Segment segment)
        {
            Console.WriteLine(GetX1(segment) + " " + GetY1(segment) + "  " + GetX2(segment) + " " + GetY2(segment));
        }

        public static double GetSegmentLength(Segment segment)
        {
            return (Math.Sqrt(Math.Pow(segment._x2 - segment._x1, 2) + Math.Pow(segment._y2 - segment._y1, 2)));
        }

        public static Segment operator ++(Segment segment)
        {
            return new Segment(segment._x1 + 1, segment._y1 + 1, segment._x2, segment._y2);
        }

        public static bool operator |(Segment segment1, Segment segment2)
        {
            double k1 = (segment1._y2 - segment1._y1) / (segment1._x2 - segment1._x1);
            double k2 = (segment2._y2 - segment2._y1) / (segment2._x2 - segment2._x1);
            if (k1 == k2)
                return true;
            else
                return false;
        }
    }
}
