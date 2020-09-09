using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Insertion : IMethods
    {
        //worst case: N^2 comparisons and N^2 swaps, where n is arr.Length
        //best case: N-1 comparisons and 0 swap
        //average case: N^2/2 comparisons and N^2/2 swaps
        //efficient for partially sorted algorithms

        //vzimame element i=1 v 1vi for-cikul, sled tova vuv vtori for-cikul j=i i proverqvame dali element[j] e po-maluk ot element[j-1]
        //ako e po-maluk- razmenqme i produljavame cikula kato namalqme j s 1,  ako ne- uslovieto v cikula ne se izpulnqva i se prekratqva

        // Insertion sort is used when number of elements is small.
        //It can also be useful when input array is almost sorted, only few elements are misplaced in complete big array

        public Insertion()
        {

        
        }


        public void Sort(IComparable[] arr) 
        {
            for (int i = 1; i < arr.Length; i++)
            {

                for (int j = i; j > 0 && IsLess(arr[j], arr[j-1]); j--)
                {
                    Exchange(arr, j, j - 1);
                }

            }

        }

        private static void Exchange(IComparable[] arr, int i, int j)
        {
            IComparable t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;

        }

        private static bool IsLess(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public bool IsSorted(IComparable[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if(IsLess(arr[i], arr[i-1]))
                {
                    return false;
                
                }

            }


            return true;
        }

        public void Show(IComparable[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
     
        }
    }

      
    
}
