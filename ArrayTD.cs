using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_3
{
    class ArrayTD
    {
        public Random rnd = new Random();
        public int length { get; set; }
        public int columns { get; set; }

        protected int[,] array;

        public ArrayTD(int a, int b)
        {
            array = new int[a, b];
            length = a;
            columns = b;
        }

        public int this[int i, int b]
        {
            set
            {
                array[i, b] = value;
            }
            get
            {
                return array[i, b];
            }
        }

        void IArray.Init()
        {
            for (int p = 0; p < length; p++)
            {
                for (int i = 0; i < columns; i++)
                {
                    array[p, i] = rnd.Next(-150, 150);
                }
            }
            Console.WriteLine("Двумерный массив инициализирован");
        }

        void IArray.Show()
        {
            Console.WriteLine("Ваш массив:");
            for (int p = 0; p < length; p++)
            {
                for (int i = 0; i < columns; i++)
                {
                    Console.Write($"{array[p, i]}   ");
                }
                Console.WriteLine();
            }
        }

        void IArray.Avg()
        {
            double sum = 0;
            for (int p = 0; p < length; p++)
            {
                for (int i = 0; i < columns; i++)
                {
                    sum += array[p, i];
                }
            }
            Console.WriteLine($"Максимальное число в вашем массиве: {sum / length}");
        }
    }
}
