﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdevMod17.Accounts
{
    public interface IAccount
    {
        public string Type { get; set; }

        public double Balance { get; set; }

        public double Interest { get; set; }
        public void CalculateInterest();
    }
}
