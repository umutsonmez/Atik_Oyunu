using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; set; }
        int DolulukOranı { get; set; }
    }
}
