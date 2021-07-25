using System;
using System.Text.RegularExpressions;

namespace Regex_UC_8
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters, Atleast 1 Uppercase, Atleast 1 Numeric Number and Exactly 1 Special Character");
            string rule4 = Console.ReadLine();
            if (Regex.Match(rule4, "^[A-Z0-9a-z]{8,}[~,`!@#$%^&*()_./?'+{}:;<>]{1}$").Success)
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
