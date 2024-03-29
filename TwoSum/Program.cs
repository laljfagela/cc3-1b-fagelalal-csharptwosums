﻿using System;
using System.Collections.Generic;

namespace TwoSums
{
    public static class Program
    {
        public static int[] TwoSumsSorting(int[] nums, int target)
        {
            int arrayLength = nums.Length;

            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }

            for (int i = 0; i < arrayLength; i++)
            {
                for(int j = i + 1; j < arrayLength; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Two Sums sorting (User Input)");
            Console.WriteLine("PS. Input numbers separated by space, DO NOT add commas or other additional characters.");
            Console.Write("Input numbers: ");

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Input target: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int[] result = TwoSumsSorting(nums, target);    
            if (result.Length == 2)
            { 
                Console.WriteLine("Result: " + "[" + result[0] + "," + result[1] + "]");    
            }
            else
            {
                Console.WriteLine("No two sum solution");
            }
        }
    }
}
