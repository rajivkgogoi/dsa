using DSAlgo.DataStructures.LinkedList;
using DSAlgo.DataStructures.LinkedList.DLL;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //LinkedList
            DoublyLinkedList<int> sll = new DoublyLinkedList<int>();
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