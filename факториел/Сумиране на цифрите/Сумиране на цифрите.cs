using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумиране_на_цифрите
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            int e, h;
            int d,s ;
            
            var sum = 0;
            h = n / 1000;
            s= n % 1000 / 100;
            d= n % 100/10;
            e = n % 10;
            do
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            while (n > 0);
           
             Console.WriteLine("h=" + h);
           Console.WriteLine("s=" + s); 
           Console.WriteLine("d=" + d);
            Console.WriteLine("e=" + e);



        }
    }
}
