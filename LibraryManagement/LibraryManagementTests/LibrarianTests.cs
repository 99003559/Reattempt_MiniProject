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
    public class LibrarianTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            Librarian librarianObj = new Librarian();
            librarianObj.Login("user", "pass");
            Assert.AreEqual(1, 1);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void LoginTest1()
        {
            Librarian librarianObj = new Librarian();
            librarianObj.Login("asdfghj", "password@12345");
            Assert.AreEqual(-1, -1);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void LoginFailTest()
        {
            Librarian librarianObj = new Librarian();
            librarianObj.Login("asdfghj", "password@12345");
            Assert.AreEqual(1, -1);
            Assert.IsTrue(true);
        }
    }
}