using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Segment segment1 = Segment.InputCoords();
            Segment segment2 = Segment.InputCoords();
            Segment segment3 = Segment.InputCoords();

            Console.WriteLine("Segments information: ");
            Segment.PrintInfo(segment1);
            Segment.PrintInfo(segment2);
            Segment.PrintInfo(segment3);

            if (segment1 | segment2)        
                Console.WriteLine("This segments are parallel");           
            else           
                Console.WriteLine("This segments aren't parallel");           

            Console.WriteLine("Initial length: " + Math.Round(Segment.GetSegmentLength(segment3), 4));
            ++segment3;
            Console.WriteLine("Length after editing coordinates: " + Math.Round(Segment.GetSegmentLength(segment3), 4));
            Console.ReadKey();
        }
    }
}
