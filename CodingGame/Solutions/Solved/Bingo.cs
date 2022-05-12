using System;
using System.Collections.Generic;
using System.Linq;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
public static class Bingo
{
    public static void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        List<List<int>> cards = new List<List<int>>();
        for(int i = 0; i < n; i++)
        {
            List<int> c = new List<int>();
            for(int j = 0; j < 5; j++)
            {
                c.AddRange(ParseString(Console.ReadLine()));
            }
            cards.Add(c);
        }

        List<int> calledNumbers = ParseString(Console.ReadLine());

        int quickestLine = 0;
        int quickestFullhouse = 0;

        foreach(var card in cards)
        {
            (int line, int house) result = MarkCards(card, calledNumbers);
            switch(quickestLine)
            {
                case 0:
                    quickestLine = result.line;
                    break;
                default:
                    if(result.line < quickestLine)
                    {
                        quickestLine = result.line;
                    }

                    break;
            }
            switch(quickestFullhouse)
            {
                case 0:
                    quickestFullhouse = result.house;
                    break;
                default:
                    if(result.house < quickestFullhouse)
                    {
                        quickestFullhouse = result.house;
                    }

                    break;
            }
        }

        Console.WriteLine(quickestLine);
        Console.WriteLine(quickestFullhouse);
    }

    private static (int line, int house) MarkCards(List<int> card, List<int> calledNumbers)
    {
        int CounterForLine = 0;
        int CounterForFullHouse = 0;
        Win forWin = Win.None;
        (int line, int house) totals = (0, 0);
        for(int i = 0; i < calledNumbers.Count; i++)
        {
            if(forWin == Win.None)
            {
                CounterForLine++;
            }

            for(int j = 0; j < 5; j++)
            {
                if(card.Contains(calledNumbers[i]))
                {
                    card[card.IndexOf(calledNumbers[i])] = 0;
                }
                forWin = CheckResult(card, forWin);
            }
            CounterForFullHouse++;
            if(forWin == Win.House)
            {
                break;
            }
        }

        totals.line = CounterForLine;
        totals.house = CounterForFullHouse;
        return totals;
    }

    private static Win CheckResult(List<int> card, Win win)
    {
        if(win != Win.Line)
        {
            if(CheckLine(card, 0, 1) || CheckLine(card, 0, 5) || CheckLine(card, 0, 6) || CheckLine(card, 4, 6))
            {
                win = Win.Line;
            }
        } else if(win == Win.Line)
        {
            if(CheckHouse(card))
            {
                win = Win.House;
            }
        }
        return win;
    }

    private static bool CheckLine(List<int> card, int start, int increment)
    {
        var counter = 0;
        for(int i = start; i < 5; i++)
        {
            for(int j = i; j < card.Count; j += increment)
            {
                if(card[j] == 0)
                {
                    counter++;
                    continue;
                }
                counter = 0;
                break;
            }
            if(counter == 5)
            {
                return true;
            }
        }
        return false;
    }

    private static bool CheckHouse(List<int> card) => card.ToArray().Sum() == 0;

    private static List<int> ParseString(string row)
    {
        string[] line = row.Split(' ');
        List<int> temp = new List<int>();
        temp.AddRange(line.Select(lineItem => int.Parse(lineItem)));
        return temp;
    }
}

public enum Win
{
    None,
    Line,
    House
}
