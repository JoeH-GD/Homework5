using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Homework5
{
    //Джо Халдон. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

   public static class Message
    {
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " " };

        #region Methods
        public static void ShortWords(string message, int n)
        {

            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i<words.Length; i++)
            {
                if (words[i].Length<=n)
                {
                    Console.Write($"{words[i]}\t");
                }
            }
        }

      public  static string [] RemoveWords(string message, char x)
       {
           string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

           
          for (int i = 0; i < words.Length; i++)
           {
               if (words[i][words[i].Length-1] == x)
               {
                    words[i] = words[i].Remove(0,words[i].Length);
               }
           }



           return words;
       }


      public static void LongestWord(string message)
        {
            
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                
                    longestWord = words[i];
                
            }

            Console.WriteLine($"The longest word is {longestWord}");
        }

//Я считаю, что это можно было бы следлать лучше, но не могу придумать как
        public static void LongestWordsMessage(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder longestMessage = new StringBuilder(100);
            string longestWord = words[0];
           
                for (int i = 0; i < words.Length ; i++)
                {
                    if (words[i].Length > longestWord.Length)
                    {
                        longestWord = words[i];
                        longestMessage.Append(words[i] + " ");
                        words[i] = words[i].Remove(0, words[i].Length);
                      
                    }

                }
            
            
                Console.WriteLine(longestMessage);
            
        }

    }
    #endregion

    class MessageTask
    {
       static void Main(string[] args)
        {
            #region short words setup
            Console.WriteLine("Enter your message");
            string message = Console.ReadLine();
            Console.WriteLine("Enter the number of letters.");
            int n = int.Parse(Console.ReadLine());
            Message.ShortWords(message,n);
            Console.WriteLine();
            #endregion

            #region remove words with letter
            Console.WriteLine("Enter a character");
            char t = char.Parse(Console.ReadLine());
            UnicodeCategory category = char.GetUnicodeCategory(t);

//Проверяем является ли ввод буквой, если нет - просим повторить ввод, если да - выполняем удаление слова
            if (category != UnicodeCategory.LowercaseLetter && category != UnicodeCategory.UppercaseLetter)
            {
                Console.WriteLine("Enter another character");
                t = char.Parse(Console.ReadLine());
            }
            else
            {
                string[] words = Message.RemoveWords(message, t);
                for (int i = 0; i < words.Length; i++)
                {
                    Console.Write($"{words[i]}\t");
                }
            }
            Console.WriteLine();
            #endregion 

            Message.LongestWord(message);

            Message.LongestWordsMessage(message);

            Console.ReadLine();

        }

    }
}
