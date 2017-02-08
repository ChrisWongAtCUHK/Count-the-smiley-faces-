namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(Kata.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }), 4);
            Assert.AreEqual(Kata.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }), 2);
            Assert.AreEqual(Kata.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }), 1);
            Assert.AreEqual(Kata.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }), 0);
        }
    }
}

