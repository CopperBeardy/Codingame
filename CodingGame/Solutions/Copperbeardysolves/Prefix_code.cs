//using System;
//using System.Collections.Generic;

//class Solution
//{
//    static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        Dictionary<string, char> prefixes = new Dictionary<string, char>();
//        for (int i = 0; i < n; i++)
//        {
//            string[] inputs = Console.ReadLine().Split(' ');
//            prefixes.Add(inputs[0], Convert.ToChar(int.Parse(inputs[1])));
//        }
//        string toDecode = Console.ReadLine();
//        string output = "";
//        int lastFailIndex = 0;

//        for (int currentIndex = 0; currentIndex < toDecode.Length; currentIndex++)
//        {
//            int keyMatchFails = 0;
//            string s;
//            foreach (var item in prefixes)
//            {
//                int keyLength = item.Key.Length;

//                s = currentIndex + keyLength <= toDecode.Length
//                    ? toDecode.Substring(currentIndex, keyLength) : "";

//                if (s.Equals(item.Key))
//                {
//                    output += item.Value;
//                    currentIndex += keyLength - 1;
//                    break;
//                }
//                else
//                {
//                    keyMatchFails++;
//                    lastFailIndex = currentIndex;
//                }
//            }
//            if (keyMatchFails.Equals(n))
//            {
//                output = string.Empty;
//                break;
//            }
//        }

//        Console.WriteLine(string.IsNullOrEmpty(output) ? $"DECODE FAIL AT INDEX {lastFailIndex}" : output);
//    }
//}