using System;
namespace OppgaveKapittelTreSolvingProblemsWithArrays
{
    public class Sorter
    {
        public static bool IsSorted(int[] array, int numberOfElements)
        {
            /*
            * 3-3 Write a bool function that is passed an array and the number of elements in
            * that array and determines whether the data in the array is sorted. This should
            * require only one pass!
            */

            int start = 0;
            int end = numberOfElements - 1;
            for (int i = start + 1; i <= end; i++)
            {
                for (int j = i; j > start && array[j - 1] > array[j]; j--)
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;

                    return false;
                }
            }
            return true;
        
        }
    }
}

