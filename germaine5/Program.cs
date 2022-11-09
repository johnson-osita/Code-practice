using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace germaine5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new account ");

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            var User = new Dictionary<string, string>(){
            { "germaine", "baddest123"}, {"ositadimma", "badboy345"}
            };


            while (true)
            {
                if (password.Length < 6 || !password.Any(character => char.IsDigit(character)))
                {
                    Console.WriteLine("password should contain intergers or must be more than 8 characters");

                }
                else if (User.Keys.Contains(username))
                {
                    Console.WriteLine("username already exist");

                }
                else
                {
                    User.Add(username, password);
                }
                break;



                Console.WriteLine("Enter username");
                string loginUsername = Console.ReadLine();

                Console.WriteLine("Enter password");
                string loginPassword = Console.ReadLine();

                foreach (KeyValuePair<string, string> userLogin in User)
                {
                    if (!string.IsNullOrEmpty(loginUsername) || !string.IsNullOrEmpty(loginPassword))
                    {
                        if (userLogin.Key == loginUsername && userLogin.Value == loginPassword)
                        {
                            Console.WriteLine("you have successfully logged in");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("invalid username or password");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("empty input");
                        break;
                    }
                }
            }
        }
    }
}