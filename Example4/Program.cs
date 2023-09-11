using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Option = false;
            var OrganizationGreetings = "You're welcome to our dear esteem organization.";
            var StaffQuestion = "how may i be of help";

            Console.WriteLine("What's your name?");
            var ClientName = Console.ReadLine();

            do
            {
                Console.WriteLine(OrganizationGreetings);
            }
            while (Option);
            {
                Console.WriteLine($"Hi, {StaffQuestion} Mr {ClientName}.");
            }
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }
    }
}
