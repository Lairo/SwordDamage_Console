using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamage_Console
{
    internal class Program
    {
        
        
        public static void Main(string[] args) // answer
        {
            Random random = new Random();
            SwordDamage swordDamage = new SwordDamage();
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming +" +
                    "3 for both, anything else to quit:" );
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll;
                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.SetFlaming(key == '2' || key == '3');
                Console.WriteLine("\nRolled " + roll + " for " + swordDamage.Damage + " HP\n");
            }

        }

        //My solution
        //public static SwordDamage sword = new SwordDamage();
        //public static Random randomizer = new Random();

        //static void Main(string[] args)
        //{
        //    int[] DiceRolls = new int[3];
        //    while (true)
        //    {
        //        Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming 3 for both, anything else to quit: ");
        //        char input = Console.ReadKey(false).KeyChar;
        //        Console.Write("\n");

        //        DiceRolls[0] = randomizer.Next(1, 7);
        //        DiceRolls[1] = randomizer.Next(1, 7);
        //        DiceRolls[2] = randomizer.Next(1, 7);
        //        sword.Roll = DiceRolls.Sum();

        //        if (input == '0')
        //        {
        //            Prompt();
        //        }
        //        else if (input == '1' || input == '3')
        //        {
        //            sword.SetMagic(true);
        //            Prompt();
        //        }

        //        else if (input == '2' || input == '3')
        //        {
        //            sword.SetFlaming(true);
        //            Prompt();
        //        }
        //        else
        //        {
        //            //sword.SetFlaming(false);
        //            //sword.SetMagic(false);
        //            return;
        //        }

        //    }

        //    void Prompt()
        //    {
        //        Console.WriteLine($"Rolled {DiceRolls.Sum()} for {sword.Damage} HP \n \n");
        //    }
        //
        //}
    }
}
