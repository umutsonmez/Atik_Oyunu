﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    public interface IAtıkKutusu : IDolabilen
    {
        
        int BosaltmaPuanı { get; }


        bool Bosalt();
    }
}
