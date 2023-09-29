using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_4
{
    public abstract class AbstractRemoteControl
    {

        protected ILEDTV ledtv;

        public abstract void SwitchOn();

        public abstract void SwitchOff();

        public abstract void SetChannel(int channelNum);





    }
}