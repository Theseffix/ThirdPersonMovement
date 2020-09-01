using System;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett decimaltal eller ett heltal: ");
            string number = Console.ReadLine();
            float numberF = 0;
            bool j = true;

            while (j)
            {
                try
                {
                    numberF = float.Parse(number);
                    j = false;
                }
                catch
                {
                    Console.WriteLine("Måste vara decimaltal eller heltal: ");
                    number = Console.ReadLine();
                }
            }

            Console.WriteLine(numberF + " meter = " + (numberF * 1.0936133) + " yards.");
            Console.WriteLine(numberF + " kg = " + (numberF * 2.2046226218) + " lbs.");
            Console.WriteLine(numberF + " degrees Celsius = " + ((numberF * 1.8) + 32) + " degrees fahrenheit.");
            Console.WriteLine(numberF + " kilowatt = " + (numberF * 1.34102209) + " hästkrafter.");
            Console.ReadLine();

        }
    }
}
