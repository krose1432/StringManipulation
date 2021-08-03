using System;

namespace StringManipulation
{
    class Program
    {
        static string backwordWord;
        static string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots.So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine(sentence);
            Console.WriteLine("What word in the sentence above would you like to replace?");
            string input = Console.ReadLine();
            

            if (sentence.Contains(input)== false)
            {
                Console.WriteLine("Sorry, I could not find your word {" + input + "}.");
                for (int i = input.Length-1;i >=0; i--)
                {
                    backwordWord += input[i];
                }
                Console.WriteLine("You word is now " + backwordWord + ".");
            }
            else
            {
                Console.WriteLine("What word would you like to replace it with?");
                string newInput = Console.ReadLine();
                sentence = sentence.Replace(input, newInput);
                Console.WriteLine(sentence);
            }
        }
    }
}
