﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#random1->start--Remove Duplicates from Sorted Array");
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            Remove_Duplicates_from_Sorted_Array random1 = new Remove_Duplicates_from_Sorted_Array(nums);
            Console.WriteLine("#random1->end--Remove Duplicates from Sorted Array");







            Console.ReadKey();
        }
    }
}