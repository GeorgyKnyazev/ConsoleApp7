using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> words = new Dictionary<string,string>();
            words.Add("Мама","не Папа");
            words.Add("Папа","не Мама");

            string userInPut;

            Console.Write("Введите слово: ");
            userInPut = Convert.ToString(Console.ReadLine());
            
            if (words.ContainsKey(userInPut))
            {
                Console.WriteLine(words[userInPut]);
            }
            else
            {
                Console.WriteLine("Такого слова нет");
            }

            Console.ReadKey();
        }
    }
}
