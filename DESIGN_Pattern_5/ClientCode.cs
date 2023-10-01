using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_Pattern_5
{
    public static class ClientCode
    {

        public static void UseChainCode(long requestAmmount)
        {


            TwoThousand twoThousand = new TwoThousand();
            FiveHundred fiveHundred = new FiveHundred();
            TwoHundred twoHundred = new TwoHundred();
            Hundred hundred = new Hundred();


            twoThousand.SetNextHandler(fiveHundred);
            fiveHundred.SetNextHandler(twoHundred);
            twoHundred.SetNextHandler(hundred);


            if (requestAmmount % 100 == 0)
            {

                twoThousand.DispatchMoney(requestAmmount);

            }
            else
            {
                Console.WriteLine("You Enter Invalid");
            }

        }




    }
}