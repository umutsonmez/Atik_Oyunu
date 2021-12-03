using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    class Cam :IAtıkKutusu
    {
        public int BosaltmaPuanı { get; set; }

        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int DolulukOranı { get; set; }

        public Cam()
        {
            this.DoluHacim = 0;
            this.Kapasite = 2200;
            this.BosaltmaPuanı = 600;
        }
        public bool Bosalt()
        {
            this.DolulukOranı = 0;
            this.DoluHacim = 0;
            this.BosaltmaPuanı = 600;
            return true;
        }

        public bool Ekle(Atik atik)
        {
            return true;
        }
    }
}
