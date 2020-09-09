using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Interfaces
{
    public interface IMethods
    {
        void Sort(IComparable[] arr);

        void Show(IComparable[] arr);

        bool IsSorted(IComparable[] arr);

        static void Exchange(IComparable[] arr, int i, int j)
        {
            //IComparable t = arr[i];
            //arr[i] = arr[j];
            //arr[j] = t;

        }


        static bool IsLess(IComparable v, IComparable w) => true;
       

    }
}
