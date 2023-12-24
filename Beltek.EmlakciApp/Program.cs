using Beltek.EmlakciLib;

namespace Beltek.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var evim = new Ev();//nesne türettik



            Console.WriteLine("oda sayısı giriniz");
            evim.SetOdaSayisi(int.Parse(Console.ReadLine()));



            Console.WriteLine("kat no giriniz");
            evim.katno = int.Parse(Console.ReadLine());

            Console.WriteLine("alan giriniz");
            evim.alan = double.Parse(Console.ReadLine());


            Console.WriteLine("semt giriniz");
            evim.SetSemt(Console.ReadLine());

            Console.WriteLine(evim.EvBilgileri());


        }

    }



    //class Ev
    //{
    //    public int odasayisi;//field
    //    public string semt;
    //    public int katno;
    //    public double alan;

    //    public string EvBilgileri()
    //    {
    //        return $"oda sayisi:{this.odasayisi}\nAlan:{this.alan}\nSemt:{this.semt}\nKat no:{this.katno}";

    //    }

    //}

}//classlar aynı zamanda bir veri tipidir
 //new anathar kelimesi ,heap bölgesinde alan ayırmak için kullanılır.
 //calss içindeki bir üye static olarak tanımlanırsa ,bu üyeye class adı ile erişilebilir.
 //örn Console.WriteLine() ifadesinde ,WriteLine() metodu static olarak tanımlanmıştır.
 //static üyeler classa ait olur nesneye ait olmaz ,dolayısıyla nesne adı ile erişilemez.


//Write Once ,Use Everyone
//DRY:DONT REPEAT YOURSELF: