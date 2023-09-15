using System;

namespace Unit02_04_FraudulentOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inventory = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            int numFakes = 0;

            foreach (string item in inventory)
            {
                if(item.StartsWith("B"))
                {
                    numFakes++;
                    Console.WriteLine(item);
                }

            }
            Console.WriteLine($"We have {numFakes} Frudulent Orders.");
        }
    }
}
