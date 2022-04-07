using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allPages = int.Parse(Console.ReadLine());
            int pagesReadInOneHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int timeForReadingTheBook = allPages / pagesReadInOneHour;
            int hoursInaDay = timeForReadingTheBook / days;
            Console.WriteLine(hoursInaDay);
        }
    }
}
