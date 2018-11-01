using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Program
    {
        /// <summary>
        /// Creates a list of potential items that can be found in the game.
        /// </summary>
        public List<Item> PossibleItems = new List<Item>();
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("Quest for Shoes!");
            Console.WriteLine("******************");

            Console.WriteLine("0. New Game");
            Console.WriteLine("1. Load Game");
            Console.WriteLine("2. Exit");

            Console.WriteLine("Please select and option");
            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    return;
                case "1":
                    return;
                case "2":
                    return;
            }
            /// <summary>
            /// Initializes the items with their values and then adds them into the List.
            /// </summary>
            
            private void InitializeItems()
            {
                Item Sword = new Item()
                {
                    name = "Sword",
                    value = 1,
                    Type = ItemType.Weapon,
                    Modifier = 1,
                };
                PossibleItems.Add(Sword);

                Item Potion = new Item()
                {
                    name = "Potion",
                    value = 1,
                    Type = ItemType.Consumable,
                    Modifier = 3,
                };
                PossibleItems.Add(Potion);

                Item Chainmail = new Item()
                {
                    name = "",
                    value = 1,
                    Type = ItemType.Armor,
                    Modifier = 2,
                };
                PossibleItems.Add(Chainmail);

                Item BroadSword = new Item()
                {
                    name = "BroadSword",
                    value = 1,
                    Type = ItemType.Weapon,
                    Modifier = 3,
                };
                PossibleItems.Add(BroadSword);
            }
        }
    }
}

/* Classes: Player, Enemy, NPC, Menu, Main Menu, Attack, Dodge

Player:
Health - Property (if Health = 0 GAME OVER)
Strength - Property
Speed - Property
Weapon - Property

NPC:
Buy - Method
Sell - Method
Balance - Balance

Menu: 
Save - Method
Attack: Math to subtract strength from health - Method
Weapon: Adds permanently to strength - Method
Armor: Adds permanently to Health - Method
Dodge: A percentage chance for an enemy attack to completely miss (generate random number and if within given range, attack is void)

Main Menu:
New Game
Load Game
Exit

   Possible Example:
A man lies in the road, what do you do?
   1. Investigate
   2. Go around

Option 1
The man is dead and a satchel of gold lies next to him. What do you do?
   1. Investigate further
   2. Pocket Gold
   3. Check Surroundings

Option 2 
You walk into the brush avoiding the man lying in the road, you hear voices in the distance. What do you do?
   1. Go in the direction of the voices
   2. Hide in a nearby bush

**Possibly have all options and their outcomes in an array/class which can be referenced by other classes**

Main Menu
   New Game
   Load Game
   Exit
       Menu
Story Unfolds
*/
