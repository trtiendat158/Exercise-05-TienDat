using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('A');
            char c = 'A';
            Console.WriteLine(c);

            // he co so 10
            short s = 65;
            Console.WriteLine((char)s);

            c = (char)s;
            Console.WriteLine(c);

            //he co so 16
            short z = 0x41;
            Console.WriteLine((char)z);

            c = (char)z;
            Console.WriteLine(c);
            c++;
            Console.WriteLine(c);
        }
    }
}
