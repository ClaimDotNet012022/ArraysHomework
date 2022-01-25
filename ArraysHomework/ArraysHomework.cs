using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ArraysHomework
{
    [TestClass]
    public class ArraysHomework
    {
        [TestMethod]
        public void Arrays()
        {
            // Create an array of ints of size 100
            int[] myArray = new int[100];
            Assert.IsTrue(myArray.Length == 100);

            // take the array made above and fill it so these tests pass  
            myArray[0] = 100;
            myArray[50] = 150;
            myArray[68] = 168;
            Assert.IsTrue(myArray[0] == 100);
            Assert.IsTrue(myArray[50] == 150);
            Assert.IsTrue(myArray[68] == 168);

            // fill all of the values in to make the loop on line 28 pass as is.
            // Do not edit the loop that assert the passing case. Instead, add code above it to make it pass.

            // hint you need some form of repetition.
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)        // Don't edit from HERE
            {                                               //
                myArray[i] = 10;                            //
                Assert.IsTrue(myArray[i] == 10);            // to HERE
                sum++;
            }


            // what wrong with this array declaration? Fix it and make it compile
            string[] stringArray = new string[5];

            // What about this one? Fix it and make it compile
            bool[] boolArray = new bool[5];

            // What about this one? Fix it and make it compile
            bool[] boolArray2 = new bool[20];

            // Take this array and copy its contents into a new array 
            char[] copyMe = { 'a', 'b', 'c' };
            char[] copiedArray = new char[3];

            copiedArray[0] = 'a';
            copiedArray[1] = 'b';
            copiedArray[2] = 'c';


            Assert.IsTrue(copiedArray.Length == copyMe.Length);
            Assert.IsTrue(copiedArray[0] == 'a');
            Assert.IsTrue(copiedArray[1] == 'b');
            Assert.IsTrue(copiedArray[2] == 'c');

            // Swap the last and first value of this array.
            string[] swapMyValues = { "first", "middle", "last" };

            string save0Value = swapMyValues[0];
            string save2Value = swapMyValues[2];
            swapMyValues[0] = save2Value;
            swapMyValues[2] = save0Value;   

            Assert.IsTrue(swapMyValues[0] == "last");
            Assert.IsTrue(swapMyValues[2] == "first");



            //Combine these two arrays into a 3rd array (put your code after the for loop);
            int[] array1 = new int[25];
            int[] array2 = new int[25];

            // just a little fun to fill them
            int up = 0;
            int down = 24;
            for (; up < array1.Length && down >= 0; up++, down--)
            {
                array1[up] = up;
                array2[down] = down;

            }

            int[] combined = new int[50];

            for (int i = 0; i < array1.Length; i++)
            {
                combined[i] = array1[i];
            }
            int j = 0;
            for (int i = 25; i < combined.Length && i > 24;  i++)
            {
                combined[i] = array2[j];
                j++;
            }

            // Your code here: combine array1 and array2 into an array named combined
            // Everything from array1 should be in the first half of combined, and everything
            // from array2 should be in the second half of combined.


            Assert.IsTrue(combined.Length == 50);
            Assert.IsTrue(combined[0] == array1[0]);
            Assert.IsTrue(combined[24] == array1[24]);
            Assert.IsTrue(combined[25] == array2[0]);
            Assert.IsTrue(combined[49] == array2[24]);
        }


        [TestMethod]
        public void Lists()
        {
            // Create a List of ints named my list

            List<int> myList = new List<int>();

            Assert.IsTrue(myList != null); // if you create it right, this will pass

            // Don't worry about how this line works. It's not something you need at this point.
            // All it's doing is making sure that you actually created a List of ints (rather than, for example, an array of ints).
            Assert.IsTrue(myList.GetType() == typeof(List<int>));

            // take the list made above and fill it so these test passes  

            myList.Add(21);
            myList.Add(35);
            myList.Add(78);

            Assert.IsTrue(myList[0] == 21);
            Assert.IsTrue(myList[1] == 35);
            Assert.IsTrue(myList[2] == 78);

            // what wrong with this list declaration? You can use any type for its content. Fix it and make it compile
            List<string> stringList = new List<string>();

            // What about this one? You can use any type for its content. Fix it and make it compile
            List<int> list1 = new List<int>();

            // What about this one? You can use any type for its content. Fix it and make it compile
            List<int> list2 = new List<int>();

            // What about this one? You can use any type for its content. Fix it and make it compile
            List<char> list3 = new List<char>();

            // Take this list and copy its contents into a new list 
            List<char> copyMe = new List<char>() { 'a', 'b', 'c' };
            List<char> copiedList = new List<char>();

            copiedList.Add('a');
            copiedList.Add('b');
            copiedList.Add('c');

            Assert.IsTrue(copiedList.Count == copyMe.Count);
            Assert.IsTrue(copiedList[0] == 'a');
            Assert.IsTrue(copiedList[1] == 'b');
            Assert.IsTrue(copiedList[2] == 'c');

            // Swap the last and first value of this list.
            List<string> swapMyValues = new List<string> { "first", "middle", "last" };

            string save0Value = swapMyValues[0];
            string save2Value = swapMyValues[2];
            swapMyValues[0] = save2Value;
            swapMyValues[2] = save0Value;

            Assert.IsTrue(swapMyValues[0] == "last");
            Assert.IsTrue(swapMyValues[2] == "first");

            //Combine these two lists by absorbing copy1 into copy2 (so in the end, the first half of copy2
            //is everything that was already in copy2, and the second half is everything that's in copy1.
            // Put your code after the for loop.
            List<int> copy1 = new List<int>();
            List<int> copy2 = new List<int>();

            // just a little fun to fill them
            int up = 0;
            int down = 24;
            for (; up < 25 && down >= 0; up++, down--)
            {
                copy1.Add(up);
                copy2.Add(down);
            }

            // Your code here: combine copy1 into copy 2

            int sum = 0;
            for (int i = 25; i < 50; i++)
            {
                copy2.Add(sum);
                sum++;
            }

            Assert.IsTrue(copy2.Count == 50);


            // this is just a fun little section to explore the various methods on a list object.
            // they are not counting against you because we have not yet covered methods.
            // to access the lists methods use the dot operator similar to console.writeline();

            // bonus reverse this list
            List<int> reverseMe = new List<int>() { 1, 2, 3, 4, 5 };
            reverseMe.Reverse();

            Assert.IsTrue(reverseMe[0] == 5);
            Assert.IsTrue(reverseMe[1] == 4);
            Assert.IsTrue(reverseMe[2] == 3);
            Assert.IsTrue(reverseMe[3] == 2);
            Assert.IsTrue(reverseMe[4] == 1);

            // ---------

            // BONUS sort this list
            List<int> sortMe = new List<int>() { 14, 3, 33, 2, 12 };
            sortMe.Sort();

            Assert.IsTrue(sortMe[0] == 2);
            Assert.IsTrue(sortMe[1] == 3);
            Assert.IsTrue(sortMe[2] == 12);
            Assert.IsTrue(sortMe[3] == 14);
            Assert.IsTrue(sortMe[4] == 33);

            // ----------

            // BONUS Convert sortMe to an array

            int[] sortArray = sortMe.ToArray();

            // ----------

            // BONUS Check if sortMe Contains the value 2.

            sortMe.Contains(2);

            // ----------

            // BONUS Remove all of sort mes values

            sortMe.Clear();

            Assert.IsTrue(sortMe.Count == 0);

        }
    }
}

