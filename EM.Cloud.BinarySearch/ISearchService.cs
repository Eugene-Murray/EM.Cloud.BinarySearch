using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Cloud.BinarySearch
{
    public interface ISearchService
    {
        int FindWinner(int[] inputArray);

        object BinarySearchIterative(int[] inputArray, int? searchKey, int min, int max);

        object BinarySearchRecursive(int[] inputArray, int? searchKey, int min, int max);
    }
}
