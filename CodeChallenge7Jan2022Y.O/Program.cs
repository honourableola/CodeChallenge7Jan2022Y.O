using System;

namespace CodeChallenge7Jan2022Y.O
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pizza1 = { 1, 2, 3, 4, 5, 6 };
            int[] pizza2 = { 7, 9, 3, 4, 5, 6 };
            int result = SharePizza(pizza1);
            Console.WriteLine(result); 
        }

        public static int SharePizza(int[] slices)
        {
            int maxPick = 0;
            int pick = 0;
            for (int i = 0; i < slices.Length; i++)
            {
                if (i < slices.Length - 2)
                {
                    pick = slices[i] + slices[i + 2];
                }

                if (i == slices.Length - 2)
                {
                    pick = slices[slices.Length - 2] + slices[0];
                }

                if (i == slices.Length - 1)
                {
                    pick = slices[slices.Length - 1] + slices[1];
                }

                if (pick > maxPick)
                {
                    maxPick = pick;
                }

            }
            return maxPick;
        }

    }
}
