using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wordpress.tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestPalindrom()
        {

            //var palindrom =  GivenTextIsPalindrom("tattarrattat");
            // Console.WriteLine(palindrom);
            Console.WriteLine(ReturnResult("Granddnarg"));

        }       

        
        public bool GivenTextIsPalindrom(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            var newWord = new string(array);
            if (newWord.Equals(text)) { return true; }
            return false;
        }

        public string ReturnResult(string str)
        {
            var strr = TextIsPalindrom(str);
            if (strr.Equals(str.ToLower()))
            {
                return string.Format("The Texts {0} matches {1}",strr, str);
            }

            return string.Format("The Texts {0} does not match {1}", strr, str);
        }

        public string TextIsPalindrom(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            //var newWord = new string(array);
            return new string(array).ToLower();
        }

        [TestMethod]
        public void TestCharLength()
        {
           var sss = ReturnCharLength("what a wonderful Wonderful world");
            Console.WriteLine(sss);
        }
        public int ReturnCharLength(string s)
        {           
            int sLength = s.Length;
            return sLength;
        }

        [TestMethod]
        public void Conversion()
        {
            //Console.WriteLine(ConvertAnIntegar(200));
            //Console.WriteLine(ConvertAString("234"));
            Console.WriteLine(ConvertToChar("wonderful"));
        }

        public string ConvertAnIntegar(int num)
        {
            
           return num.ToString();
        }

        public int ConvertAString(string text)
        {
            return int.Parse(text);
        }

        public char ConvertToChar(string s)
        {
            char[] c = s.ToCharArray();

            return c[0];
        }

        [TestMethod]
        public void PrintArrayForEach()
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var num in array)
            {
                Console.Write(num);
            }
        }

        [TestMethod]
        public void PrintArrayForLoop()
        {
            int[] array = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 0; i<=array.Length; i ++ )
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void PrintArrayReverseForLoop()
        {
            int[] array = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = array.Length -1; i >= 0; i --)
            {
                Console.WriteLine(i + 1);
            }
        }

        [TestMethod]
        public void PrintArrayForLoopIncrementBy2()
        {
            int[] array = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 0; i < array.Length; i+=2)
            {
                Console.WriteLine(i + 2);
            }
        }

        [TestMethod]
        public void PrintArrayForLoopRemainder0()
        {
            int[] array = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 1; i < array.Length; i ++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
