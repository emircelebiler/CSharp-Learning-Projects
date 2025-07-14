using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Kilonuzu Giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double kitle_endeksi = kilo / (boy * boy);

            if (kitle_endeksi<=18)
            {
                Console.WriteLine("ZAYIF");
                Console.ReadLine();
            }
            else if(kitle_endeksi>18 &&  kitle_endeksi<25)
            {
                Console.WriteLine("NORMAL");
                Console.ReadLine();

            }
            else if(kitle_endeksi>25)
            {
                Console.WriteLine("OBEZ");
                Console.ReadLine();

            }
        }
    }
}
