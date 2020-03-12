using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewQuestions
{
    public class StringQuestions
    {
        /// <summary>
        /// Reverse a string using string concatention
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseCharactersAndWords01(string input)
        {
            string result = "";
            for(int i = input.Length -1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }

        /// <summary>
        /// Reverse a string in place
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseCharactersAndWords02(string input)
        {
            var chars = input.ToCharArray();

            var upperBound = (chars.Length - 1) / 2;
            for(int i = 0; i < upperBound; i++)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = temp;
            }
            var retVal = new string(chars);
            return retVal;
        }

        /// <summary>
        /// Reverse the words of a string using string concatenation
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseWords(string input)
        {
            var words = input.Split(" ");
            var upperBound = words.Length;

            for(int i = 0; i< words.Length / 2; i++)
            {
                string temp = words[i];
                words[i] = words[words.Length - 1 - i];
                words[words.Length - 1 - i] = temp;
            }

            string retVal = string.Empty;
            for(int i = 0; i < words.Length; i++)
            {
                if(i == 0)
                {
                    retVal = words[i];
                }
                else
                {
                    retVal += $" {words[i]}";
                }
            }

            return retVal;
        }

        /// <summary>
        /// Reverse the characters in each word preserving the word sequence
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseCharactersInEachWord(string input)
        {
            var words = input.Split(" ");
            var upperBound = words.Length;

            for(int i = 0; i < upperBound; i++)
            {
                var word = words[i].ToCharArray();
                var wordLength = word.Length;
                for(int j =0; j < wordLength / 2; j++)
                {
                    var temp = word[j];
                    word[j] = word[word.Length - 1 - j];
                    word[word.Length - 1 - j] = temp;
                }
                words[i] = new string(word);
            }
            return string.Join(" ", words);
        }
    
        public Dictionary<string, int> CountEachWordInstanceInAString(string input)
        {
            var retVal = new Dictionary<string, int>();
            var words = input.Split(" ");
            foreach(var word in words)
            {
                var temp = word.Replace(",", "").Replace(".", "").Replace(";", "").Trim();
                if (temp != string.Empty && !retVal.ContainsKey(temp))
                {
                    var nn = words.Count(n => n.Replace(",", "").Replace(".", "").Replace(";", "").Equals(temp));
                    retVal.Add(temp, nn);
                }
            }

            return retVal;
        }
    }
}
