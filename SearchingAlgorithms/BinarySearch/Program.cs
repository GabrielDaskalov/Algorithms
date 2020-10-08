using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = new IComparable[] { 1.2, 2.3, 2.33, 4.5, 4.7};
            //var arr = new IComparable[] { "a", "b", "c" };
            var arr = new IComparable[] { 3, 4, 5, 6, 7 };

            //var key = double.Parse(Console.ReadLine());
            //var key = Console.ReadLine();
            var key = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearchRecursive(arr, 0, arr.Length - 1, key));
            Console.WriteLine(BinarySearchIterative(arr, key));


        }

        private static int BinarySearchRecursive(IComparable[] arr, int low, int high, IComparable key)
        {



            if (low >= high)
            {
                if (arr[low].CompareTo(key) == 0)
                {
                    return low;

                }
                else
                {
                    return -1;
                }

            }
            else
            {
                int mid = (low + high) / 2;
                if (key.CompareTo(arr[mid]) == 0)
                {
                    return mid;

                }

                if (IsLess(key, arr[mid]))
                {
                    return BinarySearchRecursive(arr, low, mid - 1, key);
                }
                else
                {
                    return BinarySearchRecursive(arr, mid + 1, high, key);
                
                }
                
            
            }
        }


        private static int BinarySearchIterative(IComparable[] arr, IComparable key)
        {
            int low = 0;
            int high = arr.Length - 1;

            int mid = (low + high) / 2;

            while (low <= high)
            {
                if (key.CompareTo(arr[mid]) == 0)
                {
                    return mid;
                }

                if (IsLess(key, arr[mid]))
                {
                    high = mid-1;

                }
                else
                {
                    low = mid+1;

                }

                mid = (low + high) / 2;


            }

            return -1;
        }

        private static bool IsLess(IComparable key, IComparable mid)
        {
            return key.CompareTo(mid) < 0;
        }
    }
}
