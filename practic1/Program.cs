using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Factorial(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", "Число должно быть неотрицательным.");
            if (n == 0) return 1;
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static string Reverse(string input)
        {
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            string result = string.Join(" ", words);

            return result;
        }

        public static int MaxLength(string input)
        {
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = Array.ConvertAll(words, word => int.Parse(word.Trim()));

            if (nums.Length == 0) return 0;

            int max = 1;
            int len = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] % nums[i] == 0 && nums[i + 1] != nums[i])
                {
                    len++;
                    if (len > max)
                    {
                        max = len;
                    }
                }
                else
                {
                    len = 1;
                }
            }

            return max;
        }

        public static int CalculateWordStrength(string word)
        {
            int strength = 0;

            foreach (char c in word.ToLower())
            {
                if (c >= 'а' && c <= 'я')
                {
                    strength += (c - 'а' + 1);
                }
            }

            return strength;
        }

        public static bool CompareWordStrength(string word1, string word2)
        {
            return CalculateWordStrength(word1) == CalculateWordStrength(word2);
        }

        public static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0) return b;
            if (b == 0) return a;

            return GCD(b, a % b);
        }
    }
}
