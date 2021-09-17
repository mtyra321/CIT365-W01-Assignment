using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string location;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your location");
            location = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your location is {location}");
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.ToShortDateString();
            Console.WriteLine(date);
            var christmas = new DateTime(dateAndTime.Year, 12, 25);
            int daysBetween = (int)((christmas - dateAndTime).TotalDays);
            Console.WriteLine($"The number of days between {date} and Christmas is {daysBetween}");


            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please enter the width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter the height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");





            Console.ReadKey();
        }
    }
}
