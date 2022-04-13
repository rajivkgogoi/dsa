namespace DSAlgo.DataStructures.Algorithms
{
    internal class Misc
    {
        public void PrintGrid(int n)
        {
            int start = 1;

            while (start <= n)
            {
                int maxPerLine = start + 3;
                for (int i = start; i <= maxPerLine; i++)
                {
                    Console.Write(i + " ");
                    start++;
                }
                Console.WriteLine();
            }
        }
    }
}
