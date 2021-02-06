using System;
using System.IO;
using System.Linq;


namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Date Formating");
            Console.WriteLine("2. Pi Formating");
            Console.WriteLine("Press any other key to exit");
            string resp = Console.ReadLine();

            if (resp == "1"){

                DateTime today = DateTime.Now;
                //1.January 22, 2019
                Console.WriteLine($"1. {today:MMMM} {today:dd}, {today:yyyy}");

                //2.2019.01.22
                Console.WriteLine($"2. {today:yyyy}.{today:MM}.{today:dd}");

                //3.Day 22 of January, 2019
                Console.WriteLine($"3. Day {today:dd} of {today:MMMM}, {today:yyyy}");

                //4.Year: 2019, Month: 01, Day: 22
                Console.WriteLine($"4. Year:{today:yyyy}, Month:{today:MM}, Day:{today:dd}");

                //5.            Tuesday (10 spaces)
                Console.WriteLine($"5. {today, 10:dddd}");

                //6.     11:01 PM             Tuesday (10 spaces between)
                Console.WriteLine($"6. {today, 10:t}{today, 10:dddd}");

                //7.h:11, m:01, s:27
                Console.WriteLine($"7. h:{today:hh},m:{today:mm},s:{today:ss}");

                //8.2019.01.22.11.01.27
                Console.WriteLine($"8. {today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");
            
            }
            else if (resp == "2"){

                double pi = 3.14159265359;
                //1. Output as currency
                Console.WriteLine("1. {0:c2}", pi);

                //2. Output as right-aligned (10 spaces), number with 3 decimal places
                Console.WriteLine("2. {0, 10:n3}", pi); 
            

            }
        
           
        
        }
    }
}
