using System;
using System.Text.RegularExpressions;


namespace Regex_UC_1
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Firstname Starts with Capital and it Have Minimum 3 Character");
            string firstName = Console.ReadLine();
            if (Regex.Match(firstName, "^[A-Z]{1}[A-Za-z]{2,}$").Success)
            {
                Console.WriteLine("Firstname is Valid");
            }
            else
            {
                Console.WriteLine("Firstname is Not Valid ");
            }
        }
    }
}
