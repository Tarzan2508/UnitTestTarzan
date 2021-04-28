using System;
using NUnit.Framework;
using UnitTest;

namespace UnitTestTarzan
{
    [TestFixture]
    public class UnitTest1
    {

        People p = new People("dlogin", "pass", "name", 23143124);
        [Test]
        public void TestLogin()
        {
            Assert.AreEqual("dlogin", p.Login);
        }
        [Test]
        public void TestPassword()
        {
            Assert.AreEqual("pass", p.Password);
        }
        [Test]
        public void TestName()
        {
            Assert.AreEqual("name", p.Name);
        }
        [Test]
        public void TestPhone()
        {
            Assert.AreEqual(23143124, p.Phone);
        }

    }
}
