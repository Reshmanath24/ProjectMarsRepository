using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = "This sentence contains both lowercase and uppercase English letters , punctuation marks,and spaces.";
            string sum = solution(input);
            Console.Write(sum);
            Console.ReadLine();
        }

        string solution(string text)
        {   StringBuilder stringBuilder = new StringBuilder();
            List<Char> punctuations = new List<Char>() {',','.','?','!'};
            char[] chars = text.ToCharArray();
            bool IspunctuationDetected = false;
            for (int i=0; i< chars.Length; i++)
            {
                if(punctuations.Contains(chars[i]))
                {
                    IspunctuationDetected = true;
                    stringBuilder = RemoveLastSpaces(stringBuilder);
                    stringBuilder.Append(chars[i]);
                    stringBuilder.Append(" ");
                    
                }
                else 
                if(IspunctuationDetected == true && Char.IsWhiteSpace(chars[i]))
                {
                    continue;
                }
                else 
                {
                    IspunctuationDetected = false;
                    stringBuilder.Append(Convert.ToString(chars[i]));
                }
            }
            stringBuilder=RemoveLastSpaces(stringBuilder);
            return stringBuilder.ToString();
        }

        static StringBuilder RemoveLastSpaces(StringBuilder stringBuilder)
        {
            char[] chars = stringBuilder.ToString().ToCharArray();
            for(int i= chars.Length-1; i>=0; i--)
            {
                if(Char.IsWhiteSpace(chars[i]))
                {
                    stringBuilder.Remove(i,1);
                }
                else
                {
                    break;
                }
            }

            return stringBuilder;   
        }
    }

}


