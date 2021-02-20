//Count Primes
//Count the number of prime numbers less than a non-negative number, n.
/*
Example 1:

Input: n = 10
Output: 4
Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
*/

public class Solution {
    public int CountPrimes(int n) {
        int count=0;
        for(int i=0;i<n; i++)
        {
           if(i>1&&IsPrime(i))
               count= count+1;
        }
        return count;
    }
    
    public bool IsPrime(int num)
    {
        for (int i=2; i<=Math.Sqrt(num);i++)
        {
            if(num%i==0) return false;
        }
        return true;
    }
}