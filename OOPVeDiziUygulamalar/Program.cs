using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVeDiziUygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Uygulama 1: Kullanıcıdan kaç isim gireceğini sor. isimler alınacak. alınan isimler yazdırılacak

            //Console.WriteLine("Kaç isim gireceksiniz?");
            //int adet = Convert.ToInt32(Console.ReadLine());
            //string[] isimlerDizi = new string[adet];

            //for (int i = 0; i < isimlerDizi.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". ismi giriniz:");
            //    isimlerDizi[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < isimlerDizi.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". isim: " + isimlerDizi[i]);
            //}

            #endregion

            #region uygulama 2: 
            //        /* 1- domates - 8,90tl
            //         * 2-biber - 9,90tl
            //         * 3-soğan 6,25 tl
            //         * 4- yumurta 0,75tl
            //         * 5-ekmek - 1,25 tl
            //*/

            //        string[] dizi = new string[5];
            //        dizi[0] = "domates";
            //        dizi[1] = "biber";
            //        dizi[2] = "soğan";
            //        dizi[3] = "yumurta";
            //        dizi[4] = "ekmek";

            //        double[] dizi2 = new double[5];
            //        dizi2[0] = 8.90;
            //        dizi2[1] = 9.90;
            //        dizi2[2] = 6.25;
            //        dizi2[3] = 0.75;
            //        dizi2[4] = 1.25;

            //        for (int i = 0; i < dizi.Length; i++)
            //        {
            //            Console.WriteLine((i+1)+". "+dizi[i]+" - "+dizi2[i]+" TL");
            //        }

            #endregion

            #region uygulama 3

            //Console.WriteLine("Kaç ürün gireceksiniz?");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //string[] dizi = new string[adet];
            //double[] dizi2 = new double[adet];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine("Ürün giriniz: ");
            //    dizi[i] = Console.ReadLine();
            //    Console.WriteLine("Ürünün fiyatını giriniz:");
            //    dizi2[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". " + dizi[i] + " - " + dizi2[i] + " TL");
            //}

            #endregion

            #region Uygulama 4

            //Console.WriteLine("Kaç ürün gireceksiniz?");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //Urunler[] Urun = new Urunler[adet];

            //for (int i = 0; i < adet; i++)
            //{
            //    Urunler u = new Urunler();

            //    Console.WriteLine((i+1)+". Ürünün adını giriniz.");
            //    u.UrunAdi = Console.ReadLine();
            //    Console.WriteLine((i + 1) + ". Ürünün fiyatını giriniz.");
            //    u.UrunFiyat = Convert.ToDouble(Console.ReadLine());

            //    Urun[i] = u;
            //}

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine((i+1)+". "+Urun[i].UrunAdi+" "+Urun[i].UrunFiyat);
            //}

            #endregion

            #region Uygulama 5

            //string secenek = "e";

            //while(secenek == "e")
            //{
            //    Console.WriteLine("İsim girin");
            //    string isim = Console.ReadLine();

            //    Console.WriteLine("İsim girmeye devam edilsin mi? e/h");
            //    secenek = Console.ReadLine();
            //}
            #endregion

            #region uyg

            //string exit="e";
            //int top = 0;

            //for (; ; )
            //{
            //    if (exit == "e")
            //    {
            //        Console.WriteLine("Sayı giriniz: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        top += sayi;
            //        Console.WriteLine("Devam edilsin mi?");
            //        exit = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Toplam: "+top);
            //        break;
            //    }
            //}


            #endregion

            #region eleman sayısı artırılabilir dizi

            //string eleman = "e";
            //string[] isimler = new string[0];

            //while (eleman=="e")
            //{
            //    string[] gecici = new string[isimler.Length+1];
            //    Array.Copy(isimler, gecici, isimler.Length);
            //    //for (int i = 0; i < isimler.Length; i++)
            //    //{
            //    //    gecici[i] = isimler[i];
            //    //}

            //    Console.WriteLine("isim gir");
            //    gecici[gecici.Length - 1] = Console.ReadLine();

            //    isimler = gecici;

            //    Console.WriteLine("Devam edilsin mi?");
            //    eleman = Console.ReadLine();

            //}

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
