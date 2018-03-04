using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Month
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public int DayCount { get; set; }

        public Month(string name, int index, int dayCount)
        {
            Name = name;
            Index = index;
            DayCount = dayCount;
        }
    }
}
