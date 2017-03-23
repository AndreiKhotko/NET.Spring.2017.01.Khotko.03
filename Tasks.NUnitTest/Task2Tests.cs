using System;
using NUnit.Framework;
using WorkingWithTypesAndMethods;

namespace TasksNUnitTest
{
    [TestFixture]
    public class Task2Tests
    {
        [TestCase("", "aabbc",ExpectedResult = "abc")]
        [TestCase("aa", "zz", ExpectedResult = "az")]
        [TestCase("azb", "axyz", ExpectedResult = "abxyz")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "cba", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        [TestCase("cccbaa", "cccbaa", ExpectedResult = "abc")]
        public string Task2_PositiveTest(string str1, string str2)
        {
            return Tasks.Task2(str1, str2);
        }

        [TestCase(null, "Case")]
        [TestCase("Test", null)]
        public void Task2_NullString_ShouldThrowArgumentNullException(string str1, string str2)
        {
            Assert.Throws<ArgumentNullException>(() => Tasks.Task2(str1, str2));
        }

        [TestCase("Тест", "Кейс")]
        [TestCase("$$$", "fff")]
        [TestCase("124", "case")]
        public void Task2_InputHasBannedSymbols_ShouldThrowArgumentException(string str1, string str2)
        {
            Assert.Throws<ArgumentException>(() => Tasks.Task2(str1, str2));
        }
    }
}
