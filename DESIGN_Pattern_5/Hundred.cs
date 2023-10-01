using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_Pattern_5
{
    public class Hundred : Handler
    {

        public override void DispatchMoney(long amount)
        {
            long numNote = amount / 100;

            if (numNote > 0)
            {
                if (numNote > 1)
                {

                    Console.WriteLine(numNote + "Two thousand Notes are Dispatchyed");
                }

                else { Console.WriteLine(numNote + "Two thousand Notes is Dispatchyed"); }
            }


            long pendingAmount = amount % 100;

            if (pendingAmount > 0)
            {

                NextHandler.DispatchMoney(pendingAmount);
            }





        }


    }
}