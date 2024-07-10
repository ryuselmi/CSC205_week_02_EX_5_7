using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Part2
{
    public class Recurse
    {
        // first: returns the first character of the given string
        public static char First(string s)
        {
            return s[0];
        }

        // rest: returns a new string that contains all but the first letter of the given string
        public static string Rest(string s)
        {
            return s.Substring(1);
        }

        // length: returns the length of the given string
        public static int Length(string s)
        {
            return s.Length;
        }
        public static void WriteString(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
        public static void WriteBackward(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Main(string[] args)
        {
            // Test the First method
            string testString1 = "hello";
            Console.WriteLine("Testing First method:");
            Console.WriteLine("First character of '" + testString1 + "' is: " + First(testString1));

            // Test the Rest method
            string testString2 = "world";
            Console.WriteLine("\nTesting Rest method:");
            Console.WriteLine("Rest of the string '" + testString2 + "' is: " + Rest(testString2));

            // Test the Length method
            string testString3 = "programming";
            Console.WriteLine("\nTesting Length method:");
            Console.WriteLine("Length of the string '" + testString3 + "' is: " + Length(testString3));

            // Test the WriteString method
            string testString4 = "Yuselmi";
            Console.WriteLine("\nTesting WriteString method:");
            WriteString(testString4);

            Console.WriteLine("\nTesting WriteBackward method:");
            WriteBackward(testString4);

            Console.WriteLine("\nTesting ReverseString method:");
            string reversedString = ReverseString(testString4);
            Console.WriteLine("Reversed string of '" + testString4 + "' is: " + reversedString);

            Console.ReadKey();
        }
    }
}