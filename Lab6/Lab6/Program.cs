using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            double sum = 0;

            tree.BuildTree(out sum);
            tree.PrintTree();
            Console.WriteLine("Summary price of items: " +  Convert.ToString(sum) + "$");
            Console.ReadKey();
        }
    }
}
