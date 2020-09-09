using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    public class Bubble : IMethods
    {
        // worst case: N^2
        // average case: N^2/ 2
        // best case: N

        // 2 1 10 7 12
        // 1 2 10 7 12
        // 1 2 10 7 12
        // 1 2 7 10 12
        // 1 2 7 10 12

        // vzima J element (J = 0) i sravnqva go sus sledvashtiq element (ako e po-golqm - smenqt pozicii, ako ne- ostava na sushtata poziciq)
        //posle J = 1 i izpolzvame sushtata logika, za da proverim sledvashtite elementi i tn


        public Bubble()
        {
            
        
        
        }

        public void Sort(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // 1 3 2 5 6 0 -5  // ...... 6
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(IsLess(arr[j + 1], arr[j]))
                    {
                        Exchange(arr, j + 1, j);
                    
                    }

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
                if (IsLess(arr[i], arr[i - 1]))
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

