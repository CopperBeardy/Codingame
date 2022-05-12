using System;
using System.Collections.Generic;

public static class RockPaperScissorsSpock
{
    public static void Solve()
    {
        int N = int.Parse(Console.ReadLine());
        Player[] players = new Player[N];
        for(int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            players[i] = new Player
            {
                PlayerNumber = int.Parse(inputs[0]),
                Move = inputs[1],
                Opponents = new List<int>()
            };
        }

        players = Play(players);
        string ops = string.Empty;
        foreach(var player in players[0].Opponents)
        {
            ops += $"{player} ";
        }
        Console.WriteLine(players[0].PlayerNumber);
        Console.WriteLine(ops.TrimEnd());
    }

    private static Player[] Play(Player[] players)
    {
        bool playOn = true;
        Player[] currentPlayers = players;
        Player[] roundWinners;
        int index = 0;
        while(playOn)
        {
            roundWinners = new Player[currentPlayers.Length / 2];
            index = 0;
            for(int i = 0; i < currentPlayers.Length - 1; i += 2)
            {
                Player player1 = currentPlayers[i];
                Player player2 = currentPlayers[i + 1];

                var result = CheckMove(player1, player2);
                if(result)
                {
                    player1.Opponents.Add(player2.PlayerNumber);
                    roundWinners[index] = player1;
                } else
                {
                    player2.Opponents.Add(player1.PlayerNumber);
                    roundWinners[index] = player2;
                }
                index++;
            }
            if(roundWinners.Length == 1)
            {
                playOn = false;
            }
            currentPlayers = roundWinners;
        }

        return currentPlayers;
    }

    public static bool CheckMove(Player p1, Player p2)
    {
        //Rock(R)
        //Paper(P)
        //sCissors(C)
        //Lizard(L)
        //Spock(S)
        return p1.Move.Equals(p2.Move)
            ? p1.PlayerNumber < p2.PlayerNumber
            : (p1.Move switch
            {
                "C" => (p2.Move == "P" || p2.Move == "L"),
                "P" => (p2.Move == "S" || p2.Move == "R"),
                "R" => (p2.Move == "C" || p2.Move == "L"),
                "L" => (p2.Move == "S" || p2.Move == "P"),
                "S" => (p2.Move == "C" || p2.Move == "R"),
                _ => false,
            });
    }
}

public class Player
{
    public int PlayerNumber { get; set; }

    public string Move { get; set; }

    public List<int> Opponents { get; set; }
}