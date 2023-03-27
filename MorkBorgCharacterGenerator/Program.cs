using MorkBorgCharacterGenerator;
using System.Reflection;

//Ability Rolls
int agilityRoll = MorkBorg.DropTheLowest();
int presenceRoll = MorkBorg.DropTheLowest();
int strengthRoll = MorkBorg.DropTheLowest();
int toughnessRoll = MorkBorg.DropTheLowest();

//Ability Modifiers
int agility = MorkBorg.AbilityModifier(agilityRoll);
int presence = MorkBorg.AbilityModifier(presenceRoll);
int strength = MorkBorg.AbilityModifier(strengthRoll);
int toughness = MorkBorg.AbilityModifier(toughnessRoll);

//Starting silver/food
int silver = (MorkBorg.SixSidedRoller(2) * 10);
int food = MorkBorg.FourSidedRoller(1); 

Console.WriteLine($"One hand holds a purse filled with {silver} silvers,\n" +
    $"the other holds a water skin and {food} days worth of food.\n");
System.Threading.Thread.Sleep(2000);

//d6 Possession
int itemRoll = MorkBorg.SixSidedRoller(1);
string firstPossession = MorkBorg.FirstPossession(itemRoll);

//d12 Possession 1
itemRoll = MorkBorg.TwelveSidedRoller(1);
string secondPossession = MorkBorg.SecondPossession(itemRoll, presence);

//d12 Possession 2
string thirdPossession = MorkBorg.ThirdPossession(4);
Console.WriteLine(thirdPossession);




//intro

//string  intro = "Your soul and your silver are your own and equally easy to lose.\n" +
//        "To begin with, you are what you own...\n";

//for (int i = 0; i < intro.Length; i++)
//{
//    Console.Write(intro[i]);
//    System.Threading.Thread.Sleep(100);
//}