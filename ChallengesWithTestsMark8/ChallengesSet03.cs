using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) => vals.Contains(false) ? true : false;       
        // return vals?.Contains(false) ?? false;
        //  check if vals is null. Then if contains false, if yes, return true if not false. 
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers) => numbers != null ? Math.Abs((decimal)numbers?.Sum()) % 2 == 1 : false;
        // numbers?.Any() ?? false ? numbers.Sum() % 2 != 0 : false;
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            // Using Regex.
            /* bool hasLower = Regex.IsMatch(password, "[a - z]");
            bool hasUpper = Regex.IsMatch(password, "[A - Z]");
            bool hasNumber = Regex.IsMatch(password, "[0 - 9]"); */

            // Using Linq           
            bool hasLower = password.Any(char.IsLower);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasNumber = password.Any(char.IsNumber);

            if (hasLower && hasUpper && hasNumber)
            {
                return true;
            }
            else
            {
                return false;
            }

            // The Shortest way:
            // return
            // password.Any(char.IsLower) &&
            // password.Any(char.IsUpper) &&
            // password.Any(char.IsNumber);

            /* The LONG way:
             * 
             * foreach (var element in password)
             * {   
             * 
             * if (Char.hasLower(element))
             *      {
             *          hasLower = true;
             *      }
             *      
             * ---repeat for all bools---
             * 
             * }
             * 
             * 
            */
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor) => (dividend != 0 && divisor != 0) ? dividend / divisor : 0;

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            // return Enumerable.Range(0,100).Where(i => i % 2 != 0).ToArray();
            List<int> below100 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    below100.Add(i);
                }
            }
            return below100.ToArray();
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            // Array.Copy(Array.ConvertAll(words, element => element.ToUpper()), words, words.Length);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
