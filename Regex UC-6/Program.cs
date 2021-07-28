using System;
using System.Text.RegularExpressions;

namespace Regex_UC_6
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters and 1 Uppercase");
            string rule2 = Console.ReadLine();
            if (Regex.Match(rule2, "^[A-Z]{1}[A-Za-z]{7,}$").Success)
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is Not Valid ");
            }
        }
    }
}
