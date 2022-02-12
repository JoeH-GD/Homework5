using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class MixedCharacters
    {
 
       static bool MixedChars(string line1, string line2)
        {
            bool isMixed = false;
 //Логика была в том, что строки надо сравнить по длине, значению и порядку
 //Начнем с длины, если она не идентична - можно больше ничего не делать
            if (line1.Length != line2.Length)
                return isMixed;

            else {

 //Определяем совпадает ли численное значение символов в строке, для начала перегоним их в массив символов
                char[] arr1 = line1.ToCharArray();
                char[] arr2 = line2.ToCharArray();
                int sum1 = 0;
                int sum2 = 0;

 //Затем символы перегоним в целочисленные значения
                foreach (char n in arr1)
                {
                    Convert.ToInt32(n);
                }

                foreach (char n in arr2)
                {
                    Convert.ToInt32(n);
                }

//Наконец проссуммируем полученные целочисленные значения
                for (int i = 0; i < arr1.Length; i++)
                {
                    sum1 += arr1[i];
                }

                for (int i = 0; i < arr2.Length; i++)
                {
                    sum2 += arr2[i];
                }

//Если суммы равны, значит в строку входят одинаковые символы
                if (sum1 == sum2)
                {
//Проверяем, что порядок символов в строке не совпадает, если он одинаковый, то строки не являются перестановкой - они одинаковые
                    for (int i = 0; i < line1.Length; i++)
                    {
                        if (line1[i] != line2[i])
                            isMixed = true;

                    }
                    return isMixed;
                }
                else return isMixed;
            }
           
        }
        static void Main (string [] args)
        {
            Console.WriteLine("Enter a line");

            string line1 = Console.ReadLine();
            Console.WriteLine("Enter anoter line");

            string line2 = Console.ReadLine();

            bool isMixed = MixedChars(line1, line2);
            if (isMixed) Console.WriteLine("Line2 is a mixed up line1!");
            else Console.WriteLine("Line2 is NOT a mixed up line1!");

            Console.ReadLine();

        }
       
    }
}
