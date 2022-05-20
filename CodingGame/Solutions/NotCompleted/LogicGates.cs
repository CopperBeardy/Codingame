using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codingame.com/ide/puzzle/logic-gates
public static class LogicGates
{
    static Dictionary<string, string> inputValues = new Dictionary<string, string>();

    public static void Solve()
    {
        string[] inputs;
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
       
        List<(string outputName, string type, string valueA, string ValueB)> gates = new List<(string outputName, string type, string valueA, string ValueB)>(
            );

        for(int i = 0; i < n; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            inputValues.Add(inputs[0], inputs[1]);
        }
        for(int i = 0; i < m; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            gates.Add((inputs[0], inputs[1], inputs[2], inputs[3]));
        }

        foreach(var gate in gates)
        {
            string temp = ProcessGate(gate.type, gate.valueA, gate.ValueB);
        
             Console.WriteLine($"{gate.outputName} {temp}");
        }       
       
    }

    static string ProcessGate(string type, string valueA, string valueB)
    {
        var firstValue = inputValues.Where(x => x.Key == valueA).FirstOrDefault().Value;
        var secondValue = inputValues.Where(x => x.Key == valueB).FirstOrDefault().Value;
        switch(type)
        {
            case "AND":
                return And(firstValue, secondValue);
            case "OR":
                return Or(firstValue, secondValue);
            case "XOR":
                return Xor(firstValue, secondValue);
            case "NAND":
                return Nand(firstValue, secondValue);
            case "NOR":
                return Nor(firstValue, secondValue);
            case "NXOR":
                return Xnor(firstValue, secondValue);
            default:
                return string.Empty;
        }
    }

    // _ 0
    //- 1
    static string And(string valueA, string valueB)
    {
        // AND --  both must be 1    
        var temp = string.Empty;
        for(int i = 0; i < valueA.Length; i++)
        {
            temp = valueA[i] == '-' && valueB[i] == '-' ? $"{temp}-" : $"{temp}_";
        }
        return temp;
    }

    static string Or(string valueA, string valueB)
    {   // OR --  at least one must be 1
        var temp = string.Empty;
        for(int i = 0; i < valueA.Length; i++)
        {
            temp = valueA[i] == '-' || valueB[i] == '-' ? $"{temp}-" : $"{temp}_";
        }
        return temp;
    }

    static string Xor(string valueA, string valueB)
    {  // XOR -- one must be 1, but not both  
        var temp = string.Empty;
        for(int i = 0; i < valueA.Length; i++)
        {
            if(valueA[i] == '-' && valueB[i] != '-' || valueA[i] != '-' && valueB[i] == '-')
            {
                temp += '-';
            } else
            {
                temp += '_';
            }
        }
        return temp;
    }

    static string Nand(string valueA, string valueB)
    {     // NAND -- both must be 0  
        var temp = string.Empty;
        for(int i = 0; i < valueA.Length; i++)
        {
            temp = valueA[i] == '-' && valueB[i] == '-' ? temp + '_' : temp + '-';
        }
        return temp;
    }

    static string Nor(string valueA, string valueB)
    {    // NOR -- at least one must be 0  
        var temp = string.Empty;
        for(int i = 0; i < valueA.Length; i++)
        {
            temp = valueA[i] == '-' || valueB[i] == '-' ? $"{temp}_" : $"{temp}-";
        }
        return temp;
    }

    static string Xnor(string valueA, string valueB)
    {
        //Xnor  -- one must be 0, but not both       
        var temp = string.Empty;
        for(int i = 0; i < valueA.Length; i++)
        {
            if(valueA[i] == '-' && valueB[i] == '_'|| valueA[i] == '_' && valueB[i] == '-')
            {
                temp = $"{temp}_";
            } else 
            {
                temp = $"{temp}-";
            }
        }
        return temp;
    }


    public static string ConvertToBinary(string input)
    {
        string output = string.Empty;
        foreach(var sign in input)
        {
            output = sign == '-' ? $"{output}{1}" : $"{output}{0}";
        }
        return output;
    }

    public static string ConvertFromBinary(string input)
    {
        string output = string.Empty;
        foreach(var digit in input)
        {
            output = digit == '0' ? $"{output}_" : $"{output}-";
        }
        return output;
    }
}
