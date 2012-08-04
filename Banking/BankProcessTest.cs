using Banking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBank
{
    
    [TestClass()]
    public class BankProcessTest
    {

        BankProcess btest = new BankProcess();

        [TestMethod()]
        public void doProcessTest()
        {
            // Shall pass in test.
            // Passará no teste.
            string expected = "1 Em nota de 1 ";

            Assert.AreEqual(expected, btest.doProcess(1));
        }


        [TestMethod()]
        public void doProcessTest2()
        {
            // Shall pass in test.
            // Passará no teste.
            string expected = "1 Em nota de 10 1 Em nota de 2 ";

            Assert.AreEqual(expected, btest.doProcess(12));
        }

        [TestMethod()]
        public void doProcessTest3()
        {
            // Shall pass in test.
            // Passará no teste.
            string expected = "12 Em nota de 100 2 Em nota de 20 1 Em nota de 5 2 Em nota de 2 ";

            Assert.AreEqual(expected, btest.doProcess(1249));
        }

        [TestMethod()]
        public void doProcessTest4()
        {
            // Shall not pass in test.
            // Este deverá não passar no teste.
            string expected = "1 Em nota de 20 ";

            Assert.AreEqual(expected, btest.doProcess(21));
        }
    }
}
