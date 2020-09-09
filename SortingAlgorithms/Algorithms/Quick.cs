using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    public class Quick : IMethods
    {
        // best case : n * log(n)
        // average case : n * log(n)
        // worst case : n^2
        // memory : O(log(n))
        // izbirame element PIVOT (p) (obiknovenno tova e posledniqt) i suzdavame dva sub-arrays: 1viqt s elementite po-malki ot p, a 2riqt s elementite po-golemi ot p
        // Sled tova sortirame dvata sub-arrays rekursivno po sushtiq nachin (opredelqiki PIVOT)
        //A good implementation uses O(log N) auxiliary storage in the form of stack space for recursion.


        public Quick()
        {

        }

        public void Sort(IComparable[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        
        }


        private static void Sort(IComparable[] arr, int start, int end)
        {

            if(start < end)
            {

                int pi = Partition(arr, start, end);

                Sort(arr, start, pi - 1);
                Sort(arr, pi + 1, end);
            
            
            }


        }

        private static int Partition(IComparable[] arr, int start, int end)
        {
            IComparable pivot = arr[end];
            int i = start - 1;


            for (int j = start; j <= end - 1; j++)
            {
                if (IsLess(arr[j], pivot))
                {
                    i++;
                    Exchange(arr, i, j);

                }

            }

            Exchange(arr, i + 1, end);

            return (i + 1);
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

        public void Show(IComparable[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();
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

    }
}
