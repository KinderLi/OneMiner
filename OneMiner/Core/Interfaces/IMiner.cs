﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneMiner.Core.Interfaces
{
    public interface IMiner
    {
        ICoin MainCoin { get; set; }
        ICoin DualCoin { get; set; }
        string Name { get; set; }

        void StartMining();
    }
}