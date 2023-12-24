using System;

namespace Beltek70Web
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            

                //try
                //{
                //    checked
                //    {
                //        int sayi = 257;
                //        byte number = (byte)sayi;//Tür dönüşümü-Type Casting
                //        Console.WriteLine(number);
                //    }
                //}
                //catch (OverflowException)
                //{
                //    Console.WriteLine("Hatalı sayı");
                //}
                //catch(Exception)
                //{
                //    Console.WriteLine("Bilinmeyen Hata");
                //}



                try
                {
                    Console.WriteLine("Adınızı giriniz:");
                    string isim = Console.ReadLine();
                    Console.WriteLine("Soyadınızı giriniz:");
                    string soyad = Console.ReadLine();
                    Console.WriteLine("Yaşınızı giriniz:");
                    byte age = byte.Parse(Console.ReadLine());
                    Console.WriteLine($"Hoşgeldin, {isim} {soyad}\nYaşın:{age}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yaşınızı sayı ile giriniz");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Yaşınızı 0-255 arası giriniz.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Bir hata oluştu!\nTarih:{DateTime.Now}\nHata Mesajı:{ex.Message}\nStack Trace:{ex.StackTrace}");
                }


                //Exception Handling(Hata Yönetimi)
                //Try-Catch Blokları


                //***TÜR DÖNÜŞÜMLERİ (Type Casting)***
                //byte sayi = 20;
                //int number = sayi;//Implicit type casting

                //checked
                //{
                //    int sayi = 257;
                //    byte number = (byte)sayi;//Explicit Type Casting
                //    Console.WriteLine(number);
                //}

                //string sayi = "20";
                //byte number = byte.Parse(sayi);

                //Console.WriteLine("Bir sayı giriniz:");
                //byte s1 = byte.Parse(Console.ReadLine());
                //Console.WriteLine("Bir sayı daha giriniz:");
                //byte s2 = byte.Parse(Console.ReadLine());
                //Console.WriteLine($"Girilen sayıların toplamı:{s1 + s2}");



                //Operatörler
                //Karar Yapıları
                //if-else / switch-case
            }
        }
    }
    //Tip Güvenliği(Type Safety): C# programlama dilinde, bir veri tipine atanan değerin tipi, veri tipi ile aynı yada uyumlu olmalıdır. Örn. string bir veri tipine int bir değer atanamaz.




