using System;
using System.Collections.Generic;

public class MarsLander
{
    public static void Solve()
    {
        string[] inputs;
        int N = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
        for(int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int landX = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
            int landY = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
        }

        // game loop
        while(true)
        {
            inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int HS = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative.
            int VS = int.Parse(inputs[3]); // the vertical speed (in m/s), can be negative.
            int F = int.Parse(inputs[4]); // the quantity of remaining fuel in liters.
            int R = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90).
            int P = int.Parse(inputs[6]); // the thrust power (0 to 4).

            inputs[6] = AdjustVerticalSpeed(VS, P).ToString();
            // R P. R is the desired rotation angle. P is the desired thrust power.
            Console.WriteLine($"0 {inputs[6]}");
        }
    }

    public static int AdjustVerticalSpeed(int speed, int power)
    {
        if(speed < 0)
        {
            int absSpeed = (int)Math.Abs(speed * 1.0);
            if(absSpeed < 40)
            {
                return power;
            } else
            {
                if(power < 4)
                {
                    power++;
                }
                return power;
            }
        } else
        {
            return power--;
        }
    }


    public int CorrectRotation(int currentAngle)
    {
        if(currentAngle < 0)
        {
            currentAngle += (int)Math.Abs(currentAngle * 1.0);
        }
        return currentAngle;
    }
}

public class LanderB
{
    public static void Solve()
    {
        string[] inputs;
        int N = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
        List<(int x, int y)> land = new List<(int x, int y)>();
        for(int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int landX = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
            int landY = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
            land.Add((landX, landY));
        }
        // centerOfLandingZone is the center point of a flat area 
        // along the x axis that has 500 units on either side
        int centerOfLandingZone = FindSafeLandingZone(land);

        // game loop
        while(true)
        {
            inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int HS = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative.
            int VS = int.Parse(inputs[3]); // the vertical speed (in m/s), can be negative.
            int F = int.Parse(inputs[4]); // the quantity of remaining fuel in liters.
            int R = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90).
            int P = int.Parse(inputs[6]); // the thrust power (0 to 4).

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // R P. R is the desired rotation angle. P is the desired thrust power.
            inputs[6] = AdjustVerticalSpeed(VS, P).ToString();
            inputs[5] = AdjustRotation(HS, R, X, centerOfLandingZone, land).ToString();

            // R P. R is the desired rotation angle. P is the desired thrust power.
            Console.WriteLine($"{inputs[5]} {inputs[6]}");
        }
    }

    private static int AdjustRotation(int hS, int r, int landerX, int safeZone, List<(int x, int y)> land)
    {
        int rightSide = safeZone - 100;
        int leftSide = safeZone + 1100;
        if(landerX < rightSide && hS < 60)
        {
            return -25;
        } else if(landerX > leftSide && hS > -60)
        {
            return 25;
        }

        if(hS < 10 && hS > -10)
        {
            return 0;
        } else if(hS > 10)
        {
            return 45;
        } else
        {
            return -45;
        }
    }

    private static int FindSafeLandingZone(List<(int x, int y)> land)
    {
        for(int i = 0; i < land.Count - 1; i++)
        {
            if(land[i].y == land[i + 1].y)
            {
                return land[i].x;
            }
        }
        return 0;
    }

    public static int AdjustVerticalSpeed(int speed, int power)
    {
        if(speed < 0)
        {
            int absSpeed = (int)Math.Abs(speed * 1.0);
            if(absSpeed < 10)
            {
                return power;
            } else
            {
                if(power < 4)
                {
                    power++;
                }
                return power;
            }
        } else
        {
            return power--;
        }
    }
}