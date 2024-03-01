using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_3
{
    class Week : IPrinter
    {
        void IPrinter.Print()
        {
            Console.WriteLine("Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье");
        }
    }
}
