﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal interface IOsoba
    {
        string Imię { get; set; }
        string Nazwisko { get; set; }
        void ZwrocPelnaNazwe();
    }
}
