using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_";
        int N = int.Parse(Console.ReadLine());
        List<(int id, string part)> agentparts = new List<(int id, string part)>();
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int c = int.Parse(inputs[0]);
            string s = inputs[1];
            agentparts.Add((c, s));
        }

        string secretMessage = "";
        int[][] numbers = new int[N][];
        for (int j = 0; j < N; j++)
        {
            var coded = agentparts[j];          
            numbers[j]   = StringToInt(alphabet, coded);
        }





        Console.WriteLine(secretMessage);
    }

    private static int[] StringToInt(string alphabet, (int id, string part) coded)
    {
        int[] temp = new int[coded.part.Length + 1];
        temp[0] = coded.id;
        for (int i = 0; i < coded.part.Length; i++)
        {
            var ind = alphabet.IndexOf(coded.part[i]);
            temp[i + 1] = ind;
        }

        return temp;
    }


    private static int Poly(int threshold,int index,int input) 
    {
        int n = 2;
        int k = 2;

        int agent = 005;
        int agent2 = 004;

        int[] agent1code = new int[] {37,22,1 };
        int[] agent2code = new int[] {49,13,52 };






        int output = 

    }
}