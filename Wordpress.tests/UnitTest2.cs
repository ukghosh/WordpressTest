using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

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
            //Console.WriteLine(ReturnResult("Granddnarg"));
            //EscapeSquencesAndMore();          

            //GetArrayindex("o");
            GetRecurringAllIdx("aabbccddc", "c");

        }

        //String methods

        public void EscapeSquencesAndMore()
        {
            //string myString = "using \"Double Quotes\" in a string Double Quote";
            //string myString = "What if I want to \n print in a new line";
            //string myString = string.Format("{0}!", "Hello");
            //string myString = string.Format("{Make: {0} (Model: {1})", "BMW", "745li"); //-- Doesnot work??
            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("{0:P}", .123);
            //string myString = string.Format("Phone Number: {0:(###) ### ####}", 1234567890);

            //Concatination: 
            //string myString = "";
            //StringBuilder myString = new StringBuilder();
            //for (int i =0; i<=100; i ++)
            //{
            //    //myString = myString + "--" + i.ToString();
            //    //myString += "--" + i.ToString();
            //    myString.Append("--");
            //    myString.Append(i);

            //}

            string myString = "It's better to be lucky than good.  ";
            //myString = myString.Substring(5, 12);
            //myString = myString.ToUpper();
            //myString = myString.ToLower();
            //myString = myString.Replace(" ", "-");
            myString = string.Format("Length Before: {0} -- After: {1}", myString.Length, myString.Trim().Length);
            Console.WriteLine(myString);

        }


        //Reverse Array - Palindrom
        public bool GivenTextIsPalindrom(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            var newWord = new string(array);
            if (newWord.Equals(text)) { return true; }
            return false;
        }

        [TestMethod]
        public void ReverseAString()
        {
            string s = "You can get what you want out of life" +
                "if you help enough other people to get what they want.";
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            foreach (char r in charArray)
            {
                Console.Write(r);
            }

        }
        [TestMethod]
        public void GetFirstCharacterOfAString()
        {
            string s = "You can get what you want out of life" +
                "if you help enough other people to get what they want.";
            //char[] charArray = s.ToCharArray();
            //Console.WriteLine(charArray[0]);
            //Console.WriteLine(s[0]);
            Console.WriteLine(s.LastIndexOf('p').ToString());
        }

        [TestMethod]
        public void CountNumberofOccurances()
        {
            string s = "You can get what you want out of life" +
                 "if you help enough other people to get what they want.";
            int count = s.Split('t').Length - 1;
            Console.WriteLine(count);
        }

        [TestMethod]
        public void CountNumberofOccurancesUsingLinq()
        {
            string s = "You can get what you want out of life" +
                 "if you help enough other people to get what they want.";
            //Console.WriteLine(s.Length);
            Console.WriteLine(s.Count(x => x == 'p'));

        }

        public string ReturnResult(string str)
        {
            var strr = TextIsPalindrom(str);
            if (strr.Equals(str.ToLower()))
            {
                return string.Format("The Texts {0} matches {1}", strr, str);
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

        public void GetArrayindex(string c)
        {
            string s = "Welcome To the World of Computing";
            int idx = s.IndexOf(c);

            Console.WriteLine(s.Length);
            Console.WriteLine("\nThe index of {0} is {1}", c, idx);

        }

        //GetAllRecurringCharIndices
        public void GetRecurringAllIdx(string str, string val)
        {

            List<int> idx = new List<int>();
            for (int i = str.IndexOf(val); i > -1; i = str.IndexOf(val, i + 1))
            {
                idx.Add(i);

            }
            foreach (var i in idx)
            {
                Console.WriteLine(i.ToString());
            }
        }

        //GetAllRecurringCharIndices
        public static void StoreAndAllIdx(string str, string val)
        {

            List<int> idx = new List<int>();

            for (int i = str.IndexOf(val); i > -1; i = str.IndexOf(val, i + 1))
            {
                idx.Add(i);
            }

            foreach (var i in idx)
            {
                Console.WriteLine(i.ToString());
            }
        }

        //just print all recurring char indices

        public static void PrntAllIdx(string str, string val)
        {

            for (int i = str.IndexOf(val); i > -1; i = str.IndexOf(val, i + 1))
            {
                Console.WriteLine(i.ToString());

            }

        }

        [TestMethod]
        public void GetTextUsingElementAt()
        {
            List<string> list = new List<string>();
            string s = "Welcome to the world of imagination";
            for (int i = 0; i <= s.Length; i = s.Length + 1)
            {
                list.Add(i.ToString());
                Console.WriteLine(i);
            }


        }

        //Type Conversion
        [TestMethod]
        public void Conversion()
        {
            Console.WriteLine(ConvertAnIntegar(200));
            Console.WriteLine(ConvertAString("234"));
            Console.WriteLine(ConvertToChar("Wonderful"));
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

        //Arrays:

        public void CreateAnArray()
        {
            //int[] array = new int[3];
            //array[0] = 12;
            //array[1] = 15;
            //array[2] = 20;

            //string[] array = new string[3];
            //array[0] = "Alex";
            //array[1] = "John";
            //array[2] = "Karen";

            int[] array = new int[] { 12, 15, 20, 25 };

            //string[] array = new string[] {"Alex", "John", "Karen", "Morgan" };

            Console.WriteLine(array[0].ToString());

        }



        //For/ForEach Loops / Print Array Reverse For Loop
        [TestMethod]
        public void PrintArrayForEach()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var num in array)
            {
                Console.Write(num);
            }
        }

        [TestMethod]
        public void PrintArrayForLoop()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 0; i <= array.Length; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void PrintArrayReverseForLoop()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(i + 1);
            }
        }

        [TestMethod]
        public void PrintArrayForLoopIncrementBy2()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine(i + 2);
            }
        }

        [TestMethod]
        public void PrintArrayForLoopRemainder0()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }


    }

    [TestClass]
    public class Collections
    {
        //Limitation of ArrayList: Boxing/Unboxing , different types can't be type cast
        [TestMethod]
        public void ArrList()
        {
            //    ArrayList arList = new ArrayList();
            //    arList.Add("Welcome");
            //    arList.Add("to");
            //    arList.Add("ArrayList");

            //    foreach (string ar in arList)
            //    {
            //        Console.Write(ar + " ");
            //    }

            

            //Car car1 = new Car();
            //car1.Make = "OldsMobile";
            //car1.Model = "Cutlas Supreme";

            //Or

            Car car1 = new Car() { Make = "OldsMobile", Model = "Cutlas Supreme" };
            Car car2 = new Car() { Make = "BMW", Model = "745i" };
            Car car3 = new Car() { Make = "Nissan", Model = "Maxima" };

            //Or

            List<Car> list = new List<Car>()
            {
                new Car() { Make = "OldsMobile", Model = "Cutlas Supreme" },
                new Car() { Make = "BMW", Model = "745i" },
                new Car() { Make = "Nissan", Model = "Maxima" }
            };

            //Car car2 = new Car();
            //car2.Make = "BMW";
            //car2.Model = "745i";

            //Book book = new Book();
            //book.Author = "Somebody";
            //book.Author = "Anybody";
            //book.Title = "A Book";

            //    ArrayList arList = new ArrayList();
            //    arList.Add(car1);
            //    arList.Add(car2);
            //    arList.Add(book);
            //    arList.Remove(book);

            //    foreach (var item in arList)
            //    {
            //        //Type casting - a book type can't cast in this case - throws an error

            //        Console.WriteLine(((Car)item).Make);
            //    }
            //}

            //Generics - Strongly Typed - types can't be mixed

            //Collections -List

            //List<Car> myList = new List<Car>();
            //myList.Add(car1);
            //myList.Add(car2);
            ////myList.Add(book);
            //foreach (Car car in myList)
            //{
            //    Console.WriteLine(car.Model);
            //    Console.WriteLine(car.Make);
            //}

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            
            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);
            
           
                Console.WriteLine(myDictionary["BMW"].Model);
                Console.WriteLine(myDictionary["OldsMobile"].Model);
            

        }
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
