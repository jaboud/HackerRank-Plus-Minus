using System;

namespace HackerRank_Plus_Minus
{
    class Program
    {
        static void PlusMinus(int[] arr)
        {

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
