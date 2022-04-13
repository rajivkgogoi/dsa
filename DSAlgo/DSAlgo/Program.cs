using DSAlgo.DataStructures.Algorithms;
using DSAlgo.DataStructures.LinkedList;
using DSAlgo.DataStructures.LinkedList.DLL;
using DSAlgo.DataStructures.Search;
using DSAlgo.Sorting;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Binary Search
            /*int[] sortedArray = { 10, 11, 22, 30, 40, 55 };
            BinarySearch bs = new BinarySearch();

            Console.WriteLine(bs.Search(sortedArray, 30));
            Console.WriteLine(bs.Search(sortedArray, 11));
            Console.WriteLine(bs.Search(sortedArray, 111));*/
            //Misc misc = new Misc();
            //misc.PrintGrid(16);

            int[] unsortedArray = { 11, 2, 33, 4, 55, 9, 21 };
            SelectionSort ss = new SelectionSort();
            ss.SortAscending(unsortedArray);

            Console.ReadLine();
        }
    }
}