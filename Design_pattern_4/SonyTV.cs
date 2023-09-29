using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_4
{
    internal class SonyTV : ILEDTV
    {
        public void SetChannel(int channelNum)
        {
            Console.WriteLine("Seting channel number " + channelNum + " On Sony Tv");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turn OFF Sony TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turn ON Sony TV");
        }
    }
}