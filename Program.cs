using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instalment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CALCULATION IF INSTALMENT");
            Console.WriteLine(" ");

            Console.Write("Size of the loan: ");
            string loan = Console.ReadLine();
            double  loan1 = double.Parse(loan);

            Console.Write("Interest rate on the loan per period (%): ");
            string interestrate = Console.ReadLine();
            double interestrate1 = double.Parse(interestrate);

            Console.Write("Period of interest rate (number of months): ");
            string interestrateperiod = Console.ReadLine();
            int interestrateperiod1 = Convert.ToInt32(interestrateperiod);

            Console.Write("Repayment periods for the loan: ");
            string repayment = Console.ReadLine();
            double repayment1 = double.Parse(repayment);

            double interestpercent = (interestrate1 / 100);
            double secondcalc = (1 + interestpercent);
            double repayment2 = (-repayment1);

            
            double calculationofpower = Math.Pow((secondcalc), (repayment2));
            
            double instalmentofloan = ((loan1 * (interestrate1/100)) / (1 - calculationofpower));

            Console.WriteLine( "The instalment of the loan per {1} month/months is {0}" , instalmentofloan, interestrateperiod1);
            Console.ReadKey();
        }
    }
}
