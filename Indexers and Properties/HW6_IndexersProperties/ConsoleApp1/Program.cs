using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        /*
            1.	Создать индексатор для одномерного массива 
            который при установке значения будет возводить 
            в квадрат передаваемое значение переменной и 
            устанавливать его для указанного индекса. При 
            получении элемента массива по индексу будет 
            возвращаться его текущее значение. 
        */
        static void Main(string[] args)
        {
            RangeOfArray rangeOfArray = new RangeOfArray();
            for (int i = 0; i < 10; i++)
            {
                rangeOfArray[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                WriteLine("{0} = {1}", i, rangeOfArray[i]);
            }
            ReadLine();
        }
    }
}
