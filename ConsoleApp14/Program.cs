using System;

namespace ConsoleApp13
{
    public class BirdCount
    {
        private int[] counts;

        
        public BirdCount(int[] birdsPerDay)
        {
            counts = birdsPerDay;
        }

       
        public void IncrementTodaysCount()
        {
            counts[counts.Length - 1] += 1;
        }

        
        public void PrintCounts()
        {
            Console.WriteLine("Harfatlik qushlar soni:");
            foreach (int count in counts)
            {
                Console.WriteLine(count);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
            BirdCount birdCount = new BirdCount(lastWeek);

            birdCount.IncrementTodaysCount(); 
            birdCount.PrintCounts();
        }
    }
}
