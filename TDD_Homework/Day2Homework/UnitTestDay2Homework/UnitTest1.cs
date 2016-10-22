using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Day2Homework;

namespace UnitTestDay2Homework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShoppingCart_BuyFirstEpisode_ReturnHundred()
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            List<BookInfo> buyBookList = new List<BookInfo>()
            {
                new BookInfo() { BookName = "Harry Potter I",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShoppingCart_BuyFirstAndSecondEpisode_Return190()
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            List<BookInfo> buyBookList = new List<BookInfo>()
            {
                new BookInfo() { BookName = "Harry Potter I",Amount=1},
                new BookInfo() { BookName = "Harry Potter II",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 190;
            Assert.AreEqual(expected, actual);
        }
    }
}
