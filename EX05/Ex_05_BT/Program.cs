using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05_BT
{
    class Program
    {
        static void Main(string[] args)
        {
           print_a_to_z();
           print_z_to_a();
           print_A_to_Z();
          
           Console.WriteLine("Moi nhap chu: ");
           char n =char.Parse(Console.ReadLine());
           output_code(n);
           Console.WriteLine("\nChu ban muon kiem tra la: ");
           Check(n);
           Console.WriteLine("\nChuyen doi chu :");
           Change(n);
            
           
        }

        public static void print_a_to_z()
        {
            for (int i = 0x61; i <= 0x7A; i++)
            {
                Console.WriteLine((char)i);
            }
        }   
  
        public static void print_z_to_a()
        {
            Console.WriteLine("-----------------");
            for(int i=122; i>=97;i--)
            {
                Console.WriteLine((char)i);
            }
        }

        public static void print_A_to_Z()
        {
            Console.WriteLine("-----------------");
            for (int i = 0x41; i <= 0x5A; i++)
            {
                Console.WriteLine((char)i);
            }
        }

        public static void output_code(char n)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("he co so 10:");
            Console.WriteLine((int)n);
        }

        public static void Check(char n)
        {
            if(97<=n && n<=122)
            {
                Console.WriteLine("{0} Is lower", n);
            }
            else
            {
                Console.WriteLine("{0} Is Upper", n);
            }
        }
        
        public static void Change(char n)
        {
            
            if(65<=n && n<=90)
            {          
                Console.WriteLine("{0} chuyen thanh {1}", n, (char)(n+32));
            }
            else
            {            
                Console.WriteLine("{0} chuyen thanh {1}", n, (char)(n-32));
            }
        } 
    }
}
