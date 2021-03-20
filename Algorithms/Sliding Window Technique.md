The sliding window algorithm can be used to solve problems that involve linear sequences, such as arrays. 
A window is a contiguous sequence which is part of an array. 
As the name suggests, the window is slid over the array. Some operations are performed on elements within this window, and then the window is slid further.

**Example**
We are given an array of size NN; we need to calculate the maximum sum of KK consecutive elements.

The most obvious solution would be to find all possible blocks of KK elements, and pick the one with the largest sum.

The optimal solution, however, uses the sliding window algorithm. Here is how it works:

    Add the first KK elements together, and store the sum in the variable currentSum. 
    Since this is the first sum, it is also the current maximum, so store it in variable maximumSum as well.
    Since the window size is KK, we slide the window one place to the right, and compute the sum of the elements in the window.
    If the currentSum is larger than the maximumSum, then update the maximum and repeat step 2. This is illustrated below:

**Implementation**
    
        // C# code for O(n) solution for finding
    // maximum sum of a subarray of size k
    using System;

    class GFG {

        // Returns maximum sum in
        // a subarray of size k.
        static int maxSum(int[] arr, int n, int k)
        {

            // n must be greater
            if (n < k) {
                Console.WriteLine("Invalid");
                return -1;
            }

            // Compute sum of first window of size k
            int max_sum = 0;
            for (int i = 0; i < k; i++)
                max_sum += arr[i];

            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of
            // current window.
            int window_sum = max_sum;
            for (int i = k; i < n; i++) {
                window_sum += arr[i] - arr[i - k];
                max_sum = Math.Max(max_sum, window_sum);
            }

            return max_sum;
        }

        // Driver code
        public static void Main()
        {
            int[] arr = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
            int k = 4;
            int n = arr.Length;
            Console.WriteLine(maxSum(arr, n, k));
        }
    }

