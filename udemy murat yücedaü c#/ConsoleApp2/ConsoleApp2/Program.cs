using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           kisiler ksl = new kisiler();
            string ads;
            Console.Write("isim girin: ");
            ads = Console.ReadLine();
            ksl.kisilistesi(ads);
            Console.ReadLine();
            
        }
    }
}
