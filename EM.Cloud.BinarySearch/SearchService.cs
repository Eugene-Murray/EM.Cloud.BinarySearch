using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Cloud.BinarySearch
{
    public class SearchService : ISearchService
    {
        public int FindWinner(int[] inputArray)
        {
            Dictionary<int, int> winnersD = new Dictionary<int, int>();
            //winnersD.OrderBy(x => x.Key);

            int result = 0;
            foreach (var winner in inputArray)
            {
                if (winnersD.ContainsKey(winner))
                    winnersD[winner] = winnersD[winner] + 1;
                else
                    winnersD.Add(winner, 1);

                var numWins = winnersD.Max(x => x.Value);
                //var numWins = winnersD.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;

                result = winnersD.First(x => x.Value == numWins).Key;
            }

            return result;

        }

        public object BinarySearchIterative(int[] inputArray, int? searchKey, int min, int max)
        {
            if (!searchKey.HasValue)
                throw new ArgumentNullException("searchKey", "Search Key is empty");

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchKey == inputArray[mid])
                {
                    return ++mid;
                }
                else if (searchKey < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }

        public object BinarySearchRecursive(int[] inputArray, int? searchKey, int min, int max)
        {
            if (min > max)
            {
                return "Nil";
            }
            else
            {
                int mid = (min + max) / 2;
                if (searchKey == inputArray[mid])
                {
                    return ++mid;
                }
                else if (searchKey < inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, searchKey, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, searchKey, mid + 1, max);
                }
            }
        }
    }
}
