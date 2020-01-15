using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Tests
{

    [TestClass()]
    public class DOMTests
    {
        
        DOM dom = new DOM();

        [TestMethod()]
        public void WeightRangeTest()
        {
            string str1 = "210";
            string str2 = "<300";

            Assert.IsTrue(dom.WeightRange(str1, str2));
        }

        [TestMethod()]
        public void PriceRangeTest()
        {
            string str1 = "85";
            string str2 = ">50";

            Assert.IsTrue(dom.PriceRange(str1, str2));
        }
    }
}