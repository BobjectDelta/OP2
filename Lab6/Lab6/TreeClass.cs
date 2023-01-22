using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6;

namespace Lab6
{
    class Tree
    {
        private Node _root;

        public void BuildTree(out double sum)
        {
            string ctrlStr = "N";
            bool flag = true;
            string buffer = "";
            string name;
            int amount;
            double value;
            sum = 0;
            while (flag)
            {
                Console.WriteLine("Enter name, amount and price of item. Enter " + ctrlStr + " to stop.");
                buffer = Console.ReadLine();
                if (buffer != ctrlStr)
                {
                    name = buffer;
                    amount = Convert.ToInt32(Console.ReadLine());
                    value = Convert.ToDouble(Console.ReadLine());
                    sum += value * amount;
                    Item item = new Item(name, amount, value);
                    if (_root == null)
                        _root = new Node(item);
                    else
                        _root.NewNode(item);
                    Console.WriteLine("Item added.");
                }
                else
                    flag = false;
            }
        }

        public void PrintTree()
        {
            _root.PrintNode(_root, "[+] ");
        }
    }
}
