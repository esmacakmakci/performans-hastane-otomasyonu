using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hastane
    {

        string isim;
        string tcKimlik;
        public static string[] randevu = new string[5];
        public Hastane()
        {
            for (int i = 0; i < randevu.Length; i++)
            {
                randevu[i] = "BOS";

            }
        }
    }
  
    class Kullanıcı : Hastane
    {
        public void Giris()
        {
            string kullaniciAdi = "t";
            string kullaniciSifre = "y";
            string girisAdi = "e";
            string girisSifre = "a";

        gel:
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("Kayıt Olmak İçin -1 ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Giriş Yapmak İçin -2");
            Console.WriteLine("================================================");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.Write("Kayıt için adını giriniz: ");
                kullaniciAdi = Console.ReadLine();
                Console.Write("Kullanıcı şifresini giriniz: ");
                kullaniciSifre = Console.ReadLine();
                goto gel;
            }

            else if (secim == "2")
            {
                Console.Write("Kullanıcı adını giriniz: ");
                girisAdi = Console.ReadLine();
                Console.Write("Kullanıcı şifresini giriniz: ");
                girisSifre = Console.ReadLine();

            }
            else
            {
                Console.Write("lütfen doğru seçim yapınız.");

            }

            if (kullaniciAdi == girisAdi && kullaniciSifre == girisSifre)
            {
                Console.Write("Kullanıcı girişi başarılıdır. ");
            }
            else
            {
                Console.Write("Kullanıcı girişi başarılı değildir. ");
            }
            Console.ReadKey();
        }

       

        public void RandevuTakibi()
        {

            for (int i = 0; i < randevu.Length; i++)
            {
                Console.WriteLine(randevu[i]);
            }
        }
        public void KiloIndeksÖlcme()
        {
            double boy, kilo, indeks = 0;
            Console.Write("Boyunuzu metre cinsinden Giriniz [Örn:165]  : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            indeks = kilo / (boy/100 * boy/100);
            Console.WriteLine("================================================");
            Console.WriteLine("Vücut Kitle İndexiniz : {0}", indeks);
            if (indeks < 18)
            {
                Console.WriteLine("İdeal kilodan düşük formdasınız.(Zayıf)");
            }
            else if (indeks >= 18 && indeks < 25)
            {
                Console.WriteLine("İdeal kilodasınız.(Normal)");
            }
            else if (indeks >= 25 && indeks < 30)
            {
                Console.WriteLine("ideal kilodan fazlasınız.(Kilolu)");
            }
            else if (indeks >= 30 && indeks < 35)
            {
                Console.WriteLine("Sağlıklı beslenme ve sporla geç olmadan halledilebilir.(Obez)");
            }
            else
            {
                Console.WriteLine("Ciddi Obez");
            }
            Console.ReadKey();
        }
        public void Test()
        {
            int puan = 0;
            string sSecim = "p";
        soru1:
            Console.Clear();
            Console.WriteLine("1-Kahvaltıyla aranız nasıl? ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("a- Kahvaltı yapacağıma uyurum daha iyi, neredeyse hiç kahvaltı yapmam");
            Console.WriteLine("b- Yolda veya işe/okula gidince bir şeyler atıştırırım");
            Console.WriteLine("c- Hafta içi bir parça peynir ekmek yemeden sokağa çıkmam, hafta sonu mükellef bir kahvaltı sofrası hazırlarım");
            Console.WriteLine("d- Hafta içi veya hafta sonu fark etmez, her daim doyurucu bir kahvaltı yapmadan sokağa çıkmam ");
            sSecim = Console.ReadLine();
            if (sSecim == "a")
            {
                puan += 1;
            }
            else if (sSecim == "b")
            {
                puan += 2;
            }

            else if (sSecim == "c")
            {
                puan += 3;
            }
            else if (sSecim == "d")
            {
                puan += 4;
            }
            else
            {
                Console.WriteLine("Lütfen doğru bir seçim yapınız.");
                Console.ReadKey();
                goto soru1;
            }
        soru2:
            Console.Clear();
            Console.WriteLine("2-Günde kaç bardak su içiyorsun?");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("a- 1-2 bardak ");
            Console.WriteLine("b- 3-4 bardak ");
            Console.WriteLine("c- 5-7 bardak ");
            Console.WriteLine("d- 8-10 bardak ");
            sSecim = Console.ReadLine();
            if (sSecim == "a")
            {
                puan += 2;
            }
            else if (sSecim == "b")
            {
                puan += 1;
            }

            else if (sSecim == "c")
            {
                puan += 3;
            }
            else if (sSecim == "d")
            {
                puan += 4;
            }
            else
            {
                Console.WriteLine("Lütfen doğru bir seçim yapınız.");
                goto soru2;
            }
        soru3:
            Console.Clear();
            Console.WriteLine("3-En son ne zaman meyve yedin?\r\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("a- Hatırlayamadım ");
            Console.WriteLine("b- Ben sadece yaz meyvelerini seviyorum");
            Console.WriteLine("c- 3-4 gün önceydi sanırım");
            Console.WriteLine("d- Her gün bir meyve mutlaka yerim");
            sSecim = Console.ReadLine();

            if (sSecim == "a")
            {
                puan += 1;

            }
            else if (sSecim == "b")
            {
                puan += 3;

            }

            else if (sSecim == "c")
            {
                puan += 2;

            }
            else if (sSecim == "d")
            {
                puan += 4;

            }
            else
            {
                Console.WriteLine("Lütfen doğru bir seçim yapınız.");
                goto soru3;
            }
        soru4:
            Console.Clear();
            Console.WriteLine("4-Nasıl bir tatilcisin?");
            Console.WriteLine("-----------------------");
            Console.WriteLine("a- Yazın tamamını güneş altında geçiririm, bronzlaşmak için pek de koruyucu sürmem");
            Console.WriteLine("b- Yılda bir hafta deniz-güneş tatili yapıyorum. Onda da bronzlaşmak için az korumalı bir krem sürsem olur herhalde");
            Console.WriteLine("c- Ne olursa olsun güneşlenirken tam korumalı bir güneş kremi kullanırım");
            Console.WriteLine("d- Güneşin en dik geldiği saatlerde asla güneşlenmem, diğer saatlerde de mutlaka koruyucu sürerim");
            sSecim = Console.ReadLine();

            if (sSecim == "a")
            {
                puan += 1;

            }
            else if (sSecim == "b")
            {
                puan += 2;

            }

            else if (sSecim == "c")
            {
                puan += 4;

            }
            else if (sSecim == "d")
            {
                puan += 3;

            }
            else
            {
                Console.WriteLine("Lütfen doğru bir seçim yapınız.");
                goto soru4;
            }
        soru5:
            Console.Clear();
            Console.WriteLine("5-İşe nasıl gidiyorsun?\r\n");
            Console.WriteLine("a- Evden çalışıyorum; yataktan kalktıktan sonra üç adımla ofisteyim!");
            Console.WriteLine("b- Otomobilime evin önünden biner, ofisin otoparkına bırakırım");
            Console.WriteLine("c- Toplu taşıma duraklarına yürüyorum ");
            Console.WriteLine("d- Yürüyorum/bisikletle gidiyorum");
            sSecim = Console.ReadLine();

            if (sSecim == "a")
            {
                puan += 1;

            }
            else if (sSecim == "b")
            {
                puan += 2;

            }

            else if (sSecim == "c")
            {
                puan += 3;

            }
            else if (sSecim == "d")
            {
                puan += 4;

            }
            else
            {
                Console.WriteLine("Lütfen doğru bir seçim yapınız.");
                goto soru5;
            }
            Console.Clear();
            if (puan > 0 && puan <= 5)
            {
                Console.Write("Puanın düşük.Sağlıklı beslenmen gerekiyor.Spor yapmalısın");
                Console.WriteLine("Puanınız: " + puan);
            }
            else if (puan > 5 && puan <= 10)
            {

                Console.Write("suyu daha dengeli tüketmelisin.Sporunu bazı günler aksattığını örüyorum.Sağlıklı yiyeceklerden devam etmelisin.");
                Console.WriteLine("Puanınız: " + puan);
            }
            else if (puan > 10 && puan <= 15)
            {

                Console.WriteLine("Puanın gayet iyi fakat biraz daha çabalarsan en iyisi olabilirsin.");
                Console.WriteLine("Puanınız: " + puan);
            }
            else if (puan > 15 && puan <= 20)
            {
                Console.WriteLine("Beslenmesinden sporuna kadar sağlıklı yaşamı bir hayat felsefesi haline getirmişsin.");
                Console.WriteLine("Puanınız: " + puan);

            }

        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Kullanıcı a = new Kullanıcı();

            a.Giris();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Lütfen bir seçim yapınız.");
            Console.WriteLine("1- Randevu Takibi");
            Console.WriteLine("2- Sağlık Testi");
            Console.WriteLine("3- Vücut Kitle İndeksi Ölçme");
            string secim = Console.ReadLine();
            while (true)
            {
                if (secim == "1")
                {

                    a.RandevuTakibi();
                    Console.ReadKey();
                }
                else if (secim == "2")
                {
                    a.Test();
                    Console.ReadKey();
                }
                else if (secim == "3")
                {
                    a.KiloIndeksÖlcme();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lütfen doğru (bir seçim yapınız.)");
                }

            }
        }

    }
}