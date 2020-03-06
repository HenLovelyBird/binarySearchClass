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
            int medNums = collectionToSearchIn.Count;

            while(true)
            {
                if (numToSearch == collectionToSearchIn[medNums - 1])
                {
                    Console.WriteLine("Wow! You got it, Babe!");

                }

                else if (numToSearch > collectionToSearchIn[medNums - 1])

                {
                    Console.WriteLine("Should be Higher");
                    begNumToMidPoints++;
                    minNum = medNums;
                    medNums = (maxNum - minNum) / 2;
                }

                else if (numToSearch < collectionToSearchIn[medNums - 1])

                {
                    Console.WriteLine("Should be Lower");
                    begNumToMidPoints++;
                    maxNum = medNums;
                    medNums = (maxNum - minNum) / 2;
                }

                Console.WriteLine("$Total MidPoints: { begNumToMidPoints}");
                Console.WriteLine(string.Join("|", collectionToSearchIn));
                Console.WriteLine(begNumToMidPoints);

            }

        }
    }
}

