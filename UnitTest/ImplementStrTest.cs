using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class ImplementStrTest
    {
        [TestMethod]
        public void HaystackEmpty()
        {
            var ImpStr = new ImplementStr();
            var haystack = string.Empty;
            var needle = "aa";
            Assert.AreEqual(-1, ImpStr.StrStr(haystack, needle));
        }

        [TestMethod]
        public void NeedleEmpty()
        {
            var ImpStr = new ImplementStr();
            var haystack = "aa";
            var needle = string.Empty;     
            Assert.AreEqual(0, ImpStr.StrStr(haystack, needle));
        }

        [TestMethod]
        public void NoNeedleInHaystack()
        {
            var ImpStr = new ImplementStr();
            var haystack = "Test";
            var needle = "aa";
            Assert.AreEqual(-1, ImpStr.StrStr(haystack, needle));
        }

        [TestMethod]
        public void FindNeedle()
        {
            var ImpStr = new ImplementStr();
            var haystack = "TestTest";
            var needle = "st";
            Assert.AreEqual(2, ImpStr.StrStr(haystack, needle));
        }

        [TestMethod]
        public void FindNeedle1()
        {
            var ImpStr = new ImplementStr();
            var haystack = "mississippi";
            var needle = "issip";
            Assert.AreEqual(4, ImpStr.StrStr(haystack, needle));
        }

        [TestMethod]
        public void NeedleLongerThanHaystack()
        {
            var ImpStr = new ImplementStr();
            var haystack = "Test";
            var needle = "Tests";
            Assert.AreEqual(-1, ImpStr.StrStr(haystack, needle));
        }

        [TestMethod]
        public void BothAreEmpty()
        {
            var ImpStr = new ImplementStr();
            var haystack = "";
            var needle = "";
            Assert.AreEqual(0, ImpStr.StrStr(haystack, needle));
        }

    }
}
