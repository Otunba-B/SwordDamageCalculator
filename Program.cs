using System;

namespace SwordDamageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();

            Console.WriteLine("0 for no magic/ flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
            var line = Console.ReadKey(false).KeyChar;

            if (line != '1' && line != '2' && line != '3' && line != '0')
            {
                return;
            }

            else
            {
                var Roll1 = random.Next(1, 7);
                var Roll2 = random.Next(1, 7);
                var Roll3 = random.Next(1, 7);

                swordDamage.Roll = Roll1 + Roll2 + Roll3;
            }

            if (line == '1' || line == '3')
            {
                swordDamage.SetMagic(true);
                
            }
            else
            {
                swordDamage.SetMagic(false);
            }

            if (line == '2' || line == '3')
            {
                swordDamage.SetFlaming(true);
            }
            else
            {
                swordDamage.SetFlaming(false);
            }

            Console.WriteLine(" Rolled " + swordDamage.Roll + " for " + swordDamage.Damage + "HP");
        }
    }
}
