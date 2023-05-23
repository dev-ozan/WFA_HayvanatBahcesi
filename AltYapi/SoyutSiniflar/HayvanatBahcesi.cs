using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYapi.SoyutSiniflar
{
    public class HayvanatBahcesi
    {
        public List<Hayvan> Hayvanlar { get; set; }
        public void HayvanEkle(Hayvan eklenecekhayvan)
        {
            Hayvanlar.Add(eklenecekhayvan);
        }
        public void HayvanSil(Hayvan SilenecekHayvan)
        {
            Hayvanlar.Remove(SilenecekHayvan);
        }
        public void HayvanGuncelle(Hayvan GuncellenicekHayvan, Hayvan guncelHayvan)
        {
            int eskiHayvanIndex = Hayvanlar.IndexOf(GuncellenicekHayvan);

            Hayvanlar[eskiHayvanIndex] = guncelHayvan;
        }




    }
}
