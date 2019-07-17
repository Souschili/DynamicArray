﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class CustomArray <T>
    {
        public int Length { get;} // длина
        private T [] storage;     // статический массив для хранения данных

        public CustomArray()
        {
            this.Length = 0;
            this.storage = new T[Length];
        }


    }
}