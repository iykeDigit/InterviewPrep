using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = MaxMin(new int[] { 1,2,3,4,5,6 },6);
            //6,1,5,2,4,3
            Console.WriteLine();
        }

        public static int[] RemoveEven(int[] arr, int size) 
        {
            int m = 0;
            foreach(var i in arr) 
            {
                if(i % 2 != 0) 
                {
                    arr[m] = i;
                    m++;
                }
            }

            var temp = new int[m];
            for(int x = 0; x < m; x++) 
            {
                arr[x] = temp[x];
            }

            arr = temp;
            return arr;

        }

        public static int[] MergeArrays(int[] arr1, int[] arr2, int arr1Size, int arr2Size) 
        {
            var arr3 = new int[arr1Size + arr2Size];
            int j = 0, i = 0, count = 0;
            
            while(i < arr1Size && j < arr2Size) 
            { //-3,0,1,4   -9,-1,2,3,18
                if(arr1[i] < arr2[j]) 
                {
                    arr3[count++] = arr1[i++];
                }
                else 
                {
                    arr3[count++] = arr2[j++];
                }
            }

            while(i < arr1Size) 
                arr3[count++] = arr1[i++];
                   

            while(j < arr2Size)
               arr3[count++] = arr2[j++];
                    
            return arr3;
        }

        public static int[] FindSum(int[] arr, int value, int size)
        {
            //1,4,2,5
            int[] result = new int[2];
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    Console.WriteLine(arr[i]);
                    Console.WriteLine(arr[j]);
                    Console.WriteLine();
                    if (arr[i] + arr[j] == value)
                    {
                        result[0] = arr[i];
                        result[1] = arr[j];
                        return result; // containing 2 numbers
                    }
                }
            }
            return arr;
        }

        public static int[] FindSums(int[] arr, int value, int size) 
        {
            HashSet<int> list = new HashSet<int>();
            for(int i = 0; i < arr.Length; i++) 
            {
                int diff = value - arr[i];
                if (list.Contains(diff)) 
                {
                    return new int[] { diff, arr[i] };
                }
                else 
                {
                    list.Add(arr[i]);
                }
            }

            return arr;
        }

        public static int FindFirstUnique(int[] arr, int size)
        {
            // Write your code here
            //2,4,6,7,6,2,6
            //2,2,4,6,6,6,7
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < size; i++) 
            {
                if (dict.ContainsKey(arr[i])) 
                {
                    dict[arr[i]]++;
                }

                else
                {
                    dict[arr[i]] =  0;
                }
            }

            foreach(var k in dict.Keys) 
            {
                if(dict[k] == 0) 
                {
                    return k;
                }
            }

            return -1;
        }

        public static int FindFirstUnique(int[] arr) 
        {
            bool repeated = false;

            for(int i = 0; i < arr.Length; i++) 
            {
                for(int j = 0; j < arr.Length; j++) 
                {
                    if(arr[i] == arr[j] && i != j) 
                    {
                        repeated = true;
                    }
                }

                if(repeated == false) 
                {
                    return arr[i];
                }

                repeated = false;
            }


            return -1;
        }

        public static int[] ReArrange(int[] arr, int n)
        {
            //-1,2,3,-4,-5,6
            int j = 0, temp;
            for(int i = 0; i < n; i++) 
            {
                if(arr[i] < 0) 
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
            return arr;
        }

        public static int[] MaxMin(int[] arr, int size)
        {
            // Write your code here
            int first = 0;
            int last = size - 1;
            int i = 0;
            var newArr = new int[size];
            while (first < last)
            {
                newArr[i] = arr[last];
                newArr[i + 1] = arr[first];
                i = i + 2;
                first++;
                last--;
            }

            if(size % 2 != 0)
                newArr[size - 1] = arr[first];
            arr = newArr;

            return arr;

        }
    }

}

    