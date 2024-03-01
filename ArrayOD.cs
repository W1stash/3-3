using System;

namespace task_3_3
{
    class ArrayOD : IArray
    {
        public Random rnd = new Random();
        public int length { get; set; }
        public int columns { get; set; }

        protected int[] array;

        public ArrayOD(int a)
        {
            array = new int[a];
            a = length;
        }

        public int this[int i]
        {
            set
            {
                array[i] = value;
            }
            get
            {
                return array[i];
            }
        }

        void IArray.Init()
        {
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-150, 150);
                Console.WriteLine(i);
            }
            Console.WriteLine("Массив инициализирован");
        }

        void IArray.Avg()
        {
            double sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Среднее значение в массиве: {sum / length}");
        }

        void IArray.Show()
        {
            Console.WriteLine("Ваш массив:");
            foreach (int el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
