using System;
using System.Collections.Generic;
using System.Text;

namespace StriveEasierAlgorithms
{
    class BubbleSorter
    {
        public void Sort(List<int> listToSort, bool ascending)
        {
            // If the user didn't provide any useful input, we simply use our default collection
            if ((listToSort == null)||(listToSort.Count == 0))
                listToSort = new List<int>(10) { 9, 5, 8, 11, 15, 12, 18, 13 };

            // We keep track if any swap happened during the last cycle: if not,
            // it means that the collection is now ordered and we can return
            bool hasSortHappenedInThisLastCycle;

            do
            {
                hasSortHappenedInThisLastCycle = false;
                for (int i = 0; i < listToSort.Count - 1; i++)
                {
                    // Let's check every single pair of subsequent integers in the collection
                    int leftNumber = listToSort[i];
                    int rightNumber = listToSort[i + 1];

                    if ((ascending && (leftNumber <= rightNumber))
                        ||
                        (!ascending && (leftNumber >= rightNumber)))
                        continue;

                    // If they're not in the order we want, we swap their positions
                    listToSort[i] = rightNumber;
                    listToSort[i + 1] = leftNumber;

                    hasSortHappenedInThisLastCycle = true;
                }

            } while (hasSortHappenedInThisLastCycle);
        }
    }
}
