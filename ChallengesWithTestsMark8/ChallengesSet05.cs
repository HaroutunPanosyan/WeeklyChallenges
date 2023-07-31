using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (++startNumber % n == 0)
                return startNumber;
            else
            {
                while (startNumber % n != 0)
                {
                    startNumber++;
                }
                return startNumber;
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            Business business = new Business();
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue == 0)
                {
                    biz.Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            // Check if array is null.
            if (numbers == null || !numbers.Any())
            {
                return false;
            }
            // Check if numbers is ascending order.
            for (int i = 1; i < numbers.Length; i++)
            {
                // if starting index is greater than next index, return false.
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            // If everything else is false, then must be true.
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            // Null Checker
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            // Create integer variable named sum and set it to 0;
            int sum = 0;
            // In the case that the index of numbers prior to current index is divisible by 2 (or is even)
            // add it to and set the new number to sum.
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            // Null Checker
            if (words == null || !words.Any())
            {
                return "";
            }
            // Create a variable of type string that is empty. 
            string sentence = string.Empty;
            // Using a for loop to iterate through each index of the string array.
            for (int i = 0; i < words.Length;)
            {
                // Check if current index + 1 is less than the array length,
                // this is to match the starting length.              
                if (i + 1 < words.Length)
                {
                    // If word at index i is empty, just iterate forward and add nothing.
                    if (words[i].Trim() == "")
                    {
                        i++;
                    }
                    // Otherwise, add word at current index with white space trimmed.
                    // The add a space to make it look like a normal sentence.
                    sentence += words[i].Trim() + " ";
                    i++;
                }         
                // Otherise add the word to sentence with a trim, but no space afterwards.
                // Iterate forward.
                else
                {
                    sentence += words[i].Trim();
                    i++;
                }
            }
            // Test to see if the sentence has anything in it. If not, return a blank (or empty string).
            if (sentence == " ") 
            {
                return string.Empty;
            }
            // Otherwise, return the full sentence with a period at the end.
            return sentence + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {            
            List<double> newElements = new List<double>();
            if (elements == null || !elements.Any())
            {
                return newElements.ToArray();
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 4 == 0)
                newElements.Add(elements[i]);
            }
            return newElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
