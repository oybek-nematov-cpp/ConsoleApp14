using System;

namespace ConsoleApp13
{
    public class BirdCount
    {
        public static int[] LastWeek()
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] lastWeekCounts = BirdCount.LastWeek();

            Console.Write("O‘tgan haftadagi qushlar soni: ");
            foreach (int count in lastWeekCounts)
            {
                Console.Write(count+", ");
            }
        }
    }
}
