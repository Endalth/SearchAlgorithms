using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISearchAlgorithm> searchAlgorithms = new List<ISearchAlgorithm>();
            searchAlgorithms.Add(new BinarySearch());
            searchAlgorithms.Add(new InterpolationSearch());
            searchAlgorithms.Add(new LinearSearch());

            int range = 100000000;
            int[] array = new int[range];

            Random random = new Random();
            for (int i = 1; i < range; i++)
            {
                array[i] = array[i - 1] + random.Next(1,10);
            }

            int searchValue = array[array.Length - 1];

            Stopwatch stopwatch = new Stopwatch();
            foreach (ISearchAlgorithm searchAlgorithm in searchAlgorithms)
            {
                Console.Write(searchAlgorithm.GetType().Name + ": ");
                stopwatch.Restart();
                Console.Write("|| " + searchAlgorithm.Search(array, searchValue) + " || ");
                stopwatch.Stop();
                Console.WriteLine(stopwatch.ElapsedMilliseconds + "ms");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
