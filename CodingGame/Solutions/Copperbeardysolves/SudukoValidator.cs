//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CodingGame.Solutions.Copperbeardysolves
//{
//    class SudukoValidator
//    {

//        bool valid = false;
//        int[][] MainGrid = new int[9][];
//        List<bool> results = new List<bool>();
//        int[] validNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//        for (int i = 0; i<MainGrid.Length; i++)
//        {
//            string[] inputs = Console.ReadLine().Split(' ');
//        int[] line = new int[MainGrid.Length];
//            for (int j = 0; j<MainGrid.Length; j++)
//            {
//                line[j] = int.Parse(inputs[j]);
//    }
//    MainGrid[i] = line;
//        }

//// check each row  is valid
//for (int i = 0; i < MainGrid.Length; i++)
//{
//    foreach (var item in validNumbers)
//    {
//        results.Add(MainGrid[i].Contains(item));
//    }

//}


//// check each column is valid

//int[][] temp = new int[MainGrid.Length][];
//for (int i = 0; i < MainGrid.Length; i++)
//{
//    int[] line = MainGrid[i];
//    for (int j = 0; j < line.Length; j++)
//    {
//        int[] t = temp[j] ?? (new int[MainGrid.Length]);
//        t[i] = line[j];
//        temp[j] = t;
//    }

//}
//for (int i = 0; i < temp.Length; i++)
//{
//    foreach (var item in validNumbers)
//    {
//        results.Add(temp[i].Contains(item));
//    }
//}



//for (int k = 0; k < MainGrid.Length; k += 3)
//{
//    for (int j = 0; j < MainGrid.Length; j += 3)
//    {
//        int[] block = new int[MainGrid.Length];
//        int count = 0;
//        for (int m = j; m < j + 3; m++)
//        {

//            for (int l = k; l < k + 3; l++)
//            {
//                block[count] = MainGrid[l][m];
//                count++;
//            }
//        }

//        for (int i = 0; i < block.Length; i++)
//        {
//            foreach (var item in validNumbers)
//            {
//                results.Add(block.Contains(item));
//            }
//        }
//    }

//}
//valid = !results.Contains(false);

//Console.WriteLine(valid.ToString().ToLower());
//    }
//    }
//}
