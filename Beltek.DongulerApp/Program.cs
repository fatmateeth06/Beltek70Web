using System.ComponentModel.Design;

namespace Beltek.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Gazi");
            //}
            //Console.WriteLine("isminiz nedir?");
            //string isim = Console.ReadLine();

            //Console.WriteLine("isminiz kaç kere yazılsın");
            //byte sayi = byte.Parse(Console.ReadLine());

            //for (int i = 1; i < sayi; i++)
            //{
            //    Console.WriteLine($"{i+1}-{isim}");

            //}

            //Console.WriteLine("başlangıç değeri giriniz");
            //byte bas=byte.Parse(Console.ReadLine());

            //Console.WriteLine("bitiş değeri giriniz");
            //byte bit =byte.Parse(Console.ReadLine());

            //for (int i = bas; i < bit; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("başlangıç değeri giriniz");
            //byte bas = byte.Parse(Console.ReadLine());

            //Console.WriteLine("bitiş değeri giriniz");
            //byte bit = byte.Parse(Console.ReadLine());

            //Console.WriteLine("tek mi çift mi?");
            //string tekcift=Console.ReadLine().ToLower();



            //int toplam = 0;

            //if (bas > bit)
            //{
            //    byte temp = bas;
            //    bas = bit;
            //    bit = temp;
            //}

            //for (int i = bas; i < bit; i++)
            //{
            //    if (i % 2 == (tekcift=="tek"? 1:0))
            //    {
            //        Console.WriteLine(i);
            //        toplam += i;//toplamlarını bulan

            //    }
            //    //Console.WriteLine(i);
            //    //toplam = toplam + i;
            //    //toplam += i;
            //    //Console.WriteLine($"sayıların toplamı {toplam}");
            //    //Console.WriteLine(i % 2);
            //}

            // Console.WriteLine("taban değeri giriniz");
            //int tbn=int.Parse(Console.ReadLine());    
            // Console.WriteLine("üs değeri giriniz");
            // int us = int.Parse(Console.ReadLine());

            // int sonuc = 1; 

            // for (int i = 0; i < us; i++) {

            //     sonuc *= tbn;
            // }
            // Console.WriteLine(sonuc);



            //Console.WriteLine("sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = 1;

            //for (int i = 2; i <= sayi; i++)
            //{

            //    sonuc *=i;
            //}
            //Console.WriteLine($"faktöriyeli:{sonuc}");


            //Console.WriteLine("baslangıç değeri giriniz");
            //int bas = int.Parse(Console.ReadLine());
            //Console.WriteLine("bitiş değeri giriniz");
            //int bit = int.Parse(Console.ReadLine());

            

         
            //for (int i = bas; i < bit; i++)
            //{
            //    int sayac = 0;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(sayac == 0 ? $"{i}-sayı asal" : $"{i}-asal değil");
            //}

            //6-asal değil
            //7-asal
            //8-asal değil
            //9-asal değil


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            //10
            //2-3-4-5

            //int sayac = 0;
            //Console.WriteLine("bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());


            //for (int i = 2; i <= sayi / 2; i++)
            //{

            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break;//döngüden çık demek
            //    }

            //}
            //Console.WriteLine(sayac == 0 ? "sayı asal" : "asal değil");

            //asal sayı kendi hariç başka sayıya bölünemeyen

            //sonsuz for
            //int sayac = 0;
            //while (sayac < 3)
            //{

            //    Console.WriteLine("kullanıcı adı giriniz");
            //    string user = Console.ReadLine();

            //    Console.WriteLine("sifre giriniz");
            //    string password = Console.ReadLine();




            //    if (user == "admin" && password == "123")
            //    {
            //        Console.WriteLine("başarılı giriş");
            //    }

            //    else
            //    {
            //        Console.WriteLine("hatalı giriş,tekrar deneyiniz");
            //    }
            //    sayac++;
            //}
            ////parantez içi true olduğu sürece dönen döngü




            //int sonuc = 0;
            //do
            //{
            //    Console.WriteLine("sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    sonuc += sayi;
            //    Console.WriteLine("devam etmek istiyor musunuz");
                
            //} while (char.Parse(Console.ReadLine())=='E');

            //Console.WriteLine($"işleminin sonucu:{sonuc}");
            //kullanıcının girdiği sayıları toplayan program
            //sayı giriniz:10
            //devam etmek istiyormusunuz ?E
            //    sayı giriniz:20
            //Devam etmek istiyor musunuz? H
            //sayıların toplamı:30

          


        }
    }
}
//bir işi tekrar tekrar yaptırmak için döngü kullanılır,daha az satırda yazmamızı sağlar