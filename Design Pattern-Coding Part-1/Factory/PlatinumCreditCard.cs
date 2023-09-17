using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Factory
{
    public class PlatinumCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public int GetCradLimit()
        {
            return 1500000;
        }

        public string GetCradType()
        {
            return "Platinum Credit Crad";
        }
    }
}
