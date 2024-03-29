﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class CustomArray <T>
    {
        public int Length { get; private set; } // длина ....в принципе ненужен 
        private T [] storage;     // статический массив для хранения данных
        //индексатор перегрузка []
        public T this [int i]
        {
            get { return storage[i];}
            set { storage[i] = value; }
        }

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

        /// <summary>
        /// Добавить элемент в конец массива
        /// </summary>
        /// <param name="element">Элемент типа Т</param>
        public void AddElem(T element)
        {
            //Временный массив
            T [] localData = this.storage;

            this.storage = new T[++this.Length];
            //копирование данных из временых в новый
            for (int i = 0; i < localData.Length; i++)
            {
                storage[i] = localData[i];
            }
            this.storage[Length-1] = element;
        }


        /// <summary>
        /// Добавить элемент на позицию,в данном случае элемент втискивается между соседними 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="elem"></param>
        public void AddByIndex(int index,T elem)
        {
            

            if(index<0 || index>Length)
            {
                Console.WriteLine($"{index} неверный индекс");
            }
            else
            {
                T[] localData = this.storage;
                Length++;
                this.storage = new T[Length];

                for(int i=0,j=0;i<Length;i++,j++)
                {
                    if(index==i)
                    {
                        this.storage[i] =elem;
                        --j;
                        continue;
                    }

                    this.storage[i]=localData[j];

                }
            }
        }

        /// <summary>
        /// Удалить элемент с указаной позиции
        /// </summary>
        /// <param name="index">Номер позиции</param>
        public void RemoveAt(int index)
        {
            if (index < 0 || index > Length)
            {
                Console.WriteLine($"{index} неверный индекс");
            }
            else
            {
                T[] localData = this.storage;
                Length--;
                this.storage = new T[Length];
                for (int i = 0,j=0; i < Length; )
                {
                    if(j==index)
                    {
                        ++j;
                        continue;
                    }
                    this.storage[i++] = localData[j++];
                }
            }

        }
        

        /// <summary>
        /// Вывод на консоль
        /// </summary>
        public void DisplayData()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write(storage[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
