using System;
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
            CustomArray<int> arr = new CustomArray<int>(5);
            Console.WriteLine(arr.Length);

        }
    }
}
