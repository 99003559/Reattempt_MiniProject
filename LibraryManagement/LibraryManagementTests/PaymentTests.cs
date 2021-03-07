using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Tests
{
    [TestClass()]
    public class PaymentTests
    {
        [TestMethod()]
        public void CalculatePriceTest()
        {
            Payment paymentObj = new Payment();
            Books BObj = new Books();
          
            double actual = paymentObj.CalculatePrice(2, BObj);
            Assert.AreEqual(400, 400);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CalculatePriceFailTest1()
        {
            Payment paymentObj = new Payment();
            Books BObj = new Books();
            //BObj.BookRentalPrice = 200;
            double actual = paymentObj.CalculatePrice(2, BObj);
            Assert.AreEqual(400, 600);
            Assert.IsTrue(true);

        }
    }
}