using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine();
            int inputPower, input;

            //Input
            Console.Write("Enter an integer: ");
            input = int.Parse(Console.ReadLine());
            
            Console.Write("Enter an power level: ");
            inputPower = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Output
            Console.Write("Number".PadRight(15));
            Console.Write("Squared".PadRight(15));
            Console.Write("Cubed".PadRight(15));
            Console.WriteLine();
            Console.Write("=======".PadRight(15) + "=======".PadRight(15) + "======".PadRight(15));
            Console.WriteLine();
            outputAll(input, inputPower);
            Console.ReadKey();
        }

        //Processing and Output
        static void outputPowers(int number, int power)
        {
            long outputNumber = number;
            outputNumber = (long)Math.Pow(number, power);

            string myString = (outputNumber.ToString());
            Console.Write(myString.PadRight(15));
        }
        //static void outputNumber(int number)
        //{
        //    outputPowers(number, 1);
        //}
        //static void outputSquared(int number)
        //{
        //    outputPowers(number, 2);
        //}
        //static void outputCubed(int number)
        //{
        //    outputPowers(number, 3);
        //}

        static void outputAll(int number, int totalPower)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int ii = 1; ii <= totalPower; ii++)
                {
                    outputPowers(i, ii);
                }
                Console.WriteLine();
            }
        }
    }
}
