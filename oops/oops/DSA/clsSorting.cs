using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.DSA
{
    class clsSorting
    {
        //--------------------------
        // Sorting
        //--------------------------
        //Sorting an array means arranging the elements of the array in a certain order. Generally 
        //sorting in an array is done to arrange the elements in increasing or decreasing order.

        // ---------------------
        // Bubble Sort
        //---------------------
        // Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the 
        // adjacent elements if they are in the wrong order. This algorithm is not suitable for 
        // large data sets as its average and worst-case time complexity are quite high.

        // Exmple of Bubble sort
        private void bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for ( i = 0; i < n - 1; i++)
            {
                swapped = false;
                for ( j = 0; j < n - i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                // if no two elements were swapped by inner loop, then break
                if (swapped == false)
                {
                    break;
                }
            }
        }
        // Display Bubble sort
        public void PrintBubbleSort()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            bubbleSort(arr, n);

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        // Advantages of Bubble sort
        // * Bubble sort is easy to understand and implement.
        // * It does not require any additional memory space.
        // * It is a stable sorting algorithm, meaning that elements
        //   with the same key value maintain their relative order 
        //  int the sorted output.

        // Disadvantages of Bubble sort
        // * Bubble sort has a time complexity of O(n2) which makes 
        //  it very slow for large data sets.
        // * Bubble sort is a comparison-based sorting algorithm, 
        // which means that it requires a comparison operator to 
        // determine the relative order of elements in the input data
        // set . it can limit the efficiency of the algorithm in
        // certain cases.



    }
}
