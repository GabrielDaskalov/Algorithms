using SortingAlgorithms.Algorithms;
using SortingAlgorithms.Drawings;
using System;
using System.Linq;

namespace SortingAlgorithms
{
    public class Program
    {
        public static void Main()
        {
            IComparable[] array = new IComparable[] { 9, 3, 7, 13, 14, 10, 15, 12, 17, 0, 4, 6 };

            //int length = int.Parse(Console.ReadLine());
            //Random r = new Random();

            //IComparable[] array = new IComparable[length];

            //for strings
            //for (int i = 0; i < array.Length; i++)
            //    {
            //        array[i] = Console.ReadLine();
            //    }

            //for numbers

            //for (int i = 0; i < array.Length; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //        //array[i] = r.Next(100);

            //    }

            //--------------------------------------------------------
            //Selection Sort

            //Selection newSort = new Selection();

            //newSort.Sort(array);

            //newSort.Show(array);
            //Console.WriteLine(newSort.IsSorted(array));


            //---------------------------------------------------------
            //Insertion Sort

            //Insertion newSort = new Insertion();

            //Console.WriteLine(Insertion.IsSorted(array));
            //newSort.Sort(array);
            //Console.WriteLine(Insertion.IsSorted(array));
            //newSort.Show(array);

            //===========================================================
            //Bubble Sort

            //Bubble newSort = new Bubble();
            //PrintArray(array);
            //Console.WriteLine(Bubble.IsSorted(array));
            //newSort.Sort(array);
            //newSort.Show(array);
            //Console.WriteLine(Bubble.IsSorted(array));


            //-------------------------------------------------------------
            //Shellsort

            //Shell newSort = new Shell();
            //PrintArray(array);
            //Console.WriteLine(newSort.IsSorted(array));
            //newSort.Sort(array);
            //newSort.Show(array);
            //Console.WriteLine(newSort.IsSorted(array));

            //--------------------------------------------------------------
            //MergeSort

            //Merge newSort = new Merge();
            //PrintArray(array);
            //Console.WriteLine(newSort.IsSorted(array));
            //newSort.Sort(array);
            //newSort.Show(array);
            //Console.WriteLine(newSort.IsSorted(array));

            //-----------------------------------------------------------------
            //QuickSort

            //Quick newSort = new Quick();
            //PrintArray(array);
            //Console.WriteLine(newSort.IsSorted(array));
            //newSort.Sort(array);
            //newSort.Show(array);
            //Console.WriteLine(newSort.IsSorted(array));

            //-------------------------------------------------------------------------
            //HeapSort

            Heap newSort = new Heap();
            PrintArray(array);
            Console.WriteLine(newSort.IsSorted(array));
            newSort.Sort(array);
            newSort.Show(array);
            Console.WriteLine(newSort.IsSorted(array));



            //---------------COMPARE ALGORITHMS------------------
            //var firstAlg = Console.ReadLine();
            //var secondAlg = Console.ReadLine();

            //int length = int.Parse(Console.ReadLine());


            //double firstTime = SortCompare.TimeRandomInput(firstAlg, length);
            //double secondTime = SortCompare.TimeRandomInput(secondAlg, length);


            //if (firstTime < secondTime)
            //{
            //    Console.WriteLine($"For {length} random elements {firstAlg} ({firstTime}) is {secondTime / firstTime:F3} times faster than {secondAlg} ({secondTime})");


            //}
            //else if (secondTime < firstTime)
            //{
            //    Console.WriteLine($"For {length} random elements {secondAlg} ({secondTime}) is {firstTime / secondTime:F1} times faster than {firstAlg} ({firstTime})");

            //}


        }

        private static void PrintArray(IComparable[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }

       
    }
}
