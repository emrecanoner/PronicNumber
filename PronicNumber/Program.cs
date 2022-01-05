using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PronicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,count=0;
            Console.Write("Input Number: ");
            num = Int16.Parse(Console.ReadLine());
            for(int i =0; i<=num; i++)
            {
                if (i * (i + 1) == num)
                {
                    Console.WriteLine(num + " is a Pronic Number");
                    count++;
                    break;
                }
            }
            if(count != 1)
            {
                Console.WriteLine(num + " is not a Pronic Number");
            }
            Console.Read();
        }
    }
}
