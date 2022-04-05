using DSAlgo.DataStructures.LinkedList;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //LinkedList
            SimplyLinkedList<int> sll = new SimplyLinkedList<int>();
            sll.AddToLast(1);
            sll.AddToLast(2);
            sll.AddToLast(3);
            sll.AddToLast(4);
            sll.AddToLast(5);
            sll.AddToFirst(0);

            sll.ReadAllNodes();

            Console.ReadLine();
        }
    }
}