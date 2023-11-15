using System;

class MissingNumberSolution
{
    public static int MissingNumber(int[] nums)
    {
        int n = nums.Length;

        int expectedSum = (n * (n + 1)) / 2;
        int actualSum = 0;
        foreach (int num in nums)
        {
            actualSum += num;
        }
        var missingNum = expectedSum - actualSum;

        return missingNum;
    }

    // The main method where the program starts execution
    static void Main()
    {
        
        int[] nums1 = { 3, 0, 1 };
        Console.WriteLine("Missing Num is: " + MissingNumber(nums1));

       
        int[] nums2 = { 0, 1 };
        Console.WriteLine("Missing Num is: " + MissingNumber(nums2));

        // Example 3
        int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        Console.WriteLine("Missing Num is: " + MissingNumber(nums3));
    }
}
