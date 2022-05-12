using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CodingGame.Solutions.Solved;

public static  class RectanglePartitions
{
    public static void Solve()
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int outerWidth = int.Parse(inputs[0]);
        int outerHeight = int.Parse(inputs[1]);
        int numberOfXSplits = int.Parse(inputs[2]);
        int numberOfYSplits = int.Parse(inputs[3]);
        int totalSquares = 0;

        // Add 0 to measureOfX and MeasureOfY so the lowest repective value has a value to measure against
        List<int> xPartitions = new List<int>() { 0 };
        List<int> yPartitions = new List<int>() { 0 };

        inputs = Console.ReadLine().Split(' ');
        xPartitions.AddRange(GetPartitions(inputs, numberOfXSplits));
        xPartitions.Add(outerWidth);

        inputs = Console.ReadLine().Split(' ');
        yPartitions.AddRange(GetPartitions(inputs, numberOfYSplits));
        yPartitions.Add(outerHeight);

        List<int> AllDistancesAlongX = GetAllDimensions(xPartitions);
        List<int> AllDistancesAlongY = GetAllDimensions(yPartitions);

        totalSquares = GetSquareCount();
        int GetSquareCount()
        {
            var count = 0;
            foreach(var x in AllDistancesAlongX)
            {
                foreach(var y in AllDistancesAlongY)
                {
                    if(x == y)
                        count++;
                }
            }

            return count;
        }


        int[] GetPartitions(string[] inputs, int splitInputs)
        {
            int[] measures = new int[splitInputs];
            for(int i = 0; i < splitInputs; i++)
            {
                measures[i] = int.Parse(inputs[i]);
            }
            return measures;
        }

        List<int> GetAllDimensions(List<int> partitions)
        {
            List<int> differences = new List<int>();
            for(int i = 0; i < partitions.Count; i++)
            {
                for(int j = i + 1; j < partitions.Count; j++)
                {
                    differences.Add(partitions[j] - partitions[i]);
                }
            }
            return differences;
        }

        Console.WriteLine(totalSquares);
    }
}