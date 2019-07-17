using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class CustomArray <T>
    {
        public int Length { get;} // длина ....в принципе ненужен 
        private T [] storage;     // статический массив для хранения данных


        #region
        /// <summary>
        /// Создать объект
        /// </summary>
        public CustomArray()
        {
            this.Length = 0;
            this.storage = new T[Length];
        }

        /// <summary>
        /// Задать размер получить пустой массив
        /// </summary>
        /// <param name="size">Длина массива</param>
        public CustomArray(int size)
        {
            this.Length = size;
        }

        /// <summary>
        /// Передать массив для создания объекта класса
        /// </summary>
        /// <param name="arr">Пользовательский массив</param>
        public CustomArray(T [] arr)
        {
            this.storage = arr;
            this.Length = arr.Length;
        }
        #endregion
    }
}
