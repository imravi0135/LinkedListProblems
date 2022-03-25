﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node node_1 = new Node(20);
            Node node_2 = new Node(21);
            Node node_3 = new Node(22);

            linkedList.AddNode(node_1);
            linkedList.AddNode(node_2);
            linkedList.AddNode(node_3);

            linkedList.Display();

            Node node_4 = new Node(23);
            linkedList.AppendNode(node_4);
            linkedList.Display();

            Node node_5 = new Node(24);
            linkedList.AddNodeatStart(node_5);
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
