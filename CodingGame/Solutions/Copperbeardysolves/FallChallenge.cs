//using System;
//using System.Linq;
//using System.IO;
//using System.Text;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;

///**
// * Auto-generated code below aims at helping you parse
// * the standard input according to the problem statement.
// **/
//class Player
//{
//    static void Main(string[] args)
//    {
//        string[] inputs;

//        // game loop
//        while (true)
//        {
//            string action = string.Empty;
//            Inventory[] inventories = new Inventory[2];
//            int actionCount = int.Parse(Console.ReadLine());
//            Recipe[] recipes = new Recipe[actionCount];
//            for (int i = 0; i < actionCount; i++)
//            {
//                inputs = Console.ReadLine().Split(' ');
//                recipes[i] = new Recipe()
//                {
//                    ActionId = int.Parse(inputs[0]),
//                    ActionType = inputs[1],
//                    DeltaZero = int.Parse(inputs[2]),
//                    DeltaOne = int.Parse(inputs[3]),
//                    DeltaTwo = int.Parse(inputs[4]),
//                    DeltaThree = int.Parse(inputs[5]),
//                    Price = int.Parse(inputs[6]),
//                    TomeIndex = int.Parse(inputs[7]),
//                    TaxCount = int.Parse(inputs[8]),
//                    Castable = inputs[9] != "0",
//                    Repeatable = inputs[10] != "0"
//                };
//            }

//            for (int i = 0; i < 2; i++)
//            {
//                inputs = Console.ReadLine().Split(' ');
//                inventories[i] = new Inventory()
//                {
//                    InvZero = int.Parse(inputs[0]),
//                    InvOne = int.Parse(inputs[1]),
//                    InvTwo = int.Parse(inputs[2]),
//                    InvThree = int.Parse(inputs[3]),
//                    Score = int.Parse(inputs[4])
//                };
//            }

//            Inventory inv = inventories[0];
//            var recs = recipes.Where(e => e.ActionType.Equals("BREW")).OrderByDescending(e => e.Price).ToArray();

//            foreach (var recipe in recs)
//            {
//                if ((inv.InvZero + recipe.DeltaZero > -1)
//                    && (inv.InvOne + recipe.DeltaOne > -1)
//                    && (inv.InvTwo + recipe.DeltaTwo > -1)
//                    && (inv.InvThree + recipe.DeltaThree > -1))
//                {
//                    action = $"BREW {recipe.ActionId} ";
//                    break;
//                }
//            }

//            Recipe[] spells = recipes.Where(e => e.ActionType.Equals("CAST") && e.Castable.Equals(true)).ToArray();
//            if (string.IsNullOrEmpty(action) && spells.Length == 0)
//            {
//                action = "REST";

//            }
//            else if (string.IsNullOrEmpty(action))
//            {
//                //for (int i = 0; i < spells.Length; i++)
//                //{
//                //    for (int j = 0; j < recipes.Length; j++)
//                //    {
//                //        Inventory ing = new Inventory()
//                //        {
//                //            InvZero = recipes[j].DeltaZero + spells[i].DeltaZero + inventories[0,
//                //            InvOne = recipes[j].DeltaOne + spells[i].DeltaOne,
//                //            InvTwo = recipes[j].DeltaTwo + spells[i].DeltaTwo,
//                //            InvThree = recipes[j].DeltaThree + spells[i].DeltaThree,
//                //        }                     
//                //    }

//                //}
//                for (int i = 0; i < spells.Length; i++)
//                {
//                    if ((inv.InvZero + spells[i].DeltaZero > -1)
//                        && (inv.InvOne + spells[i].DeltaOne > -1)
//                        && (inv.InvTwo + spells[i].DeltaTwo > -1)
//                        && (inv.InvThree + spells[i].DeltaThree > -1))
//                    {

//                        action = $"CAST {spells[i].ActionId} 1";
//                        break;


//                    }
//                }

//            }


//            if (string.IsNullOrEmpty(action))
//            {
//                action = "WAIT";
//            }
//            Console.Error.WriteLine(action);

//            // Write an action using Console.WriteLine()
//            // To debug: Console.Error.WriteLine("Debug messages...");


//            // in the first league: BREW <id> | WAIT; later: BREW <id> | CAST <id> [<times>] | LEARN <id> | REST | WAIT
//            Console.WriteLine(action);
//        }
//    }

//}

//public class Inventory
//{
//    public int InvZero { get; set; }
//    public int InvOne { get; set; }
//    public int InvTwo { get; set; }
//    public int InvThree { get; set; }
//    public int Score { get; set; }
//}

//public class Recipe
//{
//    public int ActionId { get; set; } // the unique ID of this spell or recipe
//    public string ActionType { get; set; } // in the first league: BREW; later: CAST, OPPONENT_CAST, LEARN, BREW
//    public int DeltaZero { get; set; } // tier-0 ingredient change
//    public int DeltaOne { get; set; } // tier-1 ingredient change
//    public int DeltaTwo { get; set; } // tier-2 ingredient change
//    public int DeltaThree { get; set; } // tier-3 ingredient change
//    public int Price { get; set; } // the price in rupees if this is a potion
//    public int TomeIndex { get; set; } // in the first two leagues: always 0; later: the index in the tome if this is a tome spell, equal to the read-ahead tax; For brews, this is the value of the current urgency bonus
//    public int TaxCount { get; set; } // in the first two leagues: always 0; later: the amount of taxed tier-0 ingredients you gain from learning this spell; For brews, this is how many times you can still gain an urgency bonus
//    public bool Castable { get; set; } // in the first league: always 0; later: 1 if this is a castable player spell
//    public bool Repeatable { get; set; } // for the first two leagues: always 0; later: 1 if this is a repeatable player spell


//}