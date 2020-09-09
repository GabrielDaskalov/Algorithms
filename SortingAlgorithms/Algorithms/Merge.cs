using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    public class Merge : IMethods
    {
        //best case: n*log(n)
        //worst case: n*log(n)
        //average case: n*log(n)
        //razdelqi i vladei (izpolzvame rekursiq)
        //ima nqkolko vida implementacii na merge sort, nie izpolzvame top-down implementation
        public Merge()
        {

        }


        public void Sort(IComparable[] arr)
        {
            int n = arr.Length;

            if (n < 2) return;

            int mid = n / 2;

            IComparable[] leftArray = new IComparable[mid];
            IComparable[] rightArray = new IComparable[n - mid];

            for (int i = 0; i < mid; i++)
            {
                leftArray[i] = arr[i];

            }

            for (int j = mid; j < n; j++)
            {
                rightArray[j - mid] = arr[j];
            }

            Sort(leftArray);
            Sort(rightArray);
            MergeArrays(arr, leftArray, rightArray);


        }


        public static void MergeArrays(IComparable[] a, IComparable[] leftArr, IComparable[] rightArr)
        {
            int nL = leftArr.Length;
            int nR = rightArr.Length;

            int k = 0; // unpicked position for a (big arr)
            int i = 0; // unpicked position for left arr
            int j = 0; // unpicked position for right arr


            while ((i < nL) && (j < nR))
            {
                if (IsLess(rightArr[j], leftArr[i]))
                {
                    a[k] = rightArr[j];
                    j++;

                }
                else
                {
                    a[k] = leftArr[i];
                    i++;
                }

                k++;

            }

            while (i < nL)
            {
                a[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < nR)
            {
                a[k] = rightArr[j];
                j++;
                k++;

            }

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
