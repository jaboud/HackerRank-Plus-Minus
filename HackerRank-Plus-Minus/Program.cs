using System;

namespace HackerRank_Plus_Minus
{
    class Program
    {
        static void PlusMinus(int[] arr)
        {
            //Decimal variables so we can store the amount of postives, negatives or zeros
            decimal positives = 0;
            decimal negatives = 0;
            decimal zeros = 0;
            //Length of array variable so we dont't have to repeatedly computing it.
            decimal length = arr.Length;

            //For loop to check if the element is positive, negative or zero.
            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0) negatives++;
                else if (arr[i] > 0) positives++;
                else zeros++;
            } 
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            PlusMinus(arr);
        }
    }
}
