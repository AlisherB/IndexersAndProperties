using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RangeOfArray
    {
        private int beginIndex;
        private int endIndex;

        public int BeginIndex { get; set; }
        public int EndIndex { get; set; }

        public RangeOfArray()
        {
            beginIndex = 0;
            endIndex = 0;
        }

        public RangeOfArray(int beginIndex, int endIndex)
        {
            if (beginIndex < endIndex)
            {
                this.beginIndex = beginIndex;
                this.endIndex = endIndex;
            }
            else if (beginIndex > endIndex)
            {
                this.beginIndex = endIndex;
                this.endIndex = beginIndex;
            }  
        }
    }
}
