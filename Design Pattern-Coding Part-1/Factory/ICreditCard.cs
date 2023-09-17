using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Factory
{
    internal interface ICreditCard 
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();

    }
}
