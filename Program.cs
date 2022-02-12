using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        //Как показал эксперимент стринг и массив символов тут одно и то же, поэтому передаю сразу строку
        public static bool LogginCheck(string loggin)
        {
            bool isCorrect = false;
            bool invalidChar = false;
            bool hasNumber = true;


            UnicodeCategory categoryFirst = char.GetUnicodeCategory(loggin[0]);

            //Сначала проверяем первый символ и если он не буква, то больше ничего не делаем
            if (categoryFirst != UnicodeCategory.LowercaseLetter && categoryFirst != UnicodeCategory.UppercaseLetter)
                return isCorrect;

            //отсекаем слишком короткие и слишком длинные логины
            else if (loggin.Length < 2 || loggin.Length > 10)
                return isCorrect;

            else
            {
                for (int i = 1; i < loggin.Length; i++)
                {
                    UnicodeCategory category = char.GetUnicodeCategory(loggin[i]);

                    switch (category)
                    {
                        case UnicodeCategory.UppercaseLetter:
                           
                            break;
                        case UnicodeCategory.LowercaseLetter:
                            
                            break;

                        case UnicodeCategory.DecimalDigitNumber:
                            hasNumber = true;
                            break;

                        default:
                            invalidChar = true;
                            break;
                    }
                   
                }
                if (hasNumber && !invalidChar) {
                    isCorrect = true;
                    return isCorrect; }

                return isCorrect;
            }
        }

        static bool RegCheck (string loggin) {

            bool isCorrect = false;
            //Не сталкивался раньше, но вроде разобрался
            Regex checkPattern = new Regex("^[a-zA-z]{1}[a-zA-z0-9]{1,9}$");
            isCorrect = checkPattern.IsMatch(loggin);

            return isCorrect;
        }

        static void Main(string[] args)
        {           
            //проверяем логин по обычному методу
            Console.Write("Enter loggin:");
            string logginInput = Console.ReadLine();
            bool logginCorrect = LogginCheck(logginInput);
            if (logginCorrect)
                Console.WriteLine("Good loggin!");
            else Console.WriteLine("Try again!");

            //проверяем с помощью регулярных выражений
            Console.WriteLine("Enter a loggin");
            string logginInput2 = Console.ReadLine();
            bool logginValid = RegCheck(logginInput2);
            if (logginValid)
                Console.WriteLine("Good loggin!");
            else Console.WriteLine("Try again!");

            Console.ReadLine();
 
        }
    }

   
}
