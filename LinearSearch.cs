using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    class LinearSearch : ISearchAlgorithm
    {
        public int Search(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == searchValue)
                    return i;
            }
            return -1;
        }
    }
}
