using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamage_Console
{
    internal class Program
    {
        public static SwordDamage sword = new SwordDamage();
        public static Random randomizer = new Random();

        static void Main(string[] args)
        {
            int[] DiceRolls = new int[3];
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming 3 for both, anything else to quit: ");
                char input = Console.ReadKey(false).KeyChar;
                Console.Write("\n");

                DiceRolls[0] = randomizer.Next(1, 7);
                DiceRolls[1] = randomizer.Next(1, 7);
                DiceRolls[2] = randomizer.Next(1, 7);
                sword.Roll = DiceRolls.Sum();

                if (input == '0')
                {
                    Prompt();
                }
                else if (input == '1' || input == '3')
                {
                    sword.SetMagic(true);
                    Prompt();
                }

                else if (input == '2' || input == '3')
                {
                    sword.SetFlaming(true);
                    Prompt();
                }
                else
                {
                    //sword.SetFlaming(false);
                    //sword.SetMagic(false);
                    return;
                }

            }

            void Prompt()
            {
                Console.WriteLine($"Rolled {DiceRolls.Sum()} for {sword.Damage} \n \n");
            }

        }
    }
}
