using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6;

namespace Lab6
{
    class Node
    {
        private Node _left;
        private Node _right;
        private Item _item;

        public Node(Item item)
        {
            _item = item;
        }

        public void NewNode(Item item)
        {   
            if (item.GetValue() < _item.GetValue())
            {
                if (_left == null)
                {
                    _left = new Node(item);
                }
                else
                {
                    _left.NewNode(item);
                }
            }
            else
            {
                if (_right == null)
                {
                    _right = new Node(item);
                }
                else
                {
                    _right.NewNode(item);
                }
            }
            
        }


        public void PrintNode(Node startNode, string side, string indent = "")
        {
            if(startNode != null)
            {
                Console.WriteLine(indent + side + _item.ToString());
                indent += "\t";
                if (_left != null)
                    _left.PrintNode(_left, "[L] ", indent);
                if (_right != null)
                    _right.PrintNode(_right, "[R] ", indent);
            }
        }

    }
}
