//using System;
//using System.Linq;
//using System.IO;
//using System.Text;
//using System.Collections;
//using System.Collections.Generic;

///**
// * Auto-generated code below aims at helping you parse
// * the standard input according to the problem statement.
// **/
//class Solution
//{
//    static void Main(string[] args)
//    {
//        int N = int.Parse(Console.ReadLine());
//        string[] lines = new string[N];
//        for (int i = 0; i < N; i++)
//        {
//            lines[i] = Console.ReadLine();
//        }


//        for (int i = 0; i < N; i++)
//        {
//            char[] line = lines[i].ToCharArray();


//            for (int j = 0; j < line.Length; j++)
//            {
//                if (isF(line[j]))
//                {
//                    if (j < line.Length - 2)
//                    {

//                        line[j] = '.';
//                        line[j + 1] = '.';
//                        line[j + 2] = 'd';
//                    }
//                    else if (j < line.Length - 1)
//                    {
//                        line[j] = '.';
//                        line[j + 1] = 'd';
//                    }
//                    else
//                    {
//                        line[j] = 'd';
//                    }
//                }
//            }
//            Console.WriteLine(line.Where(x => x == 'd').Count());
//        }
//    }

//    public static bool isF(char x) => x.Equals('f');

//}