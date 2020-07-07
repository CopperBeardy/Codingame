//using System;
//using System.Linq;
//using System.IO;
//using System.Text;
//using System.Collections;
//using System.Collections.Generic;
//using System.Threading;
//using System.Linq.Expressions;
//using System.Runtime.Serialization.Formatters;

///**
// * Auto-generated code below aims at helping you parse
// * the standard input according to the problem statement.
// **/
//class Player
//{
//    static void Main(string[] args)
//    {
//        LandingArea  StartEndLanding;
//        string[] inputs = new string[7000];
//        int surfaceN = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
//        for (int i = 0; i < surfaceN; i++)
//        {
//            inputs = Console.ReadLine().Split(' ');
//            int landX = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
//            int landY = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
//        }

//        StartEndLanding =  FindLandingArea(inputs);
//        // game loop
//        while (true)
//        {
//            inputs = Console.ReadLine().Split(' ');
//            int X = int.Parse(inputs[0]);
//            int Y = int.Parse(inputs[1]);
//            int hSpeed = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative.
//            int vSpeed = int.Parse(inputs[3]); // the vertical speed (in m/s), can be negative.
//            int fuel = int.Parse(inputs[4]); // the quantity of remaining fuel in liters.
//            int rotate = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90).
//            int power = int.Parse(inputs[6]); // the thrust power (0 to 4).

//            var adjust = CheckPosition(Y,StartEndLanding);
//            // Write an action using Console.WriteLine()
//            // To debug: Console.Error.WriteLine("Debug messages...");
//            inputs[5] = CorrectRotation(rotate,adjust).ToString();
//            inputs[6] = AdjustVerticalSpeed(vSpeed, power).ToString();
//            // R P. R is the desired rotation angle. P is the desired thrust power.
//            Console.WriteLine($"{inputs[5]} {inputs[6]}");
//        }




//    }

//    public static LandingArea FindLandingArea(string[] inputs)
//    {
//        LandingArea zone = new LandingArea();


//        string values ="";
//        //create a 1000 length 0 string
//        string lookingFor = "";
//        for (int i = 0; i < 1000; i++)
//        {
//            lookingFor += "0";
//        }
//        for (int i = 0; i < inputs.Length; i++)
//        {
//            values += inputs[i];
//        }
//        zone.Start = values.IndexOf(lookingFor);
//        zone.End = zone.Start + 1000;

//        return zone;

//    }

//    public static int AdjustVerticalSpeed(int speed, int power)
//    {

//        if (speed < 0)
//        {
//            int absSpeed = (int)Math.Abs(speed * 1.0);
//            if (absSpeed < 40)
//            {
//                if (power > 0) 
//                {
//                    power--;
//                }
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
//        else
//        {
//            return power--;
//        }


//    }


//    public static string CheckPosition(int Y,LandingArea landingArea)        
//    { string Adjust = "None";
//        if (Y < landingArea.Start )
//        {
//            Adjust = "Left";
//        }
//        else if (Y > landingArea.End)
//        {
//            Adjust = "Right";
//        }
//        return Adjust;
//    }

//    public static int HorizontalThrust,


//    public static int CorrectRotation(int currentAngle,string adjust)
//    {
//        if (!adjust.Equals("None"))
//        {
//            if (currentAngle < 0)
//            {
//                currentAngle += 15;
//            }
//            else if (currentAngle > 0)
//            {
//                currentAngle -= 15;
//            }
//        }
//        return currentAngle;
//    }



//    public class LandingArea 
//    {
//        public int Start { get; set; }
//        public int End { get; set; }
//    }
//}
