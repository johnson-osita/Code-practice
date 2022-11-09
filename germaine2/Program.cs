using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace germaine2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter : year");
            string year = Console.ReadLine();

            Console.WriteLine("Enter : month");
            string month = Console.ReadLine();

            Console.WriteLine("Enter : day");
            string day = Console.ReadLine();

            string date = $"{year}, {month}, {int.Parse(day)+7}".ToString();


            DateTime value;
            if (DateTime.TryParse(date, out value))
            {
                DateTime date2 = DateTime.Parse(date);
                Console.WriteLine(date2.ToString("F"));
            }
            else
            {
                Console.WriteLine("you entered an invalid date");
            }

        }
    }
}
