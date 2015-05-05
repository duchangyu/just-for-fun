using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution sln = new Solution();
            sln.solution_Task2("dooernedeevrvn");

        }
    }

    public class Solution
    {

        public int solution(int[] A)
        {
            if (A.Length == 0)
            {
                return -1;
            }

            

            //get average
            int average = 0;
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum = sum + A[i]; 
            }
            average = sum / A.Length;


            int deviation = 0;
            int maxDeviation = 0;
            int pos = 0;
            for (int i = 0; i < A.Length; i++)
            {
                deviation = Math.Abs(A[i] - average);
                if (deviation > maxDeviation)
                {
                    maxDeviation = deviation;
                    pos = i;
                }
            }

            return pos;


         
        }

        public int solution_Task2(string S)
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)

            if (String.IsNullOrEmpty(S))
            {
                return 0;
            }

            if (S.Length == 1 || S.Length == 2)
            {
                return 1;
            }

            char[] strArr = S.ToCharArray();

            Dictionary<char, int> charCountDic = new Dictionary<char, int>();

            for (int i = 0; i < strArr.Length; i++)
            {
                if (charCountDic.ContainsKey(strArr[i]))
                {
                    //add char count
                    charCountDic[strArr[i]]++;
                }
                else
                {
                    //add to dict 
                    charCountDic.Add(strArr[i], 1);
                }
            }

            // only one or zero char count is allowed to be odd, all others char count must be even
            int oddCharCount = 0;
            char charInMiddle = '\0';

            foreach (var item in charCountDic)
            {
                int char_count = item.Value;
                char theChar = item.Key;

                if (char_count % 2 != 0 )
                {
                    oddCharCount++;
                    charInMiddle = theChar;
                }

                if (oddCharCount > 1)
                {
                    return 0; //not palindrome
                }
            }


            //try re-arranging 
            StringBuilder sb = new StringBuilder();
            foreach (var item in charCountDic)
            {
                int char_count = item.Value;
                char theChar = item.Key;

                if (char_count % 2 != 0)
                {
                    oddCharCount++;
                    charInMiddle = theChar;
                }

                int i = char_count / 2;
                while (i > 0)
                {
                    sb.Append(theChar);
                    sb.Insert(0,theChar);
                    i-- ;
                }

                
            }

            //insert the mid-char 
            if (charInMiddle != '\0')
            {
                sb.Insert(S.Length / 2, charInMiddle);
            }

            string palindrome = sb.ToString();
            Console.WriteLine(palindrome);
            Console.ReadLine();
           
            return 1;
        }
    }
}
