using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamoloGep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az első számot: ");
            float num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a második számot: ");
            float num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a műveletet(+ - * /): ");
            string muv = Console.ReadLine();
            
            switch (muv)
            {
                case "+": Console.WriteLine("Az összeg "+(num1+num2));
                    break;
                case "-": Console.WriteLine("A különbség "+(num1-num2));
                    break;
                case "*": Console.WriteLine("A szorzat " + (num1 * num2));
                    break;
                case "/": 
                    Console.WriteLine(Convert.ToDouble(num1 / num2));
                    break;
                default: Console.WriteLine("Rossz művelet");
                    break;
            }


            Console.ReadLine();
        }
    }
}
