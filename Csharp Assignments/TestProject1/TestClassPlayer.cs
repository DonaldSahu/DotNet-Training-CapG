using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectTestDemo;

namespace TestProject1
{
    [TestClass]
    public class TestClassPlayer
    {
        [TestMethod]
        [TestCategory("Player")]
        public void TestMethod1()
        {
            var p = new Player();
            Assert.IsTrue(p.isNoob);
        }
        [TestMethod]
        [TestCategory("Player")]
        public void TestMethod2NickName()
        {
            var p = new Player();
            Assert.IsNull(p.nickName);
        }

        [TestMethod]
        public void TestMethod3health()
        {
            var p = new Player();
            Assert.AreEqual(100,p.health);
        }

        [TestMethod]
        //[Ignore]
        //[Ignore("Temporary Disabled")]
        public void TestMethod4fullName()
        {
            var p = new Player();
            Assert.AreEqual("Donald Sahu", p.fullName);
            //Assert.IsTrue( p.fullName.StartsWith("Donald"));
        }

        [TestMethod]
        public void TestMethod5startswith()
        {
            var p = new Player();
            StringAssert.StartsWith(p.fullName, "Donald");
        }

        [TestMethod]
        public void TestMethod6endswith()
        {
            var p = new Player();
            StringAssert.EndsWith(p.fullName, "Sahu");
        }
    }
}
