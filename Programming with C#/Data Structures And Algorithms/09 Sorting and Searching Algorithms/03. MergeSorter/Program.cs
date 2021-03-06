﻿namespace _03.MergeSorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var numbers = new List<int>() { 5, 2, 16, 65, 34, 94, 94, 23, 17, 84, 66 };
            var sorter = new MergeSorter();
            sorter.Sort(numbers);
            Console.WriteLine(String.Join(", ", numbers));
        }
    }

    public class MergeSorter
    {
        public void Sort(IList<int> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null!");
            }

            var arr = collection.ToArray();
            MergeSort(arr, new int[collection.Count], 0, collection.Count - 1);
            // Copy the sorted array back to the collection
            for (int i = 0; i < collection.Count; i++)
                collection[i] = arr[i];
        }

        private void MergeSort(int[] arr, int[] temp, int left, int right)
        {
            // Base case. A list of zero or one elements is sorted, by definition.
            if (right <= left) return;

            // Recursively split into two halves
            int mid = (right + left) / 2;
            MergeSort(arr, temp, left, mid);
            MergeSort(arr, temp, mid + 1, right);

            // Merge the two sorted halves
            int i, j;
            for (i = mid + 1; i > left; i--)
                temp[i - 1] = arr[i - 1];
            for (j = mid; j < right; j++)
                temp[right + mid - j] = arr[j + 1];
            for (int k = left; k <= right; k++)
                arr[k] = (temp[i].CompareTo(temp[j]) < 0) ? temp[i++] : temp[j--];
        }
    }
}
