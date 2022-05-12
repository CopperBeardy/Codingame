using System;
using System.Text.RegularExpressions;


public class DiceProbabilityCalculator
{
    public static void Solve()
    {
        // string expr = "(2>5)+2*(5>2)+d4*(10>5)";
        string expr = "1+d4+1";

        if(expr.Contains('d'))
        {
        }
        bool unsolved = true;
        while(unsolved)
        {
            expr = ExpressionParse(expr);
            int.TryParse(expr, out int r);
            if(r != 0)
            {
                unsolved = false;
            }
        }
        Console.WriteLine(expr);
    }

    public static string ExpressionParse(string exp)
    {
        string ReplacementExpression = string.Empty;
        int result = 0;
        if(exp.Contains('('))
        {
            //get sum with the paranthensis 
            int openBracket = exp.LastIndexOf('(');
            int endBracket = exp.LastIndexOf(')');
            ReplacementExpression = exp.Substring(openBracket, endBracket - openBracket + 1);
            Regex rx = new Regex(@"\d+[\+\-\*\>]\d+");
            var value = rx.Match(ReplacementExpression).ToString();
            string temp = ExpressionParse(value);
            result = int.Parse(temp);
        } else if(exp.Contains('*'))
        {
            Regex rx = new Regex(@"\d+[\*]\d+");
            ReplacementExpression = rx.Match(exp).ToString();
            result = Calculate(ReplacementExpression, '*');
        } else if(exp.Contains('+'))
        {
            Regex rx = new Regex(@"\d+[\+]\d+");
            ReplacementExpression = rx.Match(exp).ToString();
            result = Calculate(ReplacementExpression, '+');
        } else if(exp.Contains('-'))
        {
            Regex rx = new Regex(@"\d+[\-]\d+");
            ReplacementExpression = rx.Match(exp).ToString();
            result = Calculate(ReplacementExpression, '-');
        } else if(exp.Contains('>'))
        {
            Regex rx = new Regex(@"\d+[\>]\d+");
            ReplacementExpression = rx.Match(exp).ToString();
            result = Calculate(ReplacementExpression, '>');
        }

        return exp.Replace(ReplacementExpression, result.ToString());
    }

    public static int Calculate(string exp, char oper)
    {
        var temp = exp.Split(oper);
        switch(oper)
        {
            case '*':
                return int.Parse(temp[0]) * int.Parse(temp[1]);
            case '+':
                return int.Parse(temp[0]) + int.Parse(temp[1]);
            case '-':
                return int.Parse(temp[0]) - int.Parse(temp[1]);
            default:
                if(int.Parse(temp[0]) > int.Parse(temp[1]))
                {
                    return 1;
                } else
                {
                    return 0;
                }
        }
    }
}