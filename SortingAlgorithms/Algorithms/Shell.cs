using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    public class Shell : IMethods
    {
        // za shellsort izpolzvame gaps, za da mojem da razdelim dadeniq array na otdelni sub-array i chrez insertion sort gi sortirame.
        //Izpolzvat se sequences za izchislqvane na gaps - Knuth Sequence, Shell Sequence i tn. V nashiq sluchai izpolzvame sequence na Knuth (3^k - 1)/2, zashtoto ima po-dobri pokazateli ot Shell A
        //worst case: n^ 3/2 za Knuth, i n^2 po princip
        //average case: 
        //best case: n*log(n)

        public void Sort(IComparable[] arr)
        {
            int length = arr.Length;
            //knuth formula (izpolzvame za da opredelim sublistovete)
            int h = 1;

            while(h < length / 3)
            {
                h = 3 * h + 1;
            
            }

            while (h >= 1)
            {
                for (int i = h; i < length; i++)
                {
                    for (int j = i; j >= h && IsLess(arr[j], arr[j-h]); j-=h)
                    {
                        Exchange(arr, j, j-h);
                    }


                }

                h = h / 3;
            }

        }

        private bool IsLess(IComparable w, IComparable v)
        {
            return w.CompareTo(v) < 0;

        }

        private void Exchange(IComparable[] arr, int i, int j)
        {
            IComparable t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;

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
