using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class WordsCounter
    {
        static void analyseWords(string [] words, string text)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] wordsFromText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < wordsFromText.Length; j++)
                {
                    if (words[i] == wordsFromText[j])
                        counter++;

                }
                myDict.Add(words[i], counter);
            }

           

            foreach (KeyValuePair<string, int> kvp in myDict)
            {
                Console.WriteLine($"Word {kvp.Key} can be seen in the text {kvp.Value} times. "); 
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the words you want to search for. Use , to split the words.");
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] wordsToSearch = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            analyseWords(wordsToSearch, text);
           
            Console.ReadLine();
        }
    }
}
