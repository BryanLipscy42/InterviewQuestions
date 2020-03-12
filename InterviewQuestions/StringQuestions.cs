using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    public class StringQuestions
    {

        public string ReverseString01(string input)
        {
            string result = "";
            for(int i = input.Length -1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }

        public string ReverseString02(string input)
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

        public string ReverseWords(string input)
        {

            var words = input.Split(" ");
            var upperBound = (words.Length - 1) / 2;

            for(int i = 0; i< upperBound; i++)
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
    }
}
