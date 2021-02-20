//How to find the number is prime or not?

//Best Method- Time Complexity- O(sqrt(n))
bool IsPrime(n)
{
  for(i=2;i<=Math.Sqrt(n);i++)
  {
    if(n%i==0) return false;
  }
  return true;
}


//Alternative Method 1- Time Complexity- O(n)
bool IsPrime(n)
{
  for(i=2;i<=n;i++)
  {
    if(n%i==0) return false;
  }
  return true;
}



//Alternative Method 2- Time Complexity- O(n)
bool IsPrime(n)
{
  for(i=2;i<=n/2;i++)
  {
    if(n%i==0) return false;
  }
  return true;
}


