using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2Homework
{
    public class ShoppingCartService
    {
        public int CalculateTotalAmount(List<BookInfo> buyBookList)
        {
            List<int> bookHarryPotterEpisodeCountList = SortHarryPotterBookList(buyBookList);
            int returnValue = 0;
            float discount = 1;
            for (int i = bookHarryPotterEpisodeCountList.Max(); i > 0 ; i--)
            {
                int bookCount = bookHarryPotterEpisodeCountList.Where(item => item / i >= 1).Count();
                discount = GetDiscount(bookCount);
                returnValue += Convert.ToInt32((int)bookCount * discount * 100);
            }
            return returnValue;
        }

        private List<int> SortHarryPotterBookList(List<BookInfo> buyBookList)
        {
            List < int > returnValue = new List<int> { 0, 0, 0, 0, 0 };
            foreach (BookInfo bookInfo in buyBookList)
            {
                switch (bookInfo.BookName)
                {
                    case "Harry Potter I":
                        returnValue[0]++;
                        break;
                    case "Harry Potter II":
                        returnValue[1]++;
                        break;
                    case "Harry Potter III":
                        returnValue[2]++;
                        break;
                    case "Harry Potter IV":
                        returnValue[3]++;
                        break;
                    case "Harry Potter V":
                        returnValue[4]++;
                        break;
                    default:
                        continue;

                }
            }
            return returnValue;
        }

        private float GetDiscount(int bookCount)
        {
            float returnValue = 1;
            switch (bookCount)
            {
                case 1:
                    returnValue = 1;
                    break;
                case 2:
                    returnValue = 0.95f;
                    break;
                case 3:
                    returnValue = 0.9f;
                    break;
                case 4:
                    returnValue = 0.8f;
                    break;
                case 5:
                    returnValue = 0.75f;
                    break;
                default:
                    returnValue = 0;
                    break;
            }
            return returnValue;
        }
    }
}