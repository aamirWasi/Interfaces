﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA1
{
    class TVRemote
    {
        public static IElectronicDevice GetElectronic()
        {
            return new Television("Sony",0);
        }
    }
}
