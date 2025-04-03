using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringLibrary
{
    public class StringSmart
    {
        static private bool Palindromo(string texto)
        {
            for (int i = 0; i < (texto.Length / 2); i++)
            {
                if (texto[i] != texto[texto.Length - i])
                    return false;
            }
            return true;
        }

        static private string Duplicados(string texto)
        {
            string duplicados = string.Empty;
            for (int i = 0; i < texto.Length; i++)
            {
                for (int j = 0; j < texto.Length; j++)
                {
                    if (texto[i] == texto[j] && i != j)
                    {
                        if (!duplicados.Contains(texto[i]))
                            duplicados.Concat(texto[i].ToString() + ", ");
                        break;
                    }
                }
            }
            duplicados = duplicados.Substring(0, duplicados.Length - 3);
            return duplicados;


        }

        /* Given a year, return the century it is in. */
        private int CenturyFromYear(int year)
        {
            if (year % 100 == 0)
                return year / 100;

            else
                return (year + 100) / 100;
        }

        /* Given the string, check if it is a palindrome. */

        private bool IsPalindrome1(string inputString)
        {
            int len = inputString.Length;
            int half = len / 2;
            if ((len % 2) == 0)
            {
                half--; // We don't want uneven numbers
            }

            for (int i = 0; i < half; i++)
            {
                if (inputString[i] != inputString[(len - 1) - i])
                {
                    return false;
                }
            }
            return true;
        }

        bool IsPalindrome2(string inputString)
        {
            var forwards = inputString.ToLower().Replace(" ", "");
            var backwards = new string(forwards.ToCharArray().Reverse().ToArray());

            return forwards == backwards;
        }

        public static IEnumerable<string> Prefixes(IEnumerable<string> words, int length)
        {
            var wordsFinds = (from word in words
                              where (word.Length > 2)
                              select word.Substring(0, length).Distinct());
            return (IEnumerable<string>)wordsFinds;
        }


        static public void PrintString(int[] elementos)
        {
            Console.WriteLine("La lista de Elementos ordenada es: \n\r");
            for (int i = 0; i < elementos.Length - 1; i++)
            {
                Console.Write(elementos[i] + ", ");
            }
            Console.Write(elementos[^1]);
        }

    }

}
