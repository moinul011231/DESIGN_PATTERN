using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_2
{
    public sealed class ThreadSafe
    {
        private static int counter = 0;
        private static ThreadSafe instance = null;
        private ThreadSafe()
        {
            counter++;
            Console.WriteLine(counter.ToString());



        }

        public static ThreadSafe Instance()
        {

            if (instance == null)
            {
                instance = new ThreadSafe();
            }


            return instance;
        }


        public void ShowDetails(string message)
        {
            Console.WriteLine(message);
        }







    }
}