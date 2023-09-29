using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_4
{
    public static class ClientCodeBridge
    {

        public static void UseBridge()
        {

            AbstractRemoteControl sony = new SonyAbstractClass(new SonyTV());
            sony.SwitchOn();
            sony.SetChannel(401);
            sony.SwitchOff();
            AbstractRemoteControl Samsung = new SamsungAbstractClass(new SamsungTV());



        }




    }
}