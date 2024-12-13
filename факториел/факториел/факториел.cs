using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace факториел
{
    internal class факториел
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            var n= int.Parse(Console.ReadLine());
            var P = 1;
            while (n > 1) 
            { 
                P = P*n;
                n--;
            }
            Console.WriteLine("P= " + P);



        }
    }
}
