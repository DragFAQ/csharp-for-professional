using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthsCollection months = new MonthsCollection();

            Console.WriteLine("Months with 30 days:");
            ShowMonthsByDays(months, 30);
            Console.WriteLine("Month with index 8:");
            ShowMonthByIndex(months, 8);
            Console.WriteLine("Months with index 5:");
            ShowMonthByIndex(months, 5);
        }

        private static void ShowMonthsByDays(MonthsCollection months, int dayCount)
        {
            foreach(Month m in months)
            {
                if (m.DayCount == dayCount)
                {
                    Console.WriteLine(m.Name);
                }
            }
        }

        private static void ShowMonthByIndex(MonthsCollection months, int index)
        {
            foreach (Month m in months)
            {
                if (m.Index == index)
                {
                    Console.WriteLine(m.Name);
                    break;
                }
            }
        }
    }
}
