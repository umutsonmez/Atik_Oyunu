using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    class Atik:IAtık
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Hacim { get; set; }
        public Image Image { get ; set; }

        public Atik(string ad,string tur,int hacim,Image resim)
        {
            this.Ad = ad;
            this.Tur = tur;
            this.Hacim = hacim;
            this.Image = resim;
        }

      
    }
}
