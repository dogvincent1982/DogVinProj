using System;
using System.Collections.Generic;

namespace Day2Homework
{
    public class ShoppingCartService
    {
        public int CalculateTotalAmount(List<BookInfo> buyBookList)
        {
            int returnValue = 0;
            foreach (BookInfo bookInfo in buyBookList)
            {
                if (bookInfo.BookName == "Harry Potter I")
                {
                    returnValue += 100;
                }
            }
            return returnValue;
        }
    }
}