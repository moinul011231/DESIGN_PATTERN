using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_2
{
    public static class ClientCodeForUsingPrototype
    {

        public static void useprototype()
        {


            student sunny = new student();
            sunny.Name = "Anamul Sani";
            sunny.Department = "police";
            sunny.University = "Police Training";


            student Moinul = sunny.GetClone();
            Moinul.Name = "Shojib Talukder";
            Moinul.University = "uiu";
            Moinul.Department = "CSE";


            Console.WriteLine($"Name: {sunny.Name} Department : {sunny.Department} University : {sunny.University} ");

            Console.WriteLine($"Name: {Moinul.Name} Department : {Moinul.Department} University : {Moinul.University} ");


        }







    }
}