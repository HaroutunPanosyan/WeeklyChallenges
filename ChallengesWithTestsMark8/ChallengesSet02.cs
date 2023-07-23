using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) => (char.IsLetter(c)) ? true : false;

        public bool CountOfElementsIsEven(string[] vals) => vals.Length % 2 == 0 ? true : false;

        public bool IsNumberEven(int number) => number % 2 == 0;

        public bool IsNumberOdd(int num) => num % 2 == 1 || num % 2 == -1 ? true : false;

        public double SumOfMinAndMax(IEnumerable<double> numbers) => numbers?.Any() == true ? numbers.Min() + numbers.Max() : 0;

        public int GetLengthOfShortestString(string str1, string str2) => str1.Length <= str2.Length ? str1.Length : str2.Length;
      

        public int Sum(int[] numbers) => numbers != null ? numbers.Sum() : 0; // numbers?.Sum() ?? 0;

        public int SumEvens(int[] numbers)
        {
            if (numbers?.Any() == true)
            {
                int answer = 0;
                for (int i = 0; i < numbers.Length;)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        answer += numbers[i];
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                return answer;
            }
            else
            {
                return 0; 
            }

            /* Linq :
             *
             * return numbers?.Where(x => x % 2 == 0).Sum() ?? 0;
             *                                             ^^--- Null Coalesing. 
             *
             * Aggregate:
             *
             * => numbers?.Aggregate(0, (total, next) => next % 2 -- 0? total + next : total) ?? 0;
             *
            */

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers?.Any() == true)
            {
                if (numbers.Sum() % 2 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;

            // numbers?.Any() ?? false ? numbers.Sum() % 2 != 0 : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            // return number < - ? 0 : number / 2;
            if (number != null)
            {
                int counter = 0;         
                for (int i = 0; number > i;) 
                { 
                    if (i % 2 == 1 || i % 2 == -1)
                    {
                        counter++;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                return counter;
            }
            else
            {
                return 0;
            }            
        }
    }
}
