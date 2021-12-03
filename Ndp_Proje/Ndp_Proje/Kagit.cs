using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    class Kagit :IAtıkKutusu
    {
        public int BosaltmaPuanı { get; set; }

        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int DolulukOranı { get; set; }

        public Kagit()
        {
            this.DoluHacim = 0;
            this.BosaltmaPuanı = 1000;
            this.Kapasite = 1200;

        }
      
        public bool Bosalt()
        {
            this.DolulukOranı = 0;
            this.DoluHacim = 0;
            this.BosaltmaPuanı = 1000;
            return true;
        }

        public bool Ekle(Atik atik)
        {
            return true;
        }
    }
}
