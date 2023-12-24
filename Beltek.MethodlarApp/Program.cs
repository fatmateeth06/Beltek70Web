namespace Beltek.MethodlarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("taban giriniz:");
            int tbn=int.Parse(Console.ReadLine());
            Console.WriteLine("üs giriniz");
            int us=int.Parse(Console.ReadLine());

            Console.WriteLine(usHesapla(tbn, us));//**önemli
            //int sonuc = usHesapla(us,tbn);
            //Console.WriteLine(sonuc);

            //int[] dizi = { 10, 20, 30 };//heap bölgesinde tutulur
            //int sonuc = Topla(dizi);
            //Console.WriteLine(sonuc);
            //    Console.WriteLine("1.sayıyı giriniz");
            //    int sayi1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("ikinci sayıyı giriniz");
            //    int sayi2 = int.Parse(Console.ReadLine());

            //usHesapla(2);

            //Console.WriteLine("işlem seçiniz:+ \n * \n - \n /");
            //char islem = char.Parse(Console.ReadLine());

            //string msg = "işlemin sonucu:";

            //switch (islem)
            //{
            //    case '+':
            //        Console.WriteLine($"{msg} {Topla(sayi1, sayi2)}");

            //        break;
            //    case '*'://char olduğu için tek tırnak
            //        Console.WriteLine($"{msg} {Carp(sayi1, sayi2)}");

            //        break;
            //    case '-':
            //        Console.WriteLine($"{msg} {Cikar(sayi1, sayi2)}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{msg} {Bol(sayi1, sayi2)}");
            //        break;
            //    default:
            //        Console.WriteLine($"hatalı seçim!");
            //        break;


            //}

            //int result = Topla(sayi1, sayi2,s3);
            //Console.WriteLine(result);
        }
        //static int Topla(int s1, int s2)
        //{

        //    return s1 + s2;
        //}

        static int Topla(int s1, int s2) => s1 + s2;

        static int Topla(int s1, int s2, int s3) => s1 + s2 + s3;


        //static int Topla(int[] sayilar)
        //{
        //    int sonuc = 0;
        //    for (int i = 0; i < sayilar.Length; i++)
        //    {
        //        sonuc += sayilar[i];

        //    }
        //    return sonuc;

        //}
        static int Carp(int s1, int s2) => s1 * s2;
        static int Cikar(int s1, int s2) => s1 - s2;
        static double Bol(int s1, int s2) => s1 / s2;

       
        static int usHesapla(int us, int tbn)
        {
            int sonuc = 1;

            for (int i = 0; i < us; i++)
            {

                sonuc *= tbn;
            }
            return sonuc;
            
        }
    }
}

//=> return demektir.
//method İMZASI methodun aldığı parametre tipleri ve sayılardır.int,int
//method overloading(aşırı yüklenmesi) imzaları farklı olan metodlar  aynı isimle tanımlanabilirler.