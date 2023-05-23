using AltYapi.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYapi.SoyutSiniflar
{
    public class Hayvan
    {
        public string Tur { get; set; }
        private int yas;

        public int Yas
        {
            get { return yas; }
            set
            {
                if (value < 0 || value > 250) yas = 0;
                else
                    yas = value;

            }
        }
        public Cinsiyet Cinsiyet { get; set; }


        public virtual string SesCikar()
        {
            return "Sesi Yok";
        }
        public override string ToString()
        {
            return this.GetType().Name + " Yaş : " + Yas + "Cinsiyet : " + Cinsiyet;
        }

    }
}
