using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2Homework
{
    public class ShoppingCartService
    {
        public int CalculateTotalAmount(List<BookInfo> buyBookList)
        {
            List<int> bookHarryPotterEpisodeCountList = new List<int>() { 0, 0, 0, 0, 0 };
            int returnValue = 0;
            float discount = 1;
            foreach (BookInfo bookInfo in buyBookList)
            {
                if (bookInfo.BookName == "Harry Potter I")
                {
                    bookHarryPotterEpisodeCountList[0]++;
                }
                else if (bookInfo.BookName == "Harry Potter II")
                {
                    bookHarryPotterEpisodeCountList[1]++;
                }
            }
            for (int i = bookHarryPotterEpisodeCountList.Max(); i > 0 ; i--)
            {
                int bookCount = bookHarryPotterEpisodeCountList.Where(item => item / i == 1).Count();
                switch (bookCount)
                {
                    case 1:
                        discount = 1;
                        break;
                    case 2:
                        discount = 0.95f;
                        break;
                    default:
                        continue;
                }
                returnValue += Convert.ToInt32((int)bookCount * discount * 100);
            }
            return returnValue;
        }
    }
}