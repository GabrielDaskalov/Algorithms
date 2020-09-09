using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Selection
    {
        // worst case: N^2 comparisons and N swaps 
        // best case: N^2 comparisons and N swaps
        // average case: N^2 comparisons and N swaps

        //vzimame element i = 0 v 1vi for-cikul, vuv 2ri for-cikul sravnqvame stoinostta mu s ostanalite elementi i namirame elementa nai-malkata stoinost
        //elementa s nai-malka stoinost zaema poziciqta na element i

        // Useful if you are sorting on Flash memory, for example, because writes reduce the lifespan of Flash memory.
        //


        public Selection()
        {
        
        }
        // 22 21 23 20 24
        public void Sort(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                IComparable itemToCheck = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (IsLess(itemToCheck, arr[j]))
                    {
                        min = j;
                        itemToCheck = arr[j];
                    }

                }

                Exchange(arr, i, min);

            }

        }

        private bool IsLess(IComparable w, IComparable v)
        {
            return w.CompareTo(v) > 0;
        
        }

        private void Exchange(IComparable[] arr, int i, int j)
        {
            IComparable t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        
        }

        public bool IsSorted(IComparable[] arr)
        {

            for (int i = 1; i < arr.Length; i++)
            {
               
                if(IsLess(arr[i-1], arr[i]))
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
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        
        }
       
    }
}
