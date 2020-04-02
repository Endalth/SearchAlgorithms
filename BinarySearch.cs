using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    class BinarySearch : ISearchAlgorithm
    {
        public int Search(int[] array, int searchValue)
        {
            int lowIndex = 0;
            int highIndex = array.Length - 1;

            while (lowIndex <= highIndex)
            {
                int mid = lowIndex + (highIndex - lowIndex) / 2;

                if (array[mid] == searchValue)
                    return mid;
                else if (array[mid] < searchValue)
                    lowIndex = mid + 1;
                else
                    highIndex = mid - 1;
            }

            return -1;
        }
    }
}
