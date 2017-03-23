using System;
using NUnit.Framework;
using WorkingWithTypesAndMethods;

namespace TasksNUnitTest
{
    [TestFixture]
    public class Task1Tests
    {
        private static int[] arrayWith1000Elements;
        [OneTimeSetUp]
        public void Init()
        {
            arrayWith1000Elements = new int[1000];
        }

        [TestCase(null)]
        public void Task1_NullArray_ShouldThrowArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => Tasks.Task1(array));
        }

        [TestCase(new int[0] { })]
        [Test, TestCaseSource("arrayWith1000Elements")]
        public void Task1_ArrayLenthIsMoreThan1000AndLessThan1_ShouldThrowArgumentOutOfRangeException(int[] array)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Tasks.Task1(array));
        }

        [TestCase(new int[1] { 1 }, ExpectedResult = -1)]
        [TestCase(new int[2] { 1, 1 }, ExpectedResult = -1)]
        [TestCase(new int[2] { 1, 2 }, ExpectedResult = -1)]
        [TestCase(new int[6] { 1, 2, 3, 4, 5, 6}, ExpectedResult = -1)]
        [TestCase(new int[6] { 1, 2, 3, 3, 2, 1 }, ExpectedResult = -1)]
        public int Task1_NoSuchIndexInArray_ShouldReturnMinus1(int[] array)
        {
            return Tasks.Task1(array);
        }

        [TestCase(new int[3] { 1, 2, 1 }, ExpectedResult = 1)]
        [TestCase(new int[8] { 1, -1, -2, -5, -2, 1, 6, 0 }, ExpectedResult = 2)]
        [TestCase(new int[4] { 1, 2, 0, 1}, ExpectedResult = 1)]
        [TestCase(new int[5] { -2, -3, -12, -7, -17 }, ExpectedResult = 3)]
        public int Task1_PositiveTest(int[] array)
        {
            return Tasks.Task1(array);
        }
    }
}
