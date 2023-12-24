using System;

namespace Beltek.EmlakciLib
{
    public class Ev
    {
        private int odasayisi;//field
        private string semt;
        public int katno;
        public double alan;


        public void SetOdaSayisi(int odasayisi)
        {
            this.odasayisi = Math.Abs(odasayisi);
        }

        public int GetOdaSayisi()

        {
            return this.odasayisi;
        }

        public void SetSemt(string semt)=> this.semt = semt.ToUpper();
        //{
        //    this.semt = semt.ToUpper();
        //}

        public string GetSemt()=>this.semt;

        //{
        //    return this.semt;
        //}



        public string EvBilgileri()
        {
            return $"oda sayisi:{this.odasayisi}\nAlan:{this.alan}\nSemt:{this.semt}\nKat no:{this.katno}";

        }
    }
}
//private erişilemez demektir.
//Get;geriye dönüş yapabilen(değeri geri döndüren),set değer atamak
//kapsülleme İlkesi-Encapsulation bir class içinde yapılan işlemlerin diğer classlardan gizlenmesi işlemine denir..fieldları korumak amaç