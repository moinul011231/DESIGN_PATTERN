using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_4
{
    public class SamsungAbstractClass : AbstractRemoteControl
    {


        public SamsungAbstractClass(ILEDTV lEDTV)
        {


            this.ledtv = lEDTV;

        }




        public override void SetChannel(int channelNum)
        {
            ledtv.SetChannel(channelNum);
        }

        public override void SwitchOff()
        {
            ledtv.SwitchOff();
        }

        public override void SwitchOn()
        {
            ledtv.SwitchOn();
        }

    }
}