using System;

namespace task_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            ((IPrinter)week).Print();

            ArrayOD a = new ArrayOD(3);
            ((IArray)a).Init();
            ((IArray)a).Avg();
            ((IArray)a).Show();

            ArrayTD b = new ArrayTD(3, 3);
            ((IArray)b).Init();
            ((IArray)b).Avg();
            ((IArray)b).Show();

            Console.ReadKey();
        }
    }
}
