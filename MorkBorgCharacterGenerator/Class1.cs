using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorkBorgCharacterGenerator
{
    public static class MorkBorg
    {
        //d4 roller
        public static int FourSidedRoller(int x)
        {
            int roll = 0;
            var rand = new Random();
            for (int i = 0; i < x; i++) 
            {
                roll += rand.Next(1, 5);
            }
            return roll;
        }

        //d6 roller
        public static int SixSidedRoller(int x)
        {
            int roll = 0;
            var rand = new Random();
            for (int i = 0; i < x; i++)
            {
                roll += rand.Next(1, 7);
            }
            return roll;
        }

        //d8 roller
        public static int EightSidedRoller(int x)
        {
            int roll = 0;
            var rand = new Random();
            for (int i = 0; i < x; i++)
            {
                roll += rand.Next(1, 9);
            }
            return roll;
        }

        //d10 roller
        public static int TenSidedRoller(int x)
        {
            int roll = 0;
            var rand = new Random();
            for (int i = 0; i < x; i++)
            {
                roll += rand.Next(1, 13);
            }
            return roll;
        }

        //d12 roller
        public static int TwelveSidedRoller(int x)
        {
            int roll = 0;
            var rand = new Random();
            for (int i = 0; i < x; i++)
            {
                roll += rand.Next(1, 12);
            }
            return roll;
        }

        //d20 roller
        public static int TwentySidedRoller(int x)
        {
            int roll = 0;
            var rand = new Random();
            for (int i = 0; i < x; i++)
            {
                roll += rand.Next(1, 21);
            }
            return roll;
        }

        //3d6 drop the lowest
        public static int DropTheLowest()
        {
            int[] roll = new int[4];

            roll[0] = SixSidedRoller(1);
            roll[1] = SixSidedRoller(1);
            roll[2] = SixSidedRoller(1);
            roll[3] = SixSidedRoller(1);

            Array.Sort(roll);

            int statRoll = roll[1] + roll[2] + roll[3];

            return statRoll;
        }

        //Ability Modifier
        public static int AbilityModifier(int abilityRoll)
        {
            if (abilityRoll >= 17)
            {
                return 3;
            }
            else if (abilityRoll >= 15)
            {
                return 2;
            }
            else if (abilityRoll >= 13)
            {
                return 1;
            }
            else if (abilityRoll >= 9)
            {
                return 0;
            }
            else if (abilityRoll >= 7)
            {
                return -1;
            }
            else if (abilityRoll >= 5)
            {
                return -2;
            }
            else
            {
                return -3;
            }
        }

        //First Possession
        public static string FirstPossession(int x)
        {
            if (x == 3)
            {
                return "a backpack for 7 normal-sized items";
            }
            else if (x == 4)
            {
                return "a sack for 10 normal-sized items";
            }
            else if (x == 5)
            {
                return "a small wagon. \n" +
                    "(You may instead choose a backpack that holds 7 normal-sized items or a sack that holds 10 normal-sized items";
            }
            else if (x == 6)
            {
                return "a donkey, not bad.\n" +
                    "(You may instead choose a wagon or a backpack that holds 7 normal-sized items or a sack that holds 10 normal-sized items";
            }
            else
            {
                return "nothing...";
            }
        }

        //Second Possession
        public static string SecondPossession(int x, int presence)
        {
            if (x == 1)
            {
                return "30 feet of rope";
            }
            else if (x == 2)
            {
                return $"{presence + 4} torches";
            }
            else if (x == 3)
            {
                return $"A lantern with oil for {presence + 6} hours";
            }
            else if (x == 4)
            {
                return "A magnesium strip";
            }
            else if (x == 5)
            {
                string scroll = RandomUncleanScroll();
                return $"A random unclean scroll: {scroll}";
            }
            else if (x == 6)
            {
                return "A sharp needle";
            }
            else if (x == 7)
            {
                return $"A medicine chest with {presence + 4} uses (stops bleeding/infection and heals d6 HP";
            }
            else if (x == 8)
            {
                return "A metal file and lockpicks";
            }
            else  if (x == 9)
            {
                return "A bear trap (Presence DR 14 to spot, d8 damage)";
            }
            else if (x == 10)
            {
                return "A bomb (sealed bottle, d10 damage";
            }
            else if (x == 11)
            {
                int doses = FourSidedRoller(1);
                return $"A bottle of red poison with {doses} doses (Toughness DR12 or d10 damage)";
            }
            else
            {
                return "A silver crucifix";
            }
        }

        //Random Unclean Scroll

        public static string RandomUncleanScroll()
        {
            int roll = TenSidedRoller(1);

            if (roll == 1)
            {
                return "Palms Open the Southern Gate";
            }
            else if (roll == 2)
            {
                return "Tongue of Eris";
            }
            else if (roll == 3)
            {
                return "Te-le-Kin-esis";
            }
            else if (roll == 4)
            {
                return "Lucy-fires Levitation";
            }
            else if (roll == 5)
            {
                return "Daemon of Capillaries";
            }
            else if (roll == 6)
            {
                return "Nine Violet Signs Unknot the Storm";
            }
            else if (roll == 7)
            {
                return "Metzhuotl Blind Your Eye";
            }
            else if (roll == 8)
            {
                return "Foul Psychopomp";
            }
            else if (roll == 9)
            {
                return "Eyelid Blinds the Mind";
            }
            else
            {
                return "Death";
            }
        }

        //ThirdPossession

        public static string ThirdPossession(int x)
        {
            if (x == 1)
            {
                int doses = FourSidedRoller(1);
                return $"A life elixer with {doses} doses (heals d6 HP and removes infection";
            }
            else if (x == 2)
            {
                return $"A random sacred scroll: "; //need random sacred scroll method
            }
            else if (x == 3)
            {
                int hp = SixSidedRoller(1) + 2;
                return $"A small, but vicious dog ({hp} HP, bite d4, only obeys you";
            }
            else if (x == 4)
            {
                int monkeyAmmount = FourSidedRoller(1);

                List<int> monkeyHP = new List<int>();
                for (int i = 0; i < monkeyAmmount; i++)
                {
                    monkeyHP.Add(FourSidedRoller(1) + 2);
                }

                string monkeyHealth = string.Join(" HP, ", monkeyHP);

                return $"{monkeyAmmount} monkey(s) that ignore but love you ({monkeyHealth} HP, punch/bite d4)";
            }
            else { return null; }
        }

    }

}