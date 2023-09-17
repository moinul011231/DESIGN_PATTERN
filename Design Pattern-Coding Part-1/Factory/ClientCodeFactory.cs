using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Factory
{
    public static class ClientCodeFactory
    {
        public static void WithUsingFactoryCreditCard()
        {
            ICreditCard getPlatinumCreditCard = ProductFactory.GetCreditCard("Platinum");
            if (getPlatinumCreditCard != null)
            {
                Console.WriteLine("CardType: {0}", getPlatinumCreditCard.GetCardType());
                Console.WriteLine("CardLimit: (0)", getPlatinumCreditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge: {0}", getPlatinumCreditCard.GetAnnualCharge());
            }
            else
                Console.WriteLine("Invalide Card Type");

        }
        public static void WithoutUsingFactoryCreditCard()
        {
            string cardType = "Platinum";
            ICreditCard creditCard = null;
            
            if (cardType == "Platinum") 
            {
                creditCard = new PlatinumCreditCard();
            }

            else if(cardType == "Titanium")
            {
                creditCard = new PlatinumCreditCard();
            }

            else if(cardType == "Gold")
            {
                //Business logic for new card
            }

            if (creditCard != null)
            {
                Console.WriteLine("CardType: {0}", creditCard.GetCardType()); 
                Console.WriteLine("CardLimit: (0)", creditCard.GetCreditLimit()); 
                Console.WriteLine("Annual Charge: {0}", creditCard.GetAnnualCharge());
            }
            else
                Console.WriteLine("Invalide Card Type");





        }
    }
}
