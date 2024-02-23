using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();

        string reversedSentence = ReverseWords(sentence);

        Console.WriteLine($"Після перевороту: {reversedSentence}");

        Console.ReadLine();
    }

    static string ReverseWords(string sentence)
    {
        
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseWord(words[i]);
        }

        
        string reversedSentence = string.Join(" ", words);
        return reversedSentence;
    }

    static string ReverseWord(string word)
    {
        
        char[] charArray = word.ToCharArray();

        
        Array.Reverse(charArray);

        
        return new string(charArray);
    }
}

