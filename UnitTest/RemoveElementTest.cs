using Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class RemoveElementTest
    {
        [TestMethod]
        public void DoesNotContainElement()
        {
            var re = new RemoveElement();
            var list = new int[] { 3, 2, 3, 6, 4, 5 };
            var result = re.RemoveElem(list, 1);
            Assert.AreEqual(list.Count(), result);
        }

        [TestMethod]
        public void ContainElement()
        {
            var re = new RemoveElement();
            var list = new int[] { 3, 2, 3, 6, 4, 5 };
            var result = re.RemoveElem(list, 3);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void ContainOnlyElement()
        {
            var re = new RemoveElement();
            var list = new int[] { 3, 3};
            var result = re.RemoveElem(list, 3);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ListIsEmpty()
        {
            var re = new RemoveElement();
            var list = new int[] { };
            var result = re.RemoveElem(list, 3);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ContainOnlyOneElementAtTheEnd()
        {
            var re = new RemoveElement();
            var list = new int[] { 4,5};
            var result = re.RemoveElem(list, 5);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ContainOnlyOneElementAtTheBeginning()
        {
            var re = new RemoveElement();
            var list = new int[] { 4, 5 };
            var result = re.RemoveElem(list, 4);
            Assert.AreEqual(1, result);
        }
    }
}
