using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysAndRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //reversed
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            var reversed=daysOfWeek.Reverse().ToArray();

            foreach(string day in reversed)
                Console.WriteLine(day);
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Sorting");
            Console.WriteLine("==========================");

            //sorting
            Array.Sort(daysOfWeek);
            foreach(string day in daysOfWeek)
                Console.WriteLine(day);

            //Comparing
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Comparing");
            Console.WriteLine("==========================");
            var comparer = new StringLengthComparer();
            Array.Sort(daysOfWeek, comparer);

            foreach (string day in daysOfWeek)
                Console.WriteLine(day);

            //Finding an Element
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Finding an Element");
            Console.WriteLine("==========================");
            int indexOfTuesday = Array.IndexOf(daysOfWeek, "Tuesday");
            Console.WriteLine(indexOfTuesday);
            Console.WriteLine();

            int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            Console.WriteLine(indexOfW); ;
            Console.WriteLine(daysOfWeek[indexOfW]);
            Console.WriteLine();

            string[] allWith6Chars = Array.FindAll(daysOfWeek, x => x.Length == 6);

            foreach(string item in allWith6Chars)
                Console.WriteLine(item);

            //Binary Searching
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Binary Searching");
            Console.WriteLine("==========================");

            string[] sortedDays = {

                "Friday",
                "Monday",
                "Saturday",
                "Sunday",
                "Thursday",
                "Tuesday",
                "Wednesday"
            };

            int indexOfSun = Array.BinarySearch(sortedDays, "Sunday");
            Console.WriteLine("Index is "+indexOfSun);


            Console.ReadKey();


        }
    }

    public class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
