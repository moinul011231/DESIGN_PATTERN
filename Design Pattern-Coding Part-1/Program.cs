using Design_Pattern_Coding_Part_1.AbstractFactory;
using Design_Pattern_Coding_Part_1.Builder;
using Design_Pattern_Coding_Part_1.Factory;

namespace Design_Pattern_Coding_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //factor
            // ClientCodeFactory.WithoutUsingFactoryCreditCard();
            //ClientCodeForAbstractFactory.UseAbstractFactory();

            ClientCodeForUsingReport.UseBuilderCode();
        }
    }
}