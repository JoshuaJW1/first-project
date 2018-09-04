using System;
using System.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using first_project;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTestCounter
    {
        Form1 myForm1 = new Form1();
        [TestMethod]
        public void TestMethod1()
        {
            myForm1.myGameCode.count += 1;
        }
    }
}
