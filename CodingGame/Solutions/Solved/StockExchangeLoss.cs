using System;

public static class StockExchange
{
    public static void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int[] values = new int[n];
        for(int i = 0; i < n; i++)
        {
            values[i] = int.Parse(inputs[i]);
        }

        int loss = 0;
        int difference = 0;
        foreach(var current in values)
        {
            difference = Math.Min(difference, current - loss);
            loss = Math.Max(loss, current);
        }

        int CurrentLargestLoss = 0;

        //for (int i = 0; i < values.Length; i++)
        //{
        //    int currentNumber = values[i];
        //    int lowestNumber = currentNumber;

        //    for (int j = i + 1; j < values.Length; j++)
        //    {
        //        int nextNumber = values[j];
        //        if (nextNumber >= currentNumber)
        //        {
        //            i = j - 1;
        //            break;
        //        }
        //        else if (nextNumber - currentNumber < CurrentLargestLoss)
        //        {
        //            CurrentLargestLoss = nextNumber - currentNumber;
        //        }
        //    }
        //}

        Console.WriteLine(difference);
    }
}