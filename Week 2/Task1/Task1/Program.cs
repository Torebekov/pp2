using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool pol(string s)//method to identify polindrome words
        {
            int i = 0;
            while (i < s.Length / 2)// loop with size half of string length 
            {
                if (s[i] != s[s.Length - 1 - i])//comparison of beggining and end of word, it will go at both sides to middle of word
                    return false;//if they aren't equal to each other then it isn't a polindrome
                i++;//incrementing i
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"C:\Users\Админ\Desktop\pp2\Week 2\Task1\Tes.txt");// giving sourse to read and get value
            if (pol(s))// checking string, is it prolindrome 
                Console.WriteLine("Yes");//if it is then write Yes
            else
                Console.WriteLine("No");// If it is not then No
        }
    }
}
