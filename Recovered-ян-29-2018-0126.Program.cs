
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            decimal studioPrice = 0m;
            decimal doublePrice = 0m;
            decimal suitePrice = 0m;
            int nightCountOfstudio = nightCount;
            if ((month == "September" || month =="Octomber") && nightCount > 7)
            {
                nightCountOfstudio--;
            }

            if (month == "May" || month == "October")
            {
                doublePrice = 65m * nightCount;
                suitePrice = 75m * nightCount;
                if (nightCount >7)
                {
                    studioPrice = (50m * 0.95m) * nightCountOfstudio;
                }
                else if (nightCount < 7)
                {
                    studioPrice = 50m * nightCount;
                }
                
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60m * nightCount;
                suitePrice = 82m * nightCount;
                if (nightCount > 14)
                {
                    doublePrice = (72m * 0.90m)* nightCount;
                }
                else
                {
                    doublePrice = 72m * nightCount;
                }
            }
            else if (month == "July"|| month == "August" || month == "December")
            {
                suitePrice = 89m * nightCount;
                doublePrice = 77m * nightCount;
                if (nightCount > 14)
                {
                    suitePrice = (89m * 0.85m) * nightCount;
                }
                else
                {
                    suitePrice = 89m * nightCount;
                }
            }


            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
