using System;

public static class TheExperienceForCreatingPuzzles
{
    public static void Solve()
    {
        int level = int.Parse(Console.ReadLine());
        int xp = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        N = N * 300;

        while(N >= xp)
        {
            N -= xp;
            level++;
            xp = CalculateXp(level);
        }
        xp -= N;
        Console.WriteLine(level);
        Console.WriteLine(Math.Abs(xp));
    }

    public static int CalculateXp(int currentLevel) => (int)Math.Floor(currentLevel * Math.Sqrt(currentLevel) * 10);
}