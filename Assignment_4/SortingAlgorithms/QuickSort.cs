using Assignment_4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.SortingAlgorithms
{
    class QuickSort
    {

        /* This function takes last element as pivot, 
        places the pivot element at its correct 
        position in sorted array, and places all 
        smaller (smaller than pivot) to left of 
        pivot and all greater elements to right 
        of pivot */
      public  static int partitionAsc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Color < pivot.Color)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        public static int partitionDesc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Color > pivot.Color)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void ColorAsc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionAsc(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ColorAsc(arr, low, pi - 1);
                ColorAsc(arr, pi + 1, high);
            }
        }

        public static void ColorDesc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionDesc(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ColorDesc(arr, low, pi - 1);
                ColorDesc(arr, pi + 1, high);
            }
        }

        // A utility function to print array of size n 
        public static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        //======================================== Size sorting ===============================
        public static int partitionSizeAsc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Size < pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        public static int partitionSizeDesc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Size > pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void SizeAsc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionSizeAsc(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                SizeAsc(arr, low, pi - 1);
                SizeAsc(arr, pi + 1, high);
            }
        }

        public static void SizeDesc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionSizeDesc(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
               SizeDesc(arr, low, pi - 1);
                SizeDesc(arr, pi + 1, high);
            }
        }

        //======================================== Fabric sorting ===============================
        public static int partitionFabricAsc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Fabric < pivot.Fabric)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        public static int partitionFabricDesc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Fabric > pivot.Fabric)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void FabricAsc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionFabricAsc(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                FabricAsc(arr, low, pi - 1);
                FabricAsc(arr, pi + 1, high);
            }
        }

        public static void FabricDesc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionFabricDesc(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                FabricDesc(arr, low, pi - 1);
                FabricDesc(arr, pi + 1, high);
            }
        }


    }

    
}
