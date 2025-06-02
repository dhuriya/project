using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.DSA
{
    class ClsArray
    {
        //--------------------
        // What is Array?
        //-------------------
        // Array is a  liner data structure where all elements are arranged sequentially. It is a collection of element of same data type stored at contiguous memory locations.

        // Tyeps of Arrays
        // * On the basis of size
        //   1 Fixed size
        //   2 Dynamic Size
        // * On the basis of Dimensions
        //   1 One Dimensional Array
        //   2 Multi Dimensional Array
        

        // ------------------------
        // Operations of Array
        //---------------------------
        // 1 Array Traversal :
        public void ArrayTraversal()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
        //------------------------
        // 2 Inserton in Array.
        //-----------------------
        public void ArrayInsertion()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int x = 8;
            int pos = 4;
            for (int i = arr.Length - 1; i >= pos;i-- )
            {
                //arr[i + 1] = arr[i];
                arr[pos] = x;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
        //------------------
        // 3 Deletion in Array
        //-------------------
        public void ArrayDeletion()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int x = 4;
            int pos = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            // find element
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    pos = i;
                }
            }
            if (pos > -1)
            {
                for (int j = pos; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            
        }
        //-------------------------
        //Advantages of Array
        //-------------------------
        //Arrays allow random access to elements. This makes accessing elements by position faster.
        //Arrays have better cache locality which makes a pretty big difference in performance.
        //Arrays represent multiple data items of the same type using a single name.
        //Arrays are used to implement the other data structures like linked lists, stacks, queues, trees, graphs, etc.

        //-------------------------
        //Disadvantages of Array
        //-------------------------
        //As arrays have a fixed size, once the memory is allocated to them, it cannot be increased or decreased, making it impossible to store extra data if required. An array of fixed size is referred to as a static array. 
        //Allocating less memory than required to an array leads to loss of data.
        //An array is homogeneous in nature so, a single array cannot store values of different data types. 
        //Arrays store data in contiguous memory locations, which makes deletion and insertion very difficult to implement. This problem is overcome by implementing linked lists, which allow elements to be accessed sequentially.  

        //Difference between array and structure?
        //The structure can contain variables of different types but an array only contains variables of the same type. 

        // What is a Subarray ?
        // A Subarray is a contiguous part of array . Subarray is an array that is inside another array.
        // In general for an array of size n, there are n*(n+1)/2 non-empty subarrays.
        // EX [1, 2, 3, 4] = (1), (2), (3), (4), (1,2), (2,3), (3,4), (1,2,3), (2,3,4), and (1,2,3,4)

        //What is a Subsequence?
        //A subsequence is a sequence that can be derived from another sequence by removing zero or more elements, without changing the order of the remaining elements.
        //More generally, we can say that for a sequence of size n, we can have (2n – 1) non-empty sub-sequences in total.

        //What is a Subset?
        //If a Set has all its elements belonging to other sets, this set will be known as a subset of the other set.
        //A Subset is denoted as “⊆“. If set A is a subset of set B, it is represented as A ⊆ B.
        //For example, Let Set_A = {m, n, o, p, q}, Set_ B = {k, l, m, n, o, p, q, r}
        //Then, A ⊆ B.

        //------------------------
        // Searching in Array
        //------------------------
        //Searching is one of the most common operations performed in an array. Array searching can be defined as the operation of finding a particular element or a group of elements in the array.
        //There are several searching algorithms. The most commonly used among them are:
        // * Linear Search
        // * Binary Search
        // * Ternary Search

        // Linear Search -:
        //Linear Search is defined as a sequential search algorithm that starts at one end and goes through each element of a list until the desired element or group of elements is found.
        // This has a time complexity of O(N) where 'N' is the length of the array

        // Binary Search -:
        //Binary Search is a searching algorithm used in a sorted array. In this algorithm, 
        //the element is found by repeatedly dividing the search interval in half and deciding 
        //the next interval to find the element. This searching algorithm has a time complexity of O(log 2 N) where 'N' is the length of the array. 

        // Ternary Search -:
        //Ternary search is a divide and conquer algorithm that can be used to find an element in an 
        //array. It is similar to binary search where we divide the array into two parts but in this 
        //algorithm, we divide the given array into three parts and determine which has the key 
        //(searched element). This algorithm also has the constraint that the array must be sorted. 
        //The time complexity for this algorithm is O(log 3 N) where 'N' is the size of the array.

        // -----------------
        // Array Reverse -: 
        //-----------------
        // 1 [Naive Approach] Using a temporary array – O(n) Time and O(n) Space

        public void ReverseArray1()
        {
            int[] arr = { 1, 4, 3, 2, 6, 5 };
            int n = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            int[] temp = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[n - i - 1];
            }
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i]);
            }
        }
        //[Expected Approach – 1] Using Two Pointers – O(n) Time and O(1) Space
        //The idea is to maintain two pointers: left and right, such that left points at the beginning of the array and right points to the end of the array.
        public void ReverseArray2()
        {
            int[] arr = { 1, 4, 3, 2, 6, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            
            int left = 0;
            int right = arr.Length-1;
            // Iterate till left is less than right
            while(left<right)
            {
                // swap the elements at left and right position
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();   
        }
        // 3 [Expected Approach – 2] By Swapping Elements – O(n) Time and O(1) Space
        //The idea is to iterate over the first half of the array and swap each element with its corresponding element from the end. So, while iterating over the first half, any element at index i is swapped with the element at index (n – i – 1).
        public void ReverseArray3()
        {
            int[] arr = { 1, 4, 3, 2, 6, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            int n = arr.Length - 1;
            // // Iterate over the first half and for every index i,
            //// swap arr[i] with arr[n - i - 1]
            for (int i = 0; i < n / 2;i++ )
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
        // 4 [Alternate Approach] Using Recursion – O(n) Time and O(n) Space
        // *  Swap the first and last element. 
        // * Recursively call the function with the remaining subarray. 
        public void ReverseArray4()
        {
            int[] arr = { 1, 4, 3, 2, 6, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            int n = arr.Length - 1;
            reverseArrayRec(arr, 0, n - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        public void reverseArrayRec(int[] arr, int l, int r)
        {
            if (l >= r)
            {
                return;
            }
            int temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;
            reverseArrayRec(arr, l + 1, r - 1);
        }
        // 5 Using Inbuilt Methods – O(n) Time and O(1) Space
        public void ReverseArray5()
        {
            int[] arr = { 1, 4, 3, 2, 6, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }

        //---------------------------------------------------
        // Rotate an Array by d – Counterclockwise or Left
        //---------------------------------------------------
        // 1  [Naive Approach] Rotate one by one – O(n * d) Time and O(1) Space

        public void RotateArray1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int d = 2;
            int n = arr.Length;
            // original array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            // repeat the rotation d times
            for (int i = 0; i < d; i++)
            {
                // left rotate the array by one position
                int first = arr[0];
                for (int j = 0; j < n - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[n - 1] = first;
            }
            // after roration
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

        }
        // 2 [Better Approach] Using Temporary Array – O(n) Time and O(n) Space
        // * Copy the last (n – d) elements of original array into the first n – d positions of temporary array.
        // * Then copy the first d elements of the original array to the end of temporary array. 
        // * Finally, copy all the elements of temporary array back into the original array.
        public void RotateArray2()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int d = 2;
            d %= arr.Length;
            int[] temp = new int[arr.Length];
            //copy last n-d elements to the front of temp
            for (int i = 0; i < arr.Length-d; i++)
            {
                temp[i] = arr[d + i];
            }
            // copy the first d elements to  the back of temp 
            for (int i = 0; i < d; i++)
            {
                temp[arr.Length - d + i] = arr[i];
            }
        }

        //3 [Expected Approach 1] Using Juggling Algorithm – O(n) Time and O(1) Space
        // The idea is to use Juggling Algorithm which is based on rotating elements in cycles. 
        // Each cycle is independent and represents a group of elements that will shift among themselves during the rotation. 
        // If the starting index of a cycle is i, then next elements of the cycle can be found at indices (i + d) % n, (i + 2d) % n, (i + 3d) % n … and so on till we return to the original index i. 
        //----------------------------
        // How many independent cycles will be there if an array of size n is rotated by d positions?
        //------------------------------------
        // If an array of size n is rotated by d places, then the number of independent cycles will be gcd(n, d). When we rotate the array,
        // the cycle increments in steps of d and terminates when we reach the starting point.
        // This means that the distance travelled in each cycle will be a multiple of n, which is defined as lcm(n, d).
        // So, number of elements in each cycle = lcm(n, d)/d. Therefore, to cover all n elements, the total number of cycles will be n/lcm(n, d) = gcd(n, d).
        public void RotateArray3()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int d = 2;
            // Handle the case where d > size of array
            d %= arr.Length;
            // Calculate the number of cycles in the rotation (GCD)
            int cycle = Gcd(arr.Length, d);
            // Process each cycle
            for (int i = 0; i < cycle; i++)
            {
                // start element of current cycle 
                int startEle = arr[i];
                // start  index of current cycle
                int currInx = i, nextIdx;
                // Rotate elements till we reach the start of cycle
                while(true){
                    nextIdx = (currInx + d) % arr.Length;
                    if (nextIdx == i)
                    {
                        break;
                    }
                    // update the next index with the current element a
                    arr[currInx] = arr[nextIdx];
                    currInx = nextIdx;
                }
                arr[currInx] = startEle;
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }

        // function to compute GCD
        static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // 4 [Expected Approach 2] Using Reversal Algorithm – O(n) Time and O(1) Space
        // The idea is based on the observation that if we left rotate the array by 
        // d positions, the last (n – d) elements will be at the front and the first d elements will be at the end.

        // Reverse the subarray containing the first d elements of the array.
        // Reverse the subarray containing the last (n – d) elements of the array.
        // Finally, reverse all the elements of the array.
        public void RotateArray4()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int d = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            // Handle the case where d > size of array
            d %= arr.Length;
            // Reverse the first d elements 
            reverse(arr, 0, d - 1);
            // Reverse the remaining n-d elements 
            reverse(arr, d, arr.Length - 1);
            // reverse the entire array
            reverse(arr, 0, arr.Length - 1);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        // Function to reverse a portion of the array
        static void reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        //---------------------------------------------------------------------
        // PRINT ARRAY AFTER IT IS RIGHT ROTATED K TIMES
        // ------------------------------------------------------------------
        // QUESTION -: Given an Array of size N and a value K, around which we need to right rotate 
        // the array. How do you quickly print the right rotated array?
        // input: Array[] = {1, 3, 5, 7, 9}, K = 2.
        // Output: 7 9 1 3 5

        // Approach 1 -:
        // * We will first take the mod of K by N (K = K % N) because, after every N rotation, the 
        //   array will become the same as the initial array. 
        // * Now, we will iterate the array from i = 0 to i = N-1 and check, 
        //   If i < K, Print the rightmost Kth element (a[N + i -K]). 
        //   Otherwise, Print the array after ‘K’ elements (a[i – K]).  
        public void RightRotate()
        {
            int []arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            int k = 2;
            // If rotation is  greater
            // than size of array
            k = k % n;
            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                    // Printing rightmost
                    // kth elements
                    Console.Write(arr[n + i - k] + "");
                }
                else
                {
                    // Prints array after 
                    // k elements
                    Console.Write(arr[i - k] + " ");
                }
            }
        }
        // -------------------
        // Method 2-:  Reversing the array
        //--------------------------------
        // The approach is simple yet optimized. The idea is to reverse the array three times.
        // time we reverse only the last k elements. Second time we will reverse first 
        // n-k(n=size of array) elements. Finally we will get our rotated array by reversing 
        // the entire array.
        public void RightRotate2()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11 };
            int n = arr.Length;
            int k = 3; // No. of rotations
            k = k % n;
            int i, j;
            // Reverse last k numbers
            for (i = n - k, j = n - 1; i < j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            // Reverse the first n-k terms
            for (i = 0, j = n - k - 1; i < j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            // Reverse the entire array
            for (i = 0, j = n - 1; i < j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            for (int t = 0; t < n; t++)
            {
                Console.Write(arr[t] + " ");
            }
        }
        //-----------------------
        // Method 3 -: Recursive Approach
        // -----------------------
        // * “rotateArray” function will take an array “arr” ,  it’s size is “n”  and the number of 
        // rotations “k” as an input.
        // * To reduce the number of rotations, we compute ‘k’ modulo ‘n’ ( k%=n) .
        // * Using the STL library’s “reverse” function, reverse the first portion of the array 
        // from the start up to the “n – k” index.
        // * Using the “reverse” function from the STL library, reverse the second part of the array 
        // from the “n – k” index to the end.
        // * To get the rotated array, reverse the entire array using the “reverse” function in the STL library.
        // * Then ,we’ll return the rotated array.
        public void RightRotate3()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int n = arr.Length;
            int k = 2;// position
            RightRoatatebyRecursiion(arr, n, k);
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void RightRoatatebyRecursiion(int[] arr, int n, int k)
        {
            if (k == 0)
            {
                return;
            }
            // Rotate the array to the right by one Position
            int temp = arr[n - 1];
            for (int i = n - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = temp;
            // Recursively rotate the remaining elements k-1
            RightRoatatebyRecursiion(arr, n, k - 1);
        }
        //-------------------------------------------------------------
        // Search , insert and delete in an unsorted array 
        // --------------------------------------------------------------
        // Search Operation
        public void SearchingInUnsortedArray()
        {
            int[] arr = { 12, 34, 10, 6, 40 };
            int key = 40;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    Console.WriteLine("Element found at position : " + i);
                }
                else
                {
                    Console.WriteLine("Element not found...........");
                }
            }
        }
        // Insert Operation
        // Insert at the end
        public void InsertEnd()
        {
            int[] arr = new int[20];
            int n = 0;
            for (int i = 0; i < 7; i++)
            {
                arr[i] = i+1;
                n++;
            }
            for (int i = 0; i <n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int key = 30;
           
            arr[n] = key;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        //--------------------------
        // Insert at any position
        //--------------------------
        public void DisplayInsertElements()
        {
            int[] arr = new int[20];
            arr[0] = 2;
            arr[1] = 4;
            arr[2] = 1;
            arr[3] = 8;
            arr[4] = 5;
            int x = 10;
            int n = 5;
            int pos = 2;
            Console.Write("Before Insertion: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            InsertElement(arr, n, x, pos);
            n += 1;
            Console.Write("\n\nAfter Insertion: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
        static void InsertElement(int[] arr,int n , int x, int pos)
        {
            // shift elements to the right 
            // which are on the right side of pos
            for (int i = n-1; i >=pos; i--)
			{
                arr[i + 1] = arr[i];
                arr[pos] = x;
			}
        }
        //---------------------
        // Delete Operation
        //-------------------
        // 1 find element
        static int FindElement(int[] arr, int n, int key)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        // delete
        static int deleteElement(int[] arr, int n, int key)
        {
            // find position of element to be deleted
           int pos= FindElement(arr, n, key);
           int i;
           if (pos == -1)
           {
               Console.WriteLine("Element not found ");
               return n;
           }
           else
           {
               // deleting element
               for (i = pos; i < n-1; i++)
               {
                   arr[i] = arr[i + 1];
               }
               return n - 1;
           }
            
        }
        // display array after deletion
        public void DisplayArrayAfterDeletion()
        {
            int i;
            int[] arr = { 10, 50, 30, 40, 20 };

            int n = arr.Length;
            int key = 30;

            Console.Write("Array before deletion ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // Function call
            n = deleteElement(arr, n, key);

            Console.Write("Array after deletion ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        //----------------------------------------------------------------------
        //Search, Insert, and Delete in an Sorted Array | Array Operations
        // ----------------------------------------------------------------------
        // How to Search in a Sorted Array?

        // Display Binary Search 
        public void DisplayBinarySearch()
        {
            int[] arr = new int[] { 5, 6, 7, 8, 9, 10 };
            int n, key;
            n = arr.Length;
            key = 10;
            Console.WriteLine("Index :" + BinarySearch(arr, 0, n - 1, key));
        }
        // Binary Search
        static int BinarySearch(int[] arr,int low,int high,int key)
        {
            if (high < low)
            {
                return -1;
            } 
            int mid = (low + high) / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            else if (key > arr[mid])
            {
                return BinarySearch(arr, (mid + 1), high, key);
            }
            else
            {
                return BinarySearch(arr, low, (mid - 1), key);
            }
        }

        //------------------------
        // Two sum of array
        //------------------------
        public void GetTwoSumOfArray()
        {
            int[] nums = {2,7,11,15 };
            int target = 9;
            for (int i = 0; i < nums.Length;i++ )
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine(i + " ," + j + " = " + target);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(i + " ," + j + " = " + nums[i] + nums[j]);
                    }
                }
            }
        }
        public void SubarrayWithSum()
        {
            int [] arr = { 15,2,4,8,9,5,10,23};
        }
    }
}
