using System;

class Solution
{
    public static void decentNumber(int n)
    {
        // Here i am looking for the maximum number of 5's needed
        int maxOfFives = n;

        // Then i decrease maxOfFives  until it is divisible by 3
        while (maxOfFives % 3 != 0)
        {
            maxOfFives -= 5;
        }

        // Now here if the number of 5's is negative or zero, then a decent number is not possible
        if (maxOfFives < 0)
        {
            Console.WriteLine("-1");
        }
        else
        {
            //or else i print the decent number with maxFives 5's and (n - maxFives) 3's
            Console.WriteLine(new string('5', maxOfFives) + new string('3', n - maxOfFives));
        }
    }

    public static void Main(String[] args)
    {

        decentNumber(20);
        decentNumber(4);
        decentNumber(5);
        decentNumber(11);
    }
}

