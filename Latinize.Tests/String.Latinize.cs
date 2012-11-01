using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Latinize.Tests
{
    [TestClass]
    public class LatinizeTests
    {
        [TestMethod]
        public void Removes_A_diaeresis()
        {
            string result = "ä".Latinize();
            Assert.AreEqual("a", result);
            result = "Ä".Latinize();
            Assert.AreEqual("A", result);
        }
        [TestMethod]
        public void Removes_A_accent_up()
        {
            string result = "á".Latinize();
            Assert.AreEqual("a", result);
            result = "Á".Latinize();
            Assert.AreEqual("A", result);
        }
        [TestMethod]
        public void Removes_A_accent_down()
        {
            string result = "à".Latinize();
            Assert.AreEqual("a", result);
            result = "À".Latinize();
            Assert.AreEqual("A", result);
        }
        [TestMethod]
        public void Removes_A_tilde()
        {
            string result = "ã".Latinize();
            Assert.AreEqual("a", result);
            result = "Ã".Latinize();
            Assert.AreEqual("A", result);
        }
        [TestMethod]
        public void Removes_AE()
        {
            string result = "æ".Latinize();
            Assert.AreEqual("a", result);
            result = "Æ".Latinize();
            Assert.AreEqual("A", result);
        }
        [TestMethod]
        public void Removes_AA()
        {
            string result = "å".Latinize();
            Assert.AreEqual("a", result);
            result = "Å".Latinize();
            Assert.AreEqual("A", result);
        }
        [TestMethod]
        public void Removes_A_hat()
        {
            string result = "â".Latinize();
            Assert.AreEqual("a", result);
            result = "Â".Latinize();
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void Removes_C_cedilla()
        {
            string result = "ç".Latinize();
            Assert.AreEqual("c", result);
            result = "Ç".Latinize();
            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void Removes_E_accent_up()
        {
            string result = "é".Latinize();
            Assert.AreEqual("e", result);
            result = "É".Latinize();
            Assert.AreEqual("E", result);
        }
        [TestMethod]
        public void Removes_E_accent_down()
        {
            string result = "è".Latinize();
            Assert.AreEqual("e", result);
            result = "È".Latinize();
            Assert.AreEqual("E", result);
        }
        [TestMethod]
        public void Removes_E_hat_down()
        {
            string result = "ê".Latinize();
            Assert.AreEqual("e", result);
            result = "Ê".Latinize();
            Assert.AreEqual("E", result);
        }
        [TestMethod]
        public void Removes_E_diaeresis_down()
        {
            string result = "ë".Latinize();
            Assert.AreEqual("e", result);
            result = "Ë".Latinize();
            Assert.AreEqual("E", result);
        }
        [TestMethod]
        public void Removes_E_breve()
        {
            string result = "ĕ".Latinize();
            Assert.AreEqual("e", result);
            result = "Ĕ".Latinize();
            Assert.AreEqual("E", result);
        }

        [TestMethod]
        public void Removes_OE()
        {
            string result = "ø".Latinize();
            Assert.AreEqual("o", result);
            result = "Ø".Latinize();
            Assert.AreEqual("O", result);
        }
        [TestMethod]
        public void Removes_OE_diaeresis()
        {
            string result = "ö".Latinize();
            Assert.AreEqual("o", result);
            result = "Ö".Latinize();
            Assert.AreEqual("O", result);
        }
    }
}
