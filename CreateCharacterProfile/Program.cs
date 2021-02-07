using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCharacterProfile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kaç karakter oluşturmak istiyorsunuz?: ");
            int karakterSayi = Convert.ToInt32(Console.ReadLine());


            string[] isimler = {"Ahmet","Mehmet","Ali","Esma","Hilal","Ayşe","Fatma","Arzu","Gül","Naz","Polat"};
            string[] soyisimler = { "Demir", "Karaman", "Çakır","Gazi","Baran","Topçu","Keskin","Ergül","Demiroğlu"};
            string[] meslekler = { "Doktor", "Polis", "Taksici", "Yazılımcı", "Tasarımcı", "Kuaför", "Memur", "Müzisyen", "İşsiz" };
            string[] yaslar = { "20", "21", "22", "23", "24", "25", "26", "27", "30","31","32","33","34","40" };
            string[] yuzler = { "001", "010", "020", "030", "040", "050", "060", "070", "080", "090", "100", "110", "120", "130" };
            string[] tenRengi = { "Açık Ten", "Koyu Ten"};


            Random rasgele = new Random();
            
          

            for (int i = 0; i < karakterSayi; i++)
            {


                rasgele = new Random(i);
                int no = rasgele.Next(0, isimler.Length);
                int no2 = rasgele.Next(0, soyisimler.Length);
                int no3 = rasgele.Next(0, meslekler.Length);
                int no4 = rasgele.Next(0, yaslar.Length);
                int no5 = rasgele.Next(0, yuzler.Length);
                int no6 = rasgele.Next(0, tenRengi.Length);

                Console.WriteLine(("İsim Soyisim: " + isimler[no] + " " + soyisimler[no2] + " | Meslek: " + meslekler[no3] + " | Yaş: " + yaslar[no4] + " | Yüz Modeli: " + yuzler[no5] + " | Ten Rengi: " + tenRengi[no6]));
                Console.WriteLine("----");
            }

            Console.ReadKey();
        }



    }
}
