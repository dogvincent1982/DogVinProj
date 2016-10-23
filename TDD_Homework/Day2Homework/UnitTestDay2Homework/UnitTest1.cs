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

            List<OrderBookInfo> buyBookList = new List<OrderBookInfo>()
            {
                new OrderBookInfo() { BookName = "Harry Potter I",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShoppingCart_BuyFirstAndSecondEpisode_Return190()
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            List<OrderBookInfo> buyBookList = new List<OrderBookInfo>()
            {
                new OrderBookInfo() {BookID = 1, BookName = "Harry Potter I",Amount=1},
                new OrderBookInfo() {BookID = 2, BookName = "Harry Potter II",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShoppingCart_BuyFirstAndSecondAndThirdEpisode_Return270()
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            List<OrderBookInfo> buyBookList = new List<OrderBookInfo>()
            {
                new OrderBookInfo() {BookID = 1, BookName = "Harry Potter I",Amount=1},
                new OrderBookInfo() {BookID = 2, BookName = "Harry Potter II",Amount=1},
                new OrderBookInfo() {BookID = 3, BookName = "Harry Potter III",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShoppingCart_Buy1234Episode_Return320()
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            List<OrderBookInfo> buyBookList = new List<OrderBookInfo>()
            {
                new OrderBookInfo() {BookID = 1, BookName = "Harry Potter I",Amount=1},
                new OrderBookInfo() {BookID = 2, BookName = "Harry Potter II",Amount=1},
                new OrderBookInfo() {BookID = 3, BookName = "Harry Potter III",Amount=1},
                new OrderBookInfo() {BookID = 4, BookName = "Harry Potter IV",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShoppingCart_Buy12345Episode_Return375()
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            List<OrderBookInfo> buyBookList = new List<OrderBookInfo>()
            {
                new OrderBookInfo() {BookID = 1, BookName = "Harry Potter I",Amount=1},
                new OrderBookInfo() {BookID = 2, BookName = "Harry Potter II",Amount=1},
                new OrderBookInfo() {BookID = 3, BookName = "Harry Potter III",Amount=1},
                new OrderBookInfo() {BookID = 4, BookName = "Harry Potter IV",Amount=1},
                new OrderBookInfo() {BookID = 5, BookName = "Harry Potter V",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 375;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShoppingCart_Buy1233Episode_Return370()
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            List<OrderBookInfo> buyBookList = new List<OrderBookInfo>()
            {
                new OrderBookInfo() {BookID = 1, BookName = "Harry Potter I",Amount=1},
                new OrderBookInfo() {BookID = 2, BookName = "Harry Potter II",Amount=1},
                new OrderBookInfo() {BookID = 3, BookName = "Harry Potter III",Amount=1},
                new OrderBookInfo() {BookID = 3, BookName = "Harry Potter III",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 370;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShoppingCart_Buy12233Episode_Return460()
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            List<OrderBookInfo> buyBookList = new List<OrderBookInfo>()
            {
                new OrderBookInfo() {BookID = 1, BookName = "Harry Potter I",Amount=1},
                new OrderBookInfo() {BookID = 2, BookName = "Harry Potter II",Amount=1},
                new OrderBookInfo() {BookID = 2, BookName = "Harry Potter II",Amount=1},
                new OrderBookInfo() {BookID = 3, BookName = "Harry Potter III",Amount=1},
                new OrderBookInfo() {BookID = 3, BookName = "Harry Potter III",Amount=1}
            };
            int actual = shoppingCartService.CalculateTotalAmount(buyBookList);
            int expected = 460;
            Assert.AreEqual(expected, actual);
        }
    }
}
