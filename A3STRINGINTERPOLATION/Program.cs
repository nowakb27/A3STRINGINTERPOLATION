using System;
namespace A3STRINGINTERPOLATION {
    class Program
    {
        static void Main(string[] args)
        {
            var CURRENTDATE = DateTime.Now;
            var PI = Math.PI;
            Console.WriteLine("");
            Console.WriteLine("From today’s date");
            Console.WriteLine("");
            Console.WriteLine($"1.{CURRENTDATE.ToString("MMMM dd, yyyy")}");
            Console.WriteLine($"2.{CURRENTDATE.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"3.Day {CURRENTDATE.ToString("dd")} of {CURRENTDATE.ToString("MMMM, yyyy")}");
            Console.WriteLine($"4.Year: {CURRENTDATE.ToString("yyyy")}, Month:{CURRENTDATE.ToString("MM")}, Day: {CURRENTDATE.ToString("dd")}");
            Console.WriteLine($"5.{CURRENTDATE.ToString("dddd"),10}");
            Console.WriteLine($"6.{CURRENTDATE.ToString("hh:mm tt"),10} {CURRENTDATE.ToString("dddd"),10}");
            Console.WriteLine($"7.h:{CURRENTDATE.ToString("hh")}, m:{CURRENTDATE.ToString("mm")}, s:{CURRENTDATE.ToString("ss")}");
            Console.WriteLine($"8.{CURRENTDATE.ToString("yyyy.MM.dd.hh.mm.ss")}");
            Console.WriteLine("");
            Console.WriteLine("If you have PI (3.1415)");
            Console.WriteLine("");
            Console.WriteLine($"1. Output as currency: {PI.ToString("C")}");
            Console.WriteLine($"2. Output as right-aligned (10 spaces), number with 3 decimal places: {PI.ToString("#.000"),10}");

        }
    }
}