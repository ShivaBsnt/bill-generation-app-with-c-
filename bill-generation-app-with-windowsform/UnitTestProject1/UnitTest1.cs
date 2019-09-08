using System;
using gried_view_table;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyTestClass c = new MyTestClass();
            //arrang 
            int a = 10;
            int b = 20;

            //act
            int expected_result = 30;
            int actual_result;
             actual_result= c.multiply(a, b);

            //assert

            Assert.AreEqual(expected_result, actual_result);

        }
    }
}
