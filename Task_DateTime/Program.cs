using System;
using System.Globalization;

namespace Task_DateTime
{
    internal class Program
    {
        static void Task1()
        {
            Console.Write("Enter the date in the given format --> dd_MM_yyyy: ");
            string stringDate = Console.ReadLine();

            try
            {
                DateTime date = DateTime.ParseExact(stringDate, "dd_MM_yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("Entered date: " + date.ToString("dd/MMMM/yyyy"));
            }

            catch(FormatException ex)
            {
                Console.WriteLine($"{ex.GetType()}: {ex.Message}");
            }
        }

        static void Task2()
        {
            Console.Write("Enter the date in the given format --> dd/MM/yyyy: ");
            string stringDate = Console.ReadLine();

            DateTime date = DateTime.ParseExact(stringDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            TimeSpan timespan = new TimeSpan(days: 30, hours: 6, minutes: 17, seconds: 0);

            date = date.Add(timespan);

            Console.Write("Final date: " + date.ToString("dd/MM/yyyy hh:mm:ss"));
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
        }
    }
}
