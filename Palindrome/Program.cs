using System;

namespace Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string word)
        {
            //declare an empty string           
            string myString = "";

            //iterate through all the characters in the string we need to check if it's a palindrome, starting from the last character going back to the first one
            for (int index = word.Length - 1; index >= 0; index--)
            {
                //reverse the word to be checked and store the result in "myString", initially declared empty
                myString += word[index];
            }

            //now check if the word is a palindrome, disregarding the case
            return word.ToLower().Equals(myString.ToLower());


        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Program.IsPalindrome("Deleveled"));
        }
    }


}
