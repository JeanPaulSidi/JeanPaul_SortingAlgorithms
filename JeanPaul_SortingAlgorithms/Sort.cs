using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanPaul_SortingAlgorithms
{
    public static class Sort
    {
        public static int[] BubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;

            for (i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                {
                    break;
                }

            }

            return arr;
        }

        public static int[] Insertinsort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }

            return arr;
        }

        //Merge Sort Algorithm

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
            {
                L[i] = arr[l + i];
            }

            for (j = 0; j < n2; ++j)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;
            int k = l;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public static int[] MergeSortAlgorithm(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                MergeSortAlgorithm(arr, l, m);
                MergeSortAlgorithm(arr, m + 1, r);

                Merge(arr, l, m, r);
            }

            return arr;
        }

        //Quick Sort Algorithm

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        public static int[] QuickSortAlgorithm(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSortAlgorithm(arr, low, pi - 1);
                QuickSortAlgorithm(arr, pi + 1, high);
            }

            return arr;
        }


    }
}
