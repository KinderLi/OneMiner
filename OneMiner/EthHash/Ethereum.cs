﻿using OneMiner.Core;
using OneMiner.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneMiner.EthHash
{
    class Ethereum : BaseCoin, ICoin
    {

        public override string Name
        {
            get { return "Ethereum"; }
        }

        public override string Logo
        {
            get { throw new NotImplementedException(); }
        }


        public bool SupportsDualMining
        {
            get { return false; }
        }

        public ICoin DualCoin
        {
            get
            {
                return null;
            }

        }
    }
}
