using System.Collections.Generic;
using System;
using System.Linq;

namespace data_structure.Sort
{
    public class QuickSort
    {
        public int[] Sort(int[] list)
        {
            if (list.Length == 0)
                return Array.Empty<int>();

            int length = list.Length;
            int[] newArr = new int[length];
            Array.Copy(list, newArr, length);

            Sort(newArr, 0, length - 1);

            return newArr;
        }

        private void Sort(int[] arr, int init, int end)
        {
            if (init < end)
            {
                int partIndex = Partition(arr, init, end);
                Sort(arr, init, partIndex - 1);
                Sort(arr, partIndex + 1, end);
            }
        }

        private int Partition(int[] arr, int init, int end)
        {
            int pivot = arr[end];
            int lowIndex = init - 1;
            int temp;
            for (int i = init; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    lowIndex++;

                    temp = arr[lowIndex];
                    arr[lowIndex] = arr[i];
                    arr[i] = temp;
                }
            }

            temp = arr[lowIndex + 1];
            arr[lowIndex + 1] = arr[end];
            arr[end] = temp;
            return lowIndex + 1;
        }
    }
}