using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codingame.com/training/easy/equivalent-resistance-circuit-building
public static class EquivalentResistanceCircuitBuilding
{
    public static void Solve()
    {
        int N = int.Parse(Console.ReadLine());
        List<(string letter, double value)> resistors = new List<(string, double)>();

        for(int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            resistors.Add((inputs[0], double.Parse(inputs[1])));
        }
        string circuit = Console.ReadLine();

        foreach(var resistor in resistors)
        {
            circuit = circuit.Replace($"{resistor.letter}", $"{resistor.value}");
        }

        var result = ParseCircuit(circuit);
        Console.WriteLine(result.ToString("0.0"));
    }

    public static double ParseCircuit(string circuit)
    {
        var resistorType = circuit[0];
        var subCircuit = circuit.Substring(1, circuit.Length - 2);
        while(subCircuit.Contains("(") || subCircuit.Contains("]"))
        {
            if(subCircuit.Contains("("))
            {
                var v = ResolveBrackets(subCircuit.Trim(), '(', ')');
                var v2 = ParseCircuit(v);
                subCircuit = subCircuit.Replace($"{v}", $"{v2}");
            }
            if(subCircuit.Contains("["))
            {
                var v = ResolveBrackets(subCircuit.Trim(), '[', ']');
                var v2 = ParseCircuit(v);
                subCircuit = subCircuit.Replace($"{v}", $"{v2}");
            }
        }

        double result = 0;
        var values = subCircuit.Split(' ').ToList();
        if(resistorType == '[')
        {
            result = ParallelResistanceSum(values);
        } else
        {
            result = SumValues(values);
        }

        return result;
    }

    static string ResolveBrackets(string subCircuit, char bracketOpen, char bracketClose)
    {
        var startIndex = 0;
        var endIndex = subCircuit.Length;
        var openBracket = 0;
        for(int i = 0; i < subCircuit.Length; i++)
        {
            if(subCircuit[i] == bracketOpen)
            {
                openBracket++;
                startIndex = i;
            } else if(subCircuit[i] == bracketClose)
            {
                endIndex = i;
                break;
            }
            if(openBracket > 1)
            {
                openBracket--;
                startIndex = i;
            }
        }
        var inner = subCircuit.Substring(startIndex, endIndex - startIndex + 1);
        if(inner.Contains(bracketOpen))
        {
            return inner;
        }
        return string.Empty;
    }


    public static List<double> GetValues(List<string> valuesToMatch)
    {
        var values = new List<double>();
        values.AddRange(valuesToMatch.Where(v => (v != string.Empty) && (v != " ")).Select(v => double.Parse(v)));
        return values;
    }

    public static double SumValues(List<string> circuitValues) => GetValues(circuitValues).Sum();

    public static double ParallelResistanceSum(List<string> circuitValues)
    {
        var values = GetValues(circuitValues);
        double runningValue = 0;
        foreach(var value in values)
        {
            runningValue += 1 / value;
        }
        return 1 / runningValue;
    }
}
