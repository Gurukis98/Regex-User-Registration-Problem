using System;
using System.Text.RegularExpressions;


namespace Regex_UC_3
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your EMail Like (Eg:abc.@bl.co)");
            string email = Console.ReadLine();
            if (Regex.Match(email, "^[0-9a-z]{1, }[.][@][a-z]{1, }[.][a-z]{1, }$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
        }
    }
}
