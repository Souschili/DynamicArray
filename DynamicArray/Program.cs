﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            CustomArray<int> arr = new CustomArray<int>(data);
            Console.WriteLine(arr.Length);

        }
    }
}
