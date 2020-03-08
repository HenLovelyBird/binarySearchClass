using System;
using System.Collections.Generic;

namespace StriveEasierAlgorithms
{
    public class BinarySearcher
    {
        public int Search(List<int> collectionToSearchIn, int numToSearch)

        {
            if ((collectionToSearchIn == null) || (collectionToSearchIn.Count == 0))
                collectionToSearchIn = new List<int>()
                { 5, 8, 9, 11, 12, 13, 15, 18, 19, 24, 25, 27, 29, 34, 35, 39 };

            int begNumToMidPoints = 0;
            int minNum = 0;
            int maxNum = collectionToSearchIn.Count;
            int medNums;

            while(true)
            {
                // Let' adjust current mid point
                medNums = (maxNum - minNum) / 2 + minNum;

                // Increase iterations number
                begNumToMidPoints++;

                // Get the number you0re currently look at
                int currentlyInspectedNumber = collectionToSearchIn[medNums];

                // Check if equals, greater or lower than
                if (numToSearch == currentlyInspectedNumber)
                {
                    Console.WriteLine("heh, Must be luck or total Nerdpants!");
                    return medNums + 1;
                }

                else if (numToSearch > currentlyInspectedNumber)

                {
                    Console.WriteLine("Should be Higher, dunkus");
                    minNum = medNums;
                }

                else

                {
                    Console.WriteLine("Should be Lower, durnkus");
                    maxNum = medNums;
                }

                Console.WriteLine($"MidPoints: {begNumToMidPoints}");
                Console.WriteLine(string.Join("|", collectionToSearchIn));
                Console.WriteLine(begNumToMidPoints);

            }

        }
    }
}

