using System;
using System.Text;

namespace Time_Conversion
{
    class Program
    {
        static string timeConversion(string date)
        {
            StringBuilder sb = new StringBuilder();
            string hour = date.Substring(0, 2);
            if (date.Contains("AM"))
            {
                date = date.Remove(date.Length - 2);
                if(hour == "12")
                {
                    return date.Replace(hour, "00");
                } 
                else
                {
                    return date;
                }
            }
            else
            {
                date = date.Remove(date.Length - 2);
                if (hour == "12")
                {
                    return date;
                }
                else
                {
                    string newHour = (int.Parse(hour) + 12).ToString();
                    return date.Replace(hour, newHour);
                }
            }
        }
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            Console.WriteLine(timeConversion(date));
        }
    }
}
