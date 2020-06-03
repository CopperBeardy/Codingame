using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Grab the pellets as fast as you can!
 **/
//class Player
//{
//    static void Main(string[] args)
//    {
//        string[] inputs;
//        inputs = Console.ReadLine().Split(' ');
//        int width = int.Parse(inputs[0]); // size of the grid
//        int height = int.Parse(inputs[1]); // top left corner is (x=0, y=0)
//                                           //  string[] Grid = new string[height];
//                                           //  Pellet[] Pellets;
//        for (int i = 0; i < height; i++)
//        {
//            string row = Console.ReadLine(); // one line of the grid: space " " is floor, pound "#" is wall
//                                             //  Grid[i] = row;
//        }

//        // game loop
//        while (true)
//        {
//            inputs = Console.ReadLine().Split(' ');
//            int myScore = int.Parse(inputs[0]);
//            int opponentScore = int.Parse(inputs[1]);
//            int visiblePacCount = int.Parse(Console.ReadLine()); // all your pacs and enemy pacs in sight
//                                                                 //     int myX = 0;
//                                                                 //    int myY = 0;
//            for (int i = 0; i < visiblePacCount; i++)
//            {
//                inputs = Console.ReadLine().Split(' ');
//                int pacId = int.Parse(inputs[0]); // pac number (unique within a team)
//                bool mine = inputs[1] != "0"; // true if this pac is yours
//                /* if(mine)
//                 {
//                   //  myX = int.Parse(inputs[2]);
//                    // myY = int.Parse(inputs[3]);
//                 } else
//                 {*/
//                int x = int.Parse(inputs[2]); // position in the grid
//                int y = int.Parse(inputs[3]); // position in the grid
//                //}

//                string typeId = inputs[4]; // unused in wood leagues
//                int speedTurnsLeft = int.Parse(inputs[5]); // unused in wood leagues
//                int abilityCooldown = int.Parse(inputs[6]); // unused in wood leagues
//            }
//            int visiblePelletCount = int.Parse(Console.ReadLine()); // all pellets in sight

//            // reset pellet array
//            //  Pellets = new Pellet[visiblePelletCount];
//            //for (int i = 0; i < visiblePelletCount; i++)
//            //{
//            //    inputs = Console.ReadLine().Split(' ');
//            //    Pellet pellet = new Pellet();
//            //    pellet.X = int.Parse(inputs[0]);
//            //    pellet.Y = int.Parse(inputs[1]);
//            //    pellet.PointValue = int.Parse(inputs[2]); // amount of points this pellet is worth
//            //    Pellets[i] = pellet;
//            //}


//            //    string currentRow = Grid[myY];
//            //   var pelletsOnRow = Pellets.Where(p => p.Y == myY);




//            // Write an action using Console.WriteLine()
//            // To debug: Console.Error.WriteLine("Debug messages...");
//            int MoveToX = 0;
//            int MoveToY = 0;

//            string output = $"MOVE 0 {MoveToX} {MoveToY} ";
//            Console.WriteLine(output); // MOVE <pacId> <x> <y>
//        }
//    }

//    //public class Pellet
//    //{
//    //    public int X { get; set; }
//    //    public int Y { get; set; }
//    //    public int PointValue { get; set; }
//    //}
//}