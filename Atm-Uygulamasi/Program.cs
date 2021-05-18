using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Mini ATM Uygulaması
             Coded by Dogukan Bey
           */
            int bakiye = 1000;

            Console.WriteLine("ATM'ye hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi tuşlayın");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Bakiye Görüntüleme");
            Console.WriteLine("2 - Para Çekme");
            Console.WriteLine("3 - Para Yatırma");
            Console.WriteLine("4 - Çıkış Yapma");
            Console.WriteLine("------------------------------");
            string islem = Console.ReadLine();
            int islem_int = int.Parse(islem);

            if (islem == "1")
            {
                Console.WriteLine("İşlem algılandı, bakiye görüntüleniyor...");
                Console.WriteLine("Bakiyeniz: " + bakiye);
                Console.ReadLine();
            }
            else if (islem == "2")
            {
                Console.WriteLine("İşlem algılandı, para çekme işlemi başlıyor...");
                Console.WriteLine("Lütfen çekilecek tutarı girin"); string cekilecek_tutar = Console.ReadLine();
                int cekilecek_tutar_int = int.Parse(cekilecek_tutar);
                if (cekilecek_tutar_int <= bakiye)
                {
                    Console.WriteLine("Para çekme işlemi kabul edildi para çekiliyor..");
                    Console.WriteLine("Para çekildi yeni bakiyeniz: " + (bakiye - cekilecek_tutar_int));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bu miktarda para çekmek için bakiyeniz yetersiz.");
                    Console.ReadLine();
                }
            }
            else if (islem == "3")
            {
                Console.WriteLine("İşlem algılandı, para yatırma işlemi başlıyor...");
                Console.WriteLine("ATM'nin hata vermemesi için paranızın buruşuk yıpranmış vb. durumda olmadığından emin olun");
                Console.WriteLine("Lütfen yatıralacak tutarı girin"); string yatiralacak_tutar = Console.ReadLine();
                int yatiralacak_tutar_int = int.Parse(yatiralacak_tutar);

                Console.WriteLine("Yatıralacak tutar algılandı");
                Console.WriteLine("Para yatırma işlemi başarıyla tamamlandı yeni bakiyeniz: " + (bakiye + yatiralacak_tutar_int));
                Console.ReadLine();
            }
            else if (islem == "4")
            {
                Console.WriteLine("Çıkış yapma işlemi algılandı, çıkış yapılıyor...");
                Console.WriteLine("Kartınızı almayı unutmayın...");
                Console.WriteLine("Çıkış yapıldı!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir tuşlama yapın");
                Console.ReadLine();
            }
        }
    }
}
