using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            bool isPreviousEven = false;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var element in numbers)
            {
                if (isPreviousEven)
                {
                    sum += element;
                }

                isPreviousEven = element % 2 == 0;
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }


            string result = string.Join(" ", words.Select(s => s.Trim()).Where(s => !string.IsNullOrWhiteSpace(s)));


            return string.IsNullOrEmpty(result) ? "" : result + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();

            if (elements == null)
            {
                return new double[0];
            }

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                if (set.Contains(complement))
                {
                    return true;
                }
                set.Add(num);
            }

            return false;
        }
    }
}
