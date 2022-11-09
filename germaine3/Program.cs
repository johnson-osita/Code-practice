using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace germaine3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word");
            string word = Console.ReadLine();


            if (word.Any(letter => char.IsUpper(letter)))
            { 
                foreach (char letter in word)
                {
                    if (Char.IsUpper(letter))
                    {
                        Console.WriteLine(word.IndexOf(letter));
                    }
                }
            }
            else
            {
                Console.WriteLine("Word does not contain an uppercase latter");
            }
        }
    }
}
