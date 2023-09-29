using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_4
{
    public class SamsungTV : ILEDTV
    {
        public void SetChannel(int channelNum)
        {
            Console.WriteLine("Seting channel number " + channelNum + " On samsung Tv");
        }

        public void SwitchOff()
        {

            Console.WriteLine("Turn OFF Samsung TV");

        }

        public void SwitchOn()
        {

            Console.WriteLine("Turn ON Samsung TV");


        }
    }
}