﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Bank
{
    public class Deposit : Account, IInterestChargeable
    {
        public override decimal InterestRate { get; set; }

        public override decimal Interest { get; set; }
        
        public Deposit(string owner, decimal balance)
            : base(owner, balance)
        {
            this.InterestRate = 0.12m;
        }

        public void SetInterestRate(decimal interestRate)
        {
            this.InterestRate = interestRate;
        }

        public void ChargeInterest()
        {
            this.Interest = this.CurrentBalance * this.InterestRate;
        }
    }
}
