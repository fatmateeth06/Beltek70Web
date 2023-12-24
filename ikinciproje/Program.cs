using System;

namespace Beltek.KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region Hava durumu
            //Console.WriteLine("Hava nasıl?");
            //string cevap = Console.ReadLine().ToLower();

            //switch (cevap)
            //{
            //    case "güzel":
            //        Console.WriteLine("Kaç derece?");
            //        sbyte derece = sbyte.Parse(Console.ReadLine());
            //        if (derece < 15)
            //        {
            //            Console.WriteLine("Evde otur");
            //        }
            //        else if (derece >= 15 && derece <= 35)
            //        {
            //            Console.WriteLine("Dışarı çık");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Çok sıcak evde otur");
            //        }
            //        break;
            //    case "kötü":
            //        Console.WriteLine("Evde otur");
            //        break;
            //    default:
            //        Console.WriteLine("Sadece güzel/kötü cevabı verebilirsiniz.");
            //        break;
            //}




            //if (cevap == "güzel")
            //{
            //    Console.WriteLine("Kaç derece?");
            //    sbyte derece = sbyte.Parse(Console.ReadLine());
            //    if (derece < 15)
            //    {
            //        Console.WriteLine("Evde otur");
            //    }
            //    else if (derece >= 15 && derece <= 35)
            //    {
            //        Console.WriteLine("Dışarı çık");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Çok sıcak evde otur");
            //    }
            //}
            //else if (cevap == "kötü")
            //{
            //    Console.WriteLine("Evde otur");
            //}
            //else
            //{
            //    Console.WriteLine("Sadece güzel/kötü cevabı verebilirsiniz.");
            //}
            //#endregion

            //#region if-else switch-case
            //Console.WriteLine("Bir sayı giriniz:");
            //byte sayi = byte.Parse(Console.ReadLine());

            //if (sayi == 0)
            //{
            //    Console.WriteLine("Sıfır");
            //}
            //else if (sayi == 1)
            //{
            //    Console.WriteLine("Bir");
            //}
            //else if (sayi == 2)
            //{
            //    Console.WriteLine("İki");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş");
            //}

            //switch (sayi)
            //{
            //    case 0:
            //        Console.WriteLine("Sıfır");
            //        break;
            //    case 1:
            //        Console.WriteLine("Bir");
            //        break;
            //    case 2:
            //        Console.WriteLine("İki");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş!");
            //        break;
            //}
            //#endregion

            try
            {
                Console.WriteLine("bir sayı giriniz");
                double sayi = byte.Parse(Console.ReadLine());
                Console.WriteLine("ikinci sayı giriniz");
                double sayi2 = byte.Parse(Console.ReadLine());
                Console.WriteLine("işlem giriniz");
                char islem = char.Parse(Console.ReadLine());


                switch (islem)
                {
                    case '+':
                        Console.WriteLine($"sayıları topla: {sayi + sayi2}");
                        break;
                    case '-':
                        Console.WriteLine($"sayıları çıkar:{sayi - sayi2}");
                        break;
                    case '/':
                        Console.WriteLine($"sayıları böl:{sayi / sayi2}");
                        break;
                    case '*':
                        Console.WriteLine($"sayıları çarp:{sayi * sayi2}");
                        break;
                    default:
                        Console.WriteLine($"hatalı giriş yaptınız");
                        break;


                }
            }
            catch (FormatException)
            {
                Console.WriteLine("yazım hatası yaptınız");

            }
            catch (OverflowException)
            {
                Console.WriteLine("çok büyük ya da çok küçük sayı girdiniz");
            }
            catch (Exception)
            {
                Console.WriteLine("bilinmeyen hata");
            }


        }
    }
}
