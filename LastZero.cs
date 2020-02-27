using System;

namespace LastZero
{
    class LastZero
    {
        static void Main(string[] args)
{
    int[] inputArray = new int[] { 0, 1, 0 };
    int result = lastZero(inputArray);
    Console.WriteLine("Expected result is 2, actual result is " + result);
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
}

// If x==null throw NullPointerException
// else return the index of the last 0 in x.
// If 0 does not occur in x, return -1.

// Added a NullPointer Exception 
// Changed the value of integer i to be equal to 2 to match anticipated result. 
static int lastZero(int[] x)
{
    if(x == null)
    {
        throw new NullReferenceException("Null");
    }
    for (int i = x.Length -1; i>=0; i--)
    {
        if (x[i] == 0)
        {
            return i;
        }
    }
    return -1;
}
    }
}
