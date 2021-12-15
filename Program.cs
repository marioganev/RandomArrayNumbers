using System;

namespace random_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[35];
            Random r = new Random();

            for (int i = 0; i < 35; i++)
            {
                int rand = r.Next(0, 100);
                arr[i] = rand;

                Console.WriteLine(arr[i]);
            }
        }
        
    }
}