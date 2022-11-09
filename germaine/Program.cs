using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace germaine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word");
            string word = Console.ReadLine();
            if (word.Length > 5)
            {
                var LastFourWord = word.Substring(word.Length - 4);
                var otherWord = word.Substring(0, word.Length - 4);

                var hash = "";
                foreach (char letter in otherWord)
                {
                    hash += letter.ToString().Replace(letter, '#');

                }
                var newWord = hash + LastFourWord;
                Console.WriteLine(newWord);
            }
            else
            {
                Console.WriteLine(word);
            }
        }
    }
}
