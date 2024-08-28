using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age+" éves vagy");
            Console.WriteLine("10 év mulva "+(age+10)+" leszel");
            Console.Write("Add meg az első számot: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("A két szám külömbségének maradéka: ");
            Console.WriteLine(num1%num2);*/
            Console.Write("Add meg a számodat: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 2;
            if (num1 % num2==0) {
                Console.WriteLine("A szám páros.");
            }
            else{
                Console.WriteLine("A szám páratlan.");
            }

            Console.ReadLine();

        }
    }
}
