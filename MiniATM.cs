using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            //Kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            //1-bakiye görünteleme
            //2-para çekme
            //3-para yatırma
            //q ya basarsa çıkış yapacağız

            Console.WriteLine("Atm ye hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");

            string secim = Console.ReadLine();

            if (secim =="1")
            {
                Console.WriteLine("Şuanki bakiyeniz :" + bakiye);
                Console.ReadLine();
            }
            else if (secim =="2") 
            {
                Console.WriteLine("Çekmek istediğinizi tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar<=bakiye)
                {

                    Console.WriteLine("Kalan tutar :" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                    Console.ReadLine();

                }



            }
            else if(secim =="3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                int yatıralacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz :"+ (bakiye+yatıralacak_tutar));
                Console.ReadLine();

            }
            else if (secim=="q")
            {
                Console.WriteLine("ATM den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı...");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                Console.ReadLine();

            }








        }
    }
}
