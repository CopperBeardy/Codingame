using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ASTEROIDS
{
    public static void Solve()
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);
        int T1 = int.Parse(inputs[2]);
        int T2 = int.Parse(inputs[3]);
        int T3 = int.Parse(inputs[4]);
        for(int i = 0; i < H; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string firstPictureRow = inputs[0];
            string secondPictureRow = inputs[1];
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("answer");
    }
}
