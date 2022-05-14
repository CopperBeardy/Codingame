using System;
using System.Collections.Generic;


public static class OneDSpreadsheet
{
    public static   List<Sheet> Sheets = new List<Sheet>();
    public static int[] Results ;

    public static void Solve()
    {
        int N = int.Parse(Console.ReadLine());
        Results = new int[N];

        for(int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            Sheets.Add(new Sheet { Operation = inputs[0], ArgOne = inputs[1], ArgTwo = inputs[2] });
        }

        // iterate throught the instuctions
        for(int i = 0; i < N; i++)
        {
            Console.WriteLine(GetResult(i));
        }
    }

    public static int GetResult(int index)
    {
        if(Results[index] != 0)   return Results[index];
        var sheet = Sheets[index];
        var arg = sheet.ArgOne;
        var arg2 = sheet.ArgTwo;

        int argValue1 = arg.Contains("$") ? ResolveReference(arg) : int.Parse(arg);
        int argValue2 = arg2.Equals("_") ? 0 : arg2.Contains("$") ? ResolveReference(arg2) : int.Parse(arg2);
        switch(sheet.Operation)
        {
            case "VALUE":
                Results[index] = argValue1;
                break;
            case "ADD":
                Results[index] = argValue1 + argValue2;
                break;
            case "SUB":
                Results[index] = argValue1 - argValue2;
                break;
            case "MULT":
                Results[index] = argValue1 * argValue2;
                break;
        }
        return Results[index];
    }

    public static int ResolveReference(string val) => GetResult(int.Parse(val.Substring(1)));
}


public class Sheet
{
    public string Operation { get; set; }

    public string ArgOne { get; set; }

    public string ArgTwo { get; set; }
}
