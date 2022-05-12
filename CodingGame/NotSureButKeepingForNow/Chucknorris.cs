using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
public class ChuckNorris
{
    public static void Solve()
    {
        string MESSAGE = Console.ReadLine();
        string output = string.Empty;
        var message = string.Empty;

        foreach(var item in MESSAGE)
        {
            var temp = Convert.ToString(item, 2);
            //  var temp = ToBinary(Encoding.UTF7.GetBytes(item.ToString()));
            if(temp.Length < 7)
            {
                message += "0";
            }
            message += temp;
        }
        message = message.Replace(" ", string.Empty);

        Console.Error.WriteLine(message);
        for(int i = 0; i < message.Length; i++)
        {
            var ind = 0;
            if(message[i].Equals('0'))
            {
                output += "00 ";
                ind = message.IndexOf('1', i + 1);
                if(ind < 0)
                {
                    ind = message.Length;
                }
            } else
            {
                output += "0 ";
                ind = message.IndexOf('0', i + 1);
                if(ind < 0)
                {
                    ind = message.Length;
                }
            }

            var same = ind - i;
            for(int j = 0; j < same; j++)
            {
                output += "0";
                i = ind - 1;
            }

            output += " ";
        }

        Console.WriteLine(output.Trim());
    }
}