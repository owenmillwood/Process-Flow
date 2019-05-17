using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using processFlow;
using xmlIO;

namespace processFlowTest {
  [TestClass]
  public class UnitTest1 {

    [TestMethod]
    public void TestMethod1() {
      Program.Main(new string[] { "flow1.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
      int[] required = new int[] { 1, 3,};
      List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
      Assert.AreEqual(required.Length, amounts.Count);
      for (int i = 0; i < amounts.Count; i++) {
        Assert.AreEqual(required[i], amounts[i]);
      }
    }

        [TestMethod]
        public void TestMethod2()
        {
            Program.Main(new string[] { "flow2.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 1, 1,};
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }


        [TestMethod]
        public void TestMethod3()
        {
            Program.Main(new string[] { "flow3.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 3, 3, };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            Program.Main(new string[] { "flow4.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 3, 3, };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            Program.Main(new string[] { "flow5.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 3, 1, };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            Program.Main(new string[] { "flow6.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 3 };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod7()
        {
            Program.Main(new string[] { "flow7.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 0, 3 };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod8()
        {
            Program.Main(new string[] { "flow8.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 0, 2 };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod9()
        {
            Program.Main(new string[] { "flow9.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 2, 2 };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod10()
        {
            Program.Main(new string[] { "flow10.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 3 };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod11()
        {
            Program.Main(new string[] { "flow11.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] {2,0,0,1,5,0};
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }

        [TestMethod]
        public void TestMethod12()
        {
            Program.Main(new string[] { "flow12.xml" });  // this file resides in processFlow\processFlowTest\bin\Debug
            int[] required = new int[] { 3 };
            List<int> amounts = ProcessFlowFactory.LoadOutput("out.xml");  // this file resides in processFlow\processFlowTest\bin\Debug
            Assert.AreEqual(required.Length, amounts.Count);
            for (int i = 0; i < amounts.Count; i++)
            {
                Assert.AreEqual(required[i], amounts[i]);
            }
        }       
    }
}
