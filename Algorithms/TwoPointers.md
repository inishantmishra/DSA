**Algorithm**

Since the array is already sorted, we can keep two pointers ii and jj, where ii is the slow-runner while jj is the fast-runner. As long as nums[i] = nums[j]nums[i]=nums[j], we increment jj to skip the duplicate.

When we encounter nums[j] \neq nums[i]nums[j] =nums[i], the duplicate run has ended so we must copy its value to nums[i + 1]nums[i+1]. ii is then incremented and we repeat the same process again until jj reaches the end of array.

      public int removeDuplicates(int[] nums) {
          if (nums.length == 0) return 0;
          int i = 0;
          for (int j = 1; j < nums.length; j++) {
              if (nums[j] != nums[i]) {
                  i++;
                  nums[i] = nums[j];
              }
          }
          return i + 1;
      }

**Complexity analysis**
Time complextiy : O(n)O(n). Assume that nn is the length of array. Each of ii and jj traverses at most nn steps.
Space complexity : O(1)O(1).


**Two Pointers Technique**

Two pointers is really an easy and effective technique which is typically used for searching pairs in a sorted array.
Given a sorted array A (sorted in ascending order), having N integers, find if there exists any pair of elements (A[i], A[j]) such that their sum is equal to X.

Two pointer technique based solution to find
if there is a pair in A[0..N-1] with a given sum.
    public static int isPairSum(int A[], int N, int X)
    {
        // represents first pointer
        int i = 0;
 
        // represents second pointer
        int j = N - 1;
 
        while (i < j) {
 
            // If we find a pair
            if (A[i] + A[j] == X)
                return 1;
 
            // If sum of elements at current
            // pointers is less, we move towards
            // higher values by doing i++
            else if (A[i] + A[j] < X)
                i++;
 
            // If sum of elements at current
            // pointers is more, we move towards
            // lower values by doing j--
            else
                j--;
        }
        return 0;
    }
