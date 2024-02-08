using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            if (ignoreCase)
            {
                foreach (var item in words)
                {
                    if (item != null && item.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                foreach (var item in words)
                {
                    if (item != null && item.Contains(word))
                    {
                        if (word.Any(char.IsUpper) && word.Any(char.IsLower))
                        {
                            return false;
                        }
                        return true;
                    }
                }
                return false;
            }
        }


        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }


            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        public int IndexOfLastUniqueLetter(string str)
        {


            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            Dictionary<char, int> lastIndexMap = new Dictionary<char, int>();
            HashSet<char> multipleOccurrences = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (lastIndexMap.ContainsKey(c))
                {
                    lastIndexMap.Remove(c);
                    multipleOccurrences.Add(c);
                }
                else if (!multipleOccurrences.Contains(c))
                {
                    lastIndexMap[c] = i;
                }
            }

            if (lastIndexMap.Count == 0)
            {
                return -1;
            }

            int lastIndex = -1;
            foreach (var kvp in lastIndexMap)
            {
                if (kvp.Value > lastIndex)
                {
                    lastIndex = kvp.Value;
                }
            }

            return lastIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;


            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {

                    maxCount = Math.Max(maxCount, currentCount);

                    currentCount = 1;
                }
            }
            maxCount = Math.Max(maxCount, currentCount);

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();


            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
