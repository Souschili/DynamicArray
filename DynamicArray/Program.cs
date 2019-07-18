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
            int[] data = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            CustomArray<int> arr = new CustomArray<int>(data);
           //arr.AddElem(15);
            Console.WriteLine($"Длина массива до {arr.Length}");
            //arr.DisplayData();
            //Console.WriteLine(arr[15]);
            arr.AddByIndex(2, 777);
            arr.AddByIndex(0, 555);
            arr.DisplayData();
            Console.WriteLine($"Длина массива после {arr.Length}");
            arr.RemoveAt(0);
            arr.RemoveAt(2);
            arr.DisplayData();
            Console.WriteLine($"Длина массива после {arr.Length}");

        }
    }
}
