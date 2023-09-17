using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Factory
{
    public class ProductFactory
    {
        public static ICreditCard GetCreditCard( string cardType)
        {
            ICreditCard creditCard = null;

            if (cardType == "Platinum")
            {
                creditCard = new PlatinumCreditCard();
            }

            else if (cardType == "Titanium")
            {
                creditCard = new PlatinumCreditCard();
            }

            else if (cardType == "Gold")
            {
                //Business logic for new card
            }

            return creditCard;

        }
    }
}
