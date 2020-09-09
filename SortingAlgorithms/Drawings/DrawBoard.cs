using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Drawings
{
    public class DrawBoard
    {
        public DrawBoard(/*int x,*/ /*int y*/)
        {
           // this.X = x;
            //this.Y = y;

        }

      //  protected int X { get; set; } // arr.length

      // protected int Y { get; set; } // the sum of the biggest element

        public void Draw()
        {
            //Console.SetCursorPosition(Y, X);
            //Console.Write('-');

        }

        public void DrawAlgorithm(IComparable[] arr, int Y)
        {

            int gap = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                int tempY = Y;
                var quantity = GetQuantity(arr[j]);

                for (int i = 0; i < quantity; i++)
                {
                    try
                    {
                        Console.SetCursorPosition(gap, tempY);
                        Console.Write("\u2649");
                        tempY--;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid draw");

                    }

                    
                }

                Console.SetCursorPosition(gap,tempY);
                Console.Write(quantity);
                gap += 2;
            }

        }

        private int GetQuantity(IComparable a)
        {
            int intToCheck;
            double doubleToCheck;
            IComparable valueToReturn;

            bool successInt = Int32.TryParse(a.ToString(), out intToCheck);
            bool successDouble = Double.TryParse(a.ToString(), out doubleToCheck);

            if (successInt)
            {
                valueToReturn = intToCheck;
            }
            else if (successDouble)
            {
                valueToReturn = doubleToCheck;


            }
            else if (a.ToString().Length == 1)
            {
                char ch = char.Parse(a.ToString());
                valueToReturn = (int)(ch);


            }
            else
            {
                int sum = 0;
                string text = a.ToString();

                for (int i = 0; i < text.Length; i++)
                {
                    char ch = text[0];
                    sum += (int)(ch);

                }

                valueToReturn = sum;

            }

            int num = (int)(valueToReturn);

            return num;
        }

    }
}
