using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[][]][][[][[]]]"));
        }

        [TestMethod]
        public void OnlyBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[[][[][[[[][]]]]]]]]"));
        }

        [TestMethod]
        public void OnlyBracketsStartWithCloseReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void BracketsWithStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("aslk[saf]fadf"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("as[l]k[saf]fadf[]"));
        }

        [TestMethod]
        public void BracketsWithStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("aslk[saf]fadf]"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[[[aslk[saf]fadf]"));
        }
        [TestMethod]
        public void BracketsInStringWrongOrderReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("asl]k[saffadf"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("asl]k[s]]af[[[fa]df"));
        }
    }
}
