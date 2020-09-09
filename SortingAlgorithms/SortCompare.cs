using SortingAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithms
{
    public class SortCompare
    {

        private static double Time(string alg, IComparable[] a)
        {
            Stopwatch timer = new Stopwatch();

            if (alg.ToLower().Equals("selection"))
            {
                var newSort = new Selection();
                timer.Start();
                newSort.Sort(a);
                timer.Stop();
            }
            else if (alg.ToLower().Equals("insertion"))
            {
                var newSort = new Insertion();
                timer.Start();
                newSort.Sort(a);
                timer.Stop();
            }
            else if (alg.ToLower().Equals("bubble"))
            {
                var newSort = new Bubble();
                timer.Start();
                newSort.Sort(a);
                timer.Stop();
            }
            else if (alg.ToLower().Equals("shell"))
            {
                var newSort = new Shell();
                timer.Start();
                newSort.Sort(a);
                timer.Stop();

            }
            else if (alg.ToLower().Equals("merge"))
            {
                var newSort = new Merge();
                timer.Start();
                newSort.Sort(a);
                timer.Stop();
            }
            else if (alg.ToLower().Equals("quick"))
            {
                var newSort = new Quick();
                timer.Start();
                newSort.Sort(a);
                timer.Stop();
            }
            else
            {
                return 0;
            
            }

           // timer.Stop();

            return timer.Elapsed.TotalMilliseconds;


        }

        //private static Stopwatch GetTime(Selection newSort, Stopwatch timer)
        //{
            

        //    return timer;
        //}

        public static double TimeRandomInput(string alg, int length)
        {
            Random r = new Random();

            IComparable[] arr = new IComparable[length];
            //var str = "QWERTYUIOPLKJHGFDSAZXCVBNMzxcvbnmlkjhgfdsaqwertyuiop";

            for (int j = 0; j < length; j++)
            {
                //arr[j] = int.Parse(Console.ReadLine());
                arr[j] = r.Next(100);
            }

            double time = Time(alg, arr);

            return time;
        }




    }
}
