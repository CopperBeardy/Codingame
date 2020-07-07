using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Transactions;

/**
 * Save the Planet.
// * Use less Fossil Fuel.
// **/
//class Player
//{
//    static void Main(string[] args)
//    {
//        string[] inputs;
//        int N = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
//        for (int i = 0; i < N; i++)
//        {
//            inputs = Console.ReadLine().Split(' ');
//            int landX = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
//            int landY = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
//        }

//        // game loop
//        while (true)
//        {
//            inputs = Console.ReadLine().Split(' ');
//            int X = int.Parse(inputs[0]);
//            int Y = int.Parse(inputs[1]);
//            int HS = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative.
//            int VS = int.Parse(inputs[3]); // the vertical speed (in m/s), can be negative.
//            int F = int.Parse(inputs[4]); // the quantity of remaining fuel in liters.
//            int R = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90).
//            int P = int.Parse(inputs[6]); // the thrust power (0 to 4).

//            // Write an action using Console.WriteLine()
//            // To debug: Console.Error.WriteLine("Debug messages...");

//            inputs[6] = AdjustVerticalSpeed(VS, P).ToString();
//            // R P. R is the desired rotation angle. P is the desired thrust power.
//            Console.WriteLine($"0 {inputs[6]}");
//        }


        

//    }

//    public static int AdjustVerticalSpeed(int speed,int power)
//    {

//        if (speed < 0)
//        {
//            int absSpeed = (int)Math.Abs(speed * 1.0);
//            if (absSpeed < 40)
//            {
//                return power;
//            }
//            else
//            {
//                if (power < 4)
//                {
//                    power++;
//                }
//                return power;
//            }
//        }
//        else {
//           return power--;
//        } 


//    }


//    public int CorrectRotation(int currentAngle) 
//    {
//        if (currentAngle < 0) 
//        {
//            currentAngle += (int)Math.Abs(currentAngle * 1.0); 
//        }
//        return currentAngle;

        
//    } 
//}