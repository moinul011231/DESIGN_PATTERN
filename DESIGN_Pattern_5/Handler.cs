using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_Pattern_5
{
    public abstract class Handler
    {

        public Handler NextHandler;


        public void SetNextHandler(Handler nextHandler)
        {

            this.NextHandler = nextHandler;
        }


        public abstract void DispatchMoney(long amount);





    }
}