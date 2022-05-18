
using System;

//https://www.codingame.com/ide/puzzle/encryptiondecryption-of-enigma-machine
public static class EncryptionDecryptionOfEnigmaMachine
{
    const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static void Solve()
    {
        string operation = Console.ReadLine();
        int pseudoRandomNumber = int.Parse(Console.ReadLine());

        string[] rotors = new string[3];
        for(int i = 0; i < 3; i++)
        {
            rotors[i] = Console.ReadLine();
        }
        string message = Console.ReadLine();


        if(operation == "ENCODE")
        {
            message = ApplyCaesarEncode(message, pseudoRandomNumber);
            for(int i = 0; i < 3; i++)
            {
                message = ApplyRotor(message, rotors[i]);
            }
        } else
        {
            Array.Reverse(rotors);
            for(int i = 0; i < 3; i++)
            {
                message = UndoRotor(message, rotors[i]);
            }
            message = UndoCaesar(message, pseudoRandomNumber);
        }

        Console.WriteLine(message);
    }

    private static string UndoCaesar(string message, int pseudoNumber)
    {
        string newMessage = string.Empty;
        for(int i = 0; i < message.Length; i++)
        {
            var currentIndex = Alphabet.IndexOf(message[i]);

            var newIndex = (currentIndex - pseudoNumber - i) % 26;
            if(newIndex < 0)
            {
                newIndex = newIndex + 26;
            }
            newMessage += Alphabet[newIndex];
        }

        return newMessage;
    }

    public static string ApplyCaesarEncode(string message, int pseudoNumber)
    {
        string newMessage = string.Empty;
        for(int i = 0; i < message.Length; i++)
        {
            var currentIndex = Alphabet.IndexOf(message[i]);
            var newIndex = (currentIndex + pseudoNumber + i) % 26;
            newMessage += Alphabet[newIndex];
        }
        return newMessage;
    }

    static string ApplyRotor(string message, string rotor)
    {
        string newMessage = string.Empty;
        for(int i = 0; i < message.Length; i++)
        {
            var currentIndex = Alphabet.IndexOf(message[i]);
            newMessage += rotor[currentIndex];
        }
        return newMessage;
    }

    static string UndoRotor(string message, string rotor)
    {
        string newMessage = string.Empty;
        for(int i = 0; i < message.Length; i++)
        {
            var currentIndex = rotor.IndexOf(message[i]);
            newMessage += Alphabet[currentIndex];
        }
        return newMessage;
    }
}