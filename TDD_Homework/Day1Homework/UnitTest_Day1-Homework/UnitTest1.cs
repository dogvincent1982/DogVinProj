using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day1Homework;
using System.Collections.Generic;

namespace UnitTest_Day1_Homework
{
    [TestClass]
    public class UnitTest1
    {
        #region 初始化測試資料
        private List<Product> productList = new List<Product>()
        {
            new Product()
            {
                ID=1, Cost=1, Revenue=11, SelePrice=21
            },
            new Product()
            {
                ID=2, Cost=2, Revenue=12, SelePrice=22
            },
            new Product()
            {
                ID=3, Cost=3, Revenue=13, SelePrice=23
            },
            new Product()
            {
                ID=4, Cost=4, Revenue=14, SelePrice=24
            },
            new Product()
            {
                ID=5, Cost=5, Revenue=15, SelePrice=25
            },
            new Product()
            {
                ID=6, Cost=6, Revenue=16, SelePrice=26
            },
            new Product()
            {
                ID=7, Cost=7, Revenue=17, SelePrice=27
            },
            new Product()
            {
                ID=8, Cost=8, Revenue=18, SelePrice=28
            },
            new Product()
            {
                ID=9, Cost=9, Revenue=19, SelePrice=29
            },
            new Product()
            {
                ID=10, Cost=10, Revenue=20, SelePrice=30
            },
            new Product()
            {
                ID=11, Cost=11, Revenue=21, SelePrice=31
            },
        };
        #endregion

        [TestMethod]
        public void Test三個一組的Cost加總()
        {
            MathService mathService = new MathService();
            List<int> actual = mathService.GetSumPropertyGroupByCount<Product>(productList, 3, "Cost");
            List<int> expected = new List<int>() { 6, 15, 24, 21 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test四個一組的Revenue加總()
        {
            MathService mathService = new MathService();
            List<int> actual = mathService.GetSumPropertyGroupByCount<Product>(productList, 4, "Revenue");
            List<int> expected = new List<int>() { 50, 66, 60 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
