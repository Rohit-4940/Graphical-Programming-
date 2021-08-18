using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit_testing;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace unit_testing.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void TestExceptionCase()
        {
            BankAccount bk = new BankAccount("Rohit", 0);
            try
            {
                bk.debit(2);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "amount <= 0 or amount > balance");
                return;
            }
            catch(Exception e)
            {
                StringAssert.Contains(e.Message, "balance = 0");
                return;

            }
            Assert.Fail("error fail");
        }
        [TestMethod()]

        public void TestCreditCase()
        {
            BankAccount bank = new BankAccount("Rohit", 2);
            bank.credit(2);
            Assert.AreEqual(4 ,bank.balance);
        }
        [TestMethod()]

        public void TestDebitCase()
        {
            BankAccount bank = new BankAccount("Rohit", 2);
            bank.debit(2);
            Assert.AreEqual(0, bank.balance);
        }
        [TestMethod()]

        public void TestCreditDebitCase()
        {
            BankAccount bank = new BankAccount("Rohit", 2);
            bank.debit(2);
            bank.credit(2);
            Assert.AreEqual(2, bank.balance);
        }
    }
}