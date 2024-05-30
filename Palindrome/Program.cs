using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                bool isPalindrome = IsPalindrome(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }

        static bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "String cannot be null");
            }

            if (input.Length < 2)
            {
                return true;
            }

            bool IsStringPalindrome(string str)
            {
                int left = 0;
                int right = str.Length - 1;

                while (left < right)
                {
                    if (str[left] != str[right])
                    {
                        return false;
                    }

                    left++;
                    right--;
                }

                return true;
            }

            return IsStringPalindrome(input);
        }
    }
}

