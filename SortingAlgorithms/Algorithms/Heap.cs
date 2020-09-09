using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    public class Heap : IMethods
    {
        // Best case: n* log(n)
        // Worst case: n* log(n)
        // Average case: n* log(n)
        // q. Dadeniq masiv trqbva da go podredim kato heap. Zatova izpolzvame heapify metod. Posle sortirame otnovo izpolzvaiki heapify i iztrivane na element.

        
        public void Sort(IComparable[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // One by one extract an element from heap 
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                Exchange(arr, 0, i);

                // call max heapify on the reduced heap 
                Heapify(arr, i, 0);
            }

        }

        private static void Heapify(IComparable[] arr, int n, int i)
        {
            //i the index of the root, n the size of the heap

            int largest = i; // parent root
            int l = 2 * i + 1; // left root
            int r = 2 * i + 2; // right root

            if (IsLess(l ,n) && IsBigger(arr[l], arr[largest]))
            {
                largest = l;
            
            }
            
            if (IsLess(r,n) && IsBigger(arr[r], arr[largest]))
            {

                largest = r;
            
            }
        
            if(largest != i)
            {
                Exchange(arr, i, largest);

                Heapify(arr, n, largest);
            }
        
        }

        private static void Exchange(IComparable[] arr, int i, int j)
        {
            IComparable t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;

        }
        
        private static bool IsBigger(IComparable v, IComparable w)
        {

            return v.CompareTo(w) > 0;
        }

        private static bool IsLess(IComparable v, IComparable w)
        {

            return v.CompareTo(w) < 0;


        }


        public bool IsSorted(IComparable[] arr)
        {
            bool isSorted = true;

            for (int i = 1; i < arr.Length; i++)
            {

                if (!IsLess(arr[i - 1], arr[i]))
                {
                    isSorted = false;
                }

            }

            return isSorted;
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
