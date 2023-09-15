using System;

namespace DiceRollerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // Your code goes here
            // Rules
            // Higher Numbered Rules Take Precidence
            // Rule 2 - 10 Days or Less - Your subscription will expire soon. Renew now!
            // Rule 3 - 5 Days or less - Your subscription expires in _ days.
            //                            Renew now and save 10%!
            // Rule 4 - In One day - Your subscription expires within a day!
            //                            Renew now and save 20%!
            // Rule 5 - Expired (0 Days) - Your subscription has expired.
            // Rule 6 - Do Nothing

            var message = "";
            //DEBUg daysUntilExpiration = 1;
            if(daysUntilExpiration == 0)
            {
                message = "Your subscription has expired.";
            }
            else if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                message = $"In One day - Your subscription expires within a day!";
            }
            else if (daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                message = $"Your subscription expires in {daysUntilExpiration} days.";
            }
            else if (daysUntilExpiration <= 10 )
            {
                message = "Your subscription will expire soon. Renew now!";
            }
            else
            {

            }

            Console.WriteLine(message);
            if(discountPercentage != 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%!");
            }


        }
    }
}
