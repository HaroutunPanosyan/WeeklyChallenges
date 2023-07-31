using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            #region WithHelpFromSeth
            //bool containsWord = false;
            //if (string.Equals(words, null) || words.Contains(null))
            //{
            //    return false;
            //}
            //if (ignoreCase)
            //{
            //    word = word.ToLower();
            //    List<string> list = words.Select(x => x.ToLower()).ToList();
            //    containsWord = list.Contains(word);
            //}
            //if (!ignoreCase)
            //{
            //    containsWord = words.Contains(word);                
            //}
            //return containsWord;
            #endregion
            #region MyFirstAttempt
            //if (word != null & words?.Any(w => w.ToLower().Contains(word)) == true & ignoreCase == true)
            //{
            //    return true;
            //}
            //else if (word != null & words?.Any(w => w.Contains(word)) == true & ignoreCase == false)
            //{
            //    return true;
            //}
            //else
            //    return false;
            #endregion
            #region HelpFromChatGPT
            if (word == null || words == null)
                return false;
            words = words.Where(w => w != null);

            if (ignoreCase)
            {
                return words.Any(w => w.ToLower().Contains(word.ToLower()));
            }
            else
            {
                return words.Any(w => w.Contains(word));
            }
            #endregion
        }

        public bool IsPrimeNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num == 1) return false;
                if (num % i == 0 && i != 1 & i != num)
                {
                    break;
                }
                if (i / 1 == num && i / num == 1)
                {
                    return true;
                }                    
            }
            return false;
            #region Test1
            //if (num == 2)
            //{
            //    return true;
            //}
            //if (num == 1)
            //{
            //    return false;
            //}
            //else if (num % 2 == 1 ||  num % 3 == 1 || num % 5 == 1 || num % 7 == 1 || num % 9 == 1 || num % 11 == 1 || num % 13 == 1)
            //{                
            //    return true;
            //}
            //return false;
            #endregion
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str.Count(x => x == str[i]) == 1)
                {
                    return i;
                }                
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 1;
            int retCount = 1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int nextNum = numbers[i + 1];
                int currentNum = numbers[i];
                if (currentNum == nextNum)
                {
                    count++;
                }                
                if (retCount < count)
                {
                    retCount = count;
                }
                if (currentNum != nextNum)
                {
                    count = 1;
                }
            }
            return retCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] resArr = new double[0];
            if (elements == null)
            {
                return resArr;
            }
            if (elements.Count() > 0 && n > 0)
            {
                List<double> results = new List<double>();
                foreach (double elem in elements)
                {
                    if (elem % n == 0)
                    {
                        results.Add(elem);
                    }
                }
                return results.ToArray();
            }
            else 
            {                
                return resArr;
            }
        }
    }
}
