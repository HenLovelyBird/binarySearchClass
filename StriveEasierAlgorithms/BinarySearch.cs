using System;
namespace StriveEasierAlgorithms
{
    public class BinarySearcher
    {
        public static Search(List<int> collectionToSearchIn{int[] arr, key});
        {
                int[] collection = { 5, 8, 9, 11, 12, 13, 15, 18, 19, 24, 25, 27, 29, 34, 35, 39 }; 

                for (int i = 0; i < collection.Length; i++)

                {
                    Console.Write("{0} ", collection[i]);
                }
                    Console.WriteLine();

                Console.Write("Enter a value to search for in the collection: ");
                int searchKey = int.Parse(Console.ReadLine());

                int mid;
                int maxNum = collection.Length;
                int minNum = 0;

                while (minNum <= maxnum)
                {
                    mid= (maxNum + minNum) / 2;
                    if (collection[mid] == searchKey)
                    {
                        Console.WriteLine("\nElement {0} was found at position {1} in the collection!", searchKey, mid);
                        break;
                    }
                    else if (collection[mid] > searchKey)
                    {
                        maxNum = mid - 1;
                    }
                    else if (collection[mid] < searchKey)
                    {
                        minNum = mid + 1;
                    }
                    else
                    {
                        Console.WriteLine("The value does not exist");
                        break;
                    }
                }

                Console.ReadLine();
            }


      