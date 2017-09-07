using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RangeOfArray
    {
        int[] arr = new int[10];
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = (int)Math.Pow(value, 2);
            }
        }
    }
}
