using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_2
{
    public static class ClientForSingleton
    {

        public static void UseMultithread()
        {
            Parallel.Invoke(

             () => PrintTeacherDetails(),
             () => PrintStudentDetails()



            );




        }




        private static void PrintTeacherDetails()
        {

            ThreadSafe teacher = ThreadSafe.Instance();
            Console.WriteLine("From Teacher");





        }

        private static void PrintStudentDetails()
        {

            ThreadSafe teacher = ThreadSafe.Instance();
            Console.WriteLine("From Student");





        }




    }
}