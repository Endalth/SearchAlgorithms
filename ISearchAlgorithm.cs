using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    interface ISearchAlgorithm
    {
        int Search(int[] array, int searchValue);
    }
}
