using System;
using System.Collections.Generic;

namespace TwoSums
{
    public static class Program
    {
        public static int[] TwoSumsSorting(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = target - nums[i];

                if (map.TryGetValue(num, out int index))
                {
                    return new int[] { i, index };
                }
                else
                {
                    map[nums[i]] = i;
                }

            }
            return new int[2];

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Two Sums sorting (User Input)");
            Console.WriteLine("PS. Input numbers separated by space, DO NOT add commas or other additional characters.");
            Console.Write("Input numbers: ");

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Input target: ");
            int target = Convert.ToInt32(Console.ReadLine());

            try
            {
                int[] result = TwoSumsSorting(nums, target);
                Console.WriteLine("Result: " + "[" + result[1] + "," + result[0] + "]");    
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
