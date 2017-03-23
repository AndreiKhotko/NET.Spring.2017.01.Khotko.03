using System;
using NUnit.Framework;
using WorkingWithTypesAndMethods;

namespace TasksNUnitTest
{
    [TestFixture]
    public class Task3Tests
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 15)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -6)]
        public int Task3_PositiveTest(int firstNumber, int secondNumber, int startIndex, int endIndex)
        {
            return Tasks.Task3(firstNumber, secondNumber, startIndex, endIndex);
        }

        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 31, 5)]
        [TestCase(8, 15, 5, 31)]
        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        public void Task3_ShouldThrowArgumentException(int firstNumber, int secondNumber, int startIndex, int endIndex)
        {
            Assert.Throws<ArgumentException>(() => Tasks.Task3(firstNumber, secondNumber, startIndex, endIndex));
        }


    }
}
