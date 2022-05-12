using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
/**
 * For each test case, print "Possible" if all 3 frogs can eventually meet, "Impossible" otherwise.
 *  x    y    jump 
 *  7    0     1
 *  2   -6     1
 *  -1   0     2
 **/
public class JumpingFrogs
{
    public static void Solve()
    {
        Frog[] frogs = new Frog[3];
        for(int i = 0; i < 3; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            frogs[i] = new Frog { x = int.Parse(inputs[0]), y = int.Parse(inputs[1]), move = int.Parse(inputs[2]), };
        }

        Position[] frog1 = EndPositons(frogs[0]);
        Position[] frog2 = EndPositons(frogs[1]);
        Position[] frog3 = EndPositons(frogs[2]);

        foreach(var frog in frog1)
        {
            Console.Write($"{frog.x},{frog.y}  ");
        }
        Console.WriteLine();
        foreach(var frog in frog2)
        {
            Console.Write($"{frog.x},{frog.y}  ");
        }
        Console.WriteLine();
        foreach(var frog in frog3)
        {
            Console.Write($"{frog.x},{frog.y}   ");
        }
        string result = CheckPositions(frog1, frog2, frog3);

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }

    static string CheckPositions(Position[] frog1, Position[] frog2, Position[] frog3)
    {
        bool possible = false;
        IEnumerable<Position> result = frog1.Intersect(frog2);
        if(result.Count() > 0)
        {
            IEnumerable<Position> temp = frog1.Intersect(frog3);
            if(temp.Count() > 0)
            {
                return "possible";
            }
        }
        return "impossible";
    }

    static Position[] EndPositons(Frog frog)
    {
        Position[] endPos = new Position[9];

        endPos[0] = new Position { x = frog.x, y = frog.y }; //startpostion
        endPos[1] = new Position { x = frog.x + frog.move, y = frog.y };// +x
        endPos[2] = new Position { x = frog.x - frog.move, y = frog.y };// -x
        endPos[3] = new Position { x = frog.x, y = frog.y + frog.move };// +y
        endPos[4] = new Position { x = frog.x, y = frog.y - frog.move };// -y
        endPos[5] = new Position { x = frog.x + frog.move, y = frog.y - frog.move };// +x -y
        endPos[6] = new Position { x = frog.x + frog.move, y = frog.y + frog.move };// +x +y
        endPos[7] = new Position { x = frog.x - frog.move, y = frog.y - frog.move };// -x -y
        endPos[8] = new Position { x = frog.x - frog.move, y = frog.y + frog.move };// -x +y

        return endPos;
    }
}

class Position
{
    public int x { get; set; }

    public int y { get; set; }
}

class Frog
{
    public int x { get; set; }

    public int y { get; set; }

    public int move { get; set; }
}