using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork.tests
{
    [TestFixture]
    class AssertionsTests
    {
        [Test]
        public void CompareTwoNumbers()
        {
            Assert.That(2 + 2, Is.EqualTo(4));
        }

        [Test]
        public void TwoStringsCompleteCoincidence()
        {
            string phrase = "Make your tests fail before passing!";
            Assert.That("Make your tests fail before passing!", Is.EqualTo(phrase));
        }

        [Test]
        public void TwoStringsPartialCoincidence()
        {
            string phrase = "Make your tests fail before passing!";
            Assert.That(phrase, Does.Contain("tests fail"));
        }

        [Test]
        public void CompareTwoArrays()
        {
            int[] array = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { 1, 2, 3 };
            Assert.That(array2, Is.EqualTo(array));
        }

        [Test]
        public void CompareTwoStringArrays()
        {
            string[] array = new string[] { "agf", "fs", "df" };
            string[] array2 = new string[] { "agf", "fs", "df" };
            Assert.That(array2, Is.EqualTo(array));
        }

    }
}
