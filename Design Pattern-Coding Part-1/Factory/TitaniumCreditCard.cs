using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Factory
{
    public class TitaniumCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 600;
        }

        public int GetCradLimit()
        {
            throw new NotImplementedException();
        }

        public string GetCradType()
        {
            return "Platinum Credit Crad" ;
        }
    }
}
