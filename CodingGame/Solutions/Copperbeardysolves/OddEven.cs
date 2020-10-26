//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CodingGame.Solutions.Copperbeardysolves
//{
//    class OddEven
//    {
//        string[] inputs;
//        inputs = Console.ReadLine().Split(' ');
//        int N = int.Parse(inputs[0]);
//        int T = int.Parse(inputs[1]);

//        Dictionary<int, List<int>> coins = new Dictionary<int, List<int>>();


//        int[][] lineInput = new int[T][];
//         for (int i = 0; i<T; i++)
//        {
//            inputs = Console.ReadLine().Split(' ');
//        List<int> temp = new List<int>();
//            for (int j = 0; j<N; j++)
//            {                
//                temp.Add(int.Parse(inputs[j]));
//            }
//    lineInput[i] = temp.ToArray();

//        }
//List<int> possibleEvenNumbers = new List<int>();
//for (int i = 1; i <= 2 * N; i++)
//{
//    if (i % 2 == 0)
//    {
//        possibleEvenNumbers.Add(i);
//    }
//    else
//    {
//        coins.Add(i, new List<int>());
//        //   coinResults.Add((i, new List<int>()));
//    }
//}

//foreach (var line in lineInput)
//{
//    List<int> evenList = line.Where(x => x % 2 == 0).ToList();
//    List<int> oddList = line.Where(x => x % 2 != 0).ToList();

//    foreach (var odd in oddList)
//    {


//        List<int> current = coins[odd];

//        foreach (var even in evenList)
//        {
//            if (!current.Contains(even))
//            {
//                current.Add(even);
//            }
//        }

//    }

//}


///////
//while (true)
//{

//}
//List<(int odd, int even)> values = new List<(int odd, int even)>();






//var zx = 12;



//Console.WriteLine("2 4 6...");
//    }
//}
