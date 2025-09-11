namespace Classwork_2;

class Program
{
    static void Main(string[] args)
    {
        // int[] array = [1, 2, 3, 8, 12, 13, 17, 23, 45, 60];
        // var numToFind = 45;
        //
        // var min = 0;
        // var max = array.Length - 1;
        // var mid = 0;
        // var numToCheck = 0;
        //
        // while (numToCheck != numToFind)
        // {
        //     mid = (min + max) / 2;
        //     numToCheck = array[mid];
        //
        //     if (numToCheck < numToFind) min = mid;
        // }
        //
        // Console.WriteLine(numToCheck);
        // Console.WriteLine(mid);
        
        Console.WriteLine(Factorial(5));
        
    }

    static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be non-negative");
        if (n <= 1) return 1; // Base case: 0! = 1, 1! = 1
        checked
        {
            return n * Factorial(n - 1); // Recursive case
        }
    }

}