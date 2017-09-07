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
         Напишите класс RangeOfArray, который позволяет работать с массивом такого типа, 
         в котором индексный диапазон устанавливается пользователем. Например, в диапазоне от 6 до 10, или от –9 до 15.
         Подсказка: В классе можно объявить две переменных, которые будут содержать верхний и нижний индекс допустимого диапазона.
        */
        static void Main(string[] args)
        {
            RangeOfArray rangeOfArray = new RangeOfArray();
            Write("Введите начало диапазона: ");
            rangeOfArray.BeginIndex = Convert.ToInt32(ReadLine());
            Write("Введите конец диапазона: ");
            rangeOfArray.EndIndex = Convert.ToInt32(ReadLine());

            for(int i = rangeOfArray.BeginIndex; i < rangeOfArray.EndIndex; i++)
            {
                WriteLine("a[" + i + "]");
            }
            ReadLine();
        }
    }
}
