using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class LongestIncreasingSubsequence
    {
        //public static long longestIncreasingSubsequence(List<long> arr)
        //{
        //    // Add boundary case, when array n is zero
        //    // Depend on smart polongers
        //    long n =arr.Count;
        //    long[] tailIndices = new long[n];

        //    // Initialized with 0
        //    for (long i = 0; i < n; i++)
        //        tailIndices[i] = 0;

        //    long[] prevIndices = new long[n];

        //    // initialized with -1
        //    for (long i = 0; i < n; i++)
        //        prevIndices[i] = -1;

        //    // it will always polong to empty
        //    // location
        //    long len = 1;

        //    for (long i = 1; i < n; i++)
        //    {
        //        if (arr[i] < arr[tailIndices[0]])

        //            // new smallest value
        //            tailIndices[0] = i;

        //        else if (arr[i] > arr[tailIndices[len - 1]])
        //        {

        //            // arr[i] wants to extend
        //            // largest subsequence
        //            prevIndices[i] = tailIndices[len - 1];
        //            tailIndices[len++] = i;
        //        }
        //        else
        //        {

        //            // arr[i] wants to be a potential
        //            // condidate of future subsequence
        //            // It will replace ceil value in
        //            // tailIndices
        //            long pos = GetCeilIndex(arr,
        //                                   tailIndices, -1, len - 1, arr[i]);

        //            prevIndices[i] = tailIndices[pos - 1];
        //            tailIndices[pos] = i;
        //        }
        //    }

        //    Console.Write("LIS of given input");

        //    for (long i = tailIndices[len - 1]; i >= 0;
        //         i = prevIndices[i])
        //        Console.Write(arr[i] + " ");

        //    Console.WriteLine();

        //    return len;
        //}


        //static long GetCeilIndex(List<long> arr, long[] T, long l,
        //                   long r, long key)
        //{

        //    while (r - l > 1)
        //    {
        //        long m = l + (r - l) / 2;

        //        if (arr[T[m]] >= key)
        //            r = m;
        //        else
        //            l = m;
        //    }

        //    return r;
        //}

        //public static int longestIncreasingSubsequence(List<long> arr)
        //{
        //    int n = arr.Count;
        //    int[] tailIndices = new int[n];
        //    int[] prevIndices = new int[n];
        //    int len = 1;
        //    tailIndices[0] = 0;
        //    prevIndices[0] = -1;

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (arr[i] < arr[tailIndices[0]])
        //        {
        //            tailIndices[0] = i;
        //        }
        //        else if (arr[i] > arr[tailIndices[len - 1]])
        //        {
        //            prevIndices[i] = tailIndices[len - 1];
        //            tailIndices[len++] = i;
        //        }
        //        else
        //        {
        //            int pos = GetCeilIndex(arr, tailIndices, -1, len - 1, arr[i]);
        //            prevIndices[i] = tailIndices[pos - 1];
        //            tailIndices[pos] = i;
        //        }
        //    }

        //    Console.WriteLine("Longest increasing subsequence:");
        //    for (int i = tailIndices[len - 1]; i >= 0; i = prevIndices[i])
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.WriteLine();

        //    return len;
        //}

        //static int GetCeilIndex(List<long> arr, int[] T, int l, int r, long key)
        //{
        //    while (r - l > 1)
        //    {
        //        int m = l + (r - l) / 2;
        //        if (arr[T[m]] >= key)
        //        {
        //            r = m;
        //        }
        //        else
        //        {
        //            l = m;
        //        }
        //    }

        //    return r;
        //}


        //public static long longestIncreasingSubsequence(List<long> arr)
        //{
        //    long n = arr.Count;
        //    long[] L = new long[n];
        //    long max = 1;

        //    // Initialize all LIS values to 1
        //    for (long i = 0; i < n; i++)
        //    {
        //        L[i] = 1;
        //    }

        //    // Compute LIS values from left to right
        //    for (long i = 1; i < n; i++)
        //    {
        //        for (long j = 0; j < i; j++)
        //        {
        //            if (arr[j] < arr[ i])
        //            {
        //                L[i] = Math.Max(L[i], L[j] + 1);
        //            }
        //        }
        //        max = Math.Max(max, L[i]);
        //    }

        //    return max;
        //}

        public static int longestIncreasingSubsequence(List<long> arr)
        {
            int n = arr.Count;
            List<long> tailTable = new List<long>(n);
            int len = 1;

            tailTable.Add(arr[0]);
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < tailTable[0])
                {
                    // new smallest value
                    tailTable[0] = arr[i];
                }
                else if (arr[i] > tailTable[len - 1])
                {
                    // arr[i] wants to extend largest subsequence
                    tailTable.Add(arr[i]);
                    len++;
                }
                else
                {
                    // arr[i] wants to be a potential candidate
                    // of future subsequence
                    // it will replace ceil value in tailTable
                    int pos = BinarySearch(tailTable, 0, len - 1, arr[i]);
                    tailTable[pos] = arr[i];
                }
            }

            return len;
        }
        static int BinarySearch(List<long> arr, int left, int right, long key)
        {
            while (right - left > 1)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] >= key)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            return right;
        }
    }
}
