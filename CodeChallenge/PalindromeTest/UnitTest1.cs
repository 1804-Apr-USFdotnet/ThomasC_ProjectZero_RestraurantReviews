using System;
using Palindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool output = Palindrome.Palindrome.IsPalindrome("racecar");
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool output = Palindrome.Palindrome.IsPalindrome("Racecar");
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool output = Palindrome.Palindrome.IsPalindrome("1221");
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool output = Palindrome.Palindrome.IsPalindrome("never Odd, or Even");
            Assert.IsTrue(output);
        }
    }
}
