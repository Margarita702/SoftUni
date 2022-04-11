using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            for (int count = 1; count <= 4; count++)
            {
                string EnteredPssword = Console.ReadLine();
                if (EnteredPssword == password)
                {
                    Console.WriteLine($"User {username} logged in."); break;
                }
                else
                {
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!"); break;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again."); continue;
                    }
                }
            }
        }
    }
}
