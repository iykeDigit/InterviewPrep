using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = MergeArrays(new int[] { -3,0,1,4 }, new int[] { -9,-1,2,3,18 }, 4, 5);
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
            int j = 0;
            int i = 0;
            int count = 0;
            while(i < arr1Size && j < arr2Size) 
            { //1,3,4,5   2,6,7,8
                if(arr1[i] < arr2[j]) 
                {
                    arr3[count] = arr1[i];
                    i++;
                    count++;
                }
                else 
                {
                    arr3[count] = arr2[j];
                    j++;
                    count++;
                }
            }

            if(i < arr1Size) 
            {
                
                for(int x = i; x < arr3.Length; x++) 
                {
                    arr3[count] = arr1[x];
                    count++;
                }
            }

            if (j < arr2Size)
            {
                
                for (int x = j; x < arr2Size; x++)
                {
                    arr3[count] = arr2[x];
                    count++;
                }
            }

            return arr3;








        }
    }
}
