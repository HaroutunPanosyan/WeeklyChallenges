using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(num => num % 2 == 0).Sum() - numbers.Where(num => num % 2 != 0).Sum();
            #region LogicTestWithLoops
            // Foreach loop

            //int answer = 0;
            //if (numbers.Any() && numbers.Count() != 0)
            //{
            //    foreach (int i in numbers) 
            //    { 
            //        if (i % 2 == 0)
            //        {
            //            answer += i;
            //        }
            //        else
            //        {
            //            answer -= i;
            //        }
            //    }
            //    return answer;
            //} 
            //else
            //{
            //    return 0;
            //}

            // For Loop:

            //int answer = 0;
            //if (numbers != null)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] % 2 == 0)
            //        {
            //            answer += numbers[i];
            //        }
            //        else
            //        {
            //            answer -= numbers[i];
            //        }
            //    }
            //    return answer; 
            //}
            //return 0;
            #endregion
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            int one = str1.Length;
            int two = str2.Length;
            int three = str3.Length;
            int four = str4.Length;

            return 
                (one <= two && two <= three && three <= four) ? one :
                (two <= one && one <= three && three <= four) ? two :
                (three <= one && one <= two && two <= four) ? three :
                (four <= one && one <= two && two <= three) ? four  :
                0;

            #region LogicTestWithIfStatements

            //if (one <= two && two <= three && three <= four)
            //{
            //    return one;
            //}
            //else if (two <= one && one <= three && three <= four)
            //{
            //    return two;
            //}
            //else if (three <= one && one <= two && two <= four)
            //{
            //    return three;
            //}
            //else if (four <= one && one <= two && two <= three)
            //{
            //    return four;
            //}
            //else
            //{
            //    return 0;
            //}
            #endregion
        }

        public int GetSmallestNumber(int one, int two, int three, int four)
        { 
            int[] numbers = new int[4];
            numbers[0] = one;
            numbers[1] = two;
            numbers[2] = three;
            numbers[3] = four;
            return numbers.Min();            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return 
                (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0) ? false : 
                (sideLength1 + sideLength2 > sideLength3 && 
                 sideLength2 + sideLength3 > sideLength1 && 
                 sideLength1 + sideLength2 > sideLength3) ? true : false;

            #region LogicIfElse

            //if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            //{
            //    return false;
            //}

            //if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength2 > sideLength3)
            //{
            //    return true;
            //}    
            //else 
            //{
            //    return false;
            //}

            #endregion
        }

        public bool IsStringANumber(string input) => double.TryParse(input, out double number);
        //{
        //    bool isNumber = double.TryParse(input, out double number);
        //    return isNumber;
        //}

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            // Refactor 1: Using Linq Count.

            int numOfNulls = objs.Count(x => x == null); ;
            int numOfNonNulls = objs.Count(x => x != null); ;
            if (numOfNulls > numOfNonNulls)
            {
                return true;
            }
            return false;

            #region FirstLogicAttempt

            // Attempt 1: Figure out the logic.

            //int numOfNulls = 0;
            //int numofObjs = 0;
            //for (int i = 0; i < objs.Length; i++)
            //{
            //    if (objs[i] == null)
            //    {
            //        numOfNulls++;
            //    }
            //    else 
            //        numofObjs++;
            //}
            //if (numOfNulls > numofObjs)
            //{
            //    return true;
            //}
            //return false;

            #endregion
        }

        public double AverageEvens(int[] numbers)
        {
            //return (numbers?.Any(x => x % 2 == 1) != null ) ? numbers.Where(x => x % 2 == 0).Average() : 0;

            // Figuring out the logic.
            // If no numbers or null return 0.
            // If numbers are even. Grab them and get the average. 
            // If numbers are odd. Don't touch them. (Skip over them).
            // The average is the sum of the numbers divided by how many numbers were added together.
            // If all the numbers are odd, do nothing with them, return 0.


            if (numbers == null || !numbers.Any()) // Check null case.
            {
                return 0; // If none, return 0.
            }

            double sum = 0;
            double evenAvg = 0;
            double oddAvg = 0;
            double evenTicker = 0;
            
            foreach (double number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenTicker++;
                    sum += number;
                }
            }
            evenAvg = sum / evenTicker;                
            foreach (double number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddAvg += number;
                }
            }
            oddAvg *= 0;
            if (numbers.All(x => x % 2 != 0))
            {
                return 0;
            }
            else
            {
                return evenAvg + oddAvg;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException($"Cannot compute factorial of negative number: { number }");
            }

            // Factorial is: (Number * (Number - 1)) Number Times.
            // Example: Factorial 4 is --  4 * 3 = 12. 4 * 2 = 8. 4 * 1 = 4. 12 + 8 + 4 = 24.

            int factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
    }
}
