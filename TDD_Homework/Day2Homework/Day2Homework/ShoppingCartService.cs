using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2Homework
{
    public class ShoppingCartService
    {
        public int CalculateTotalAmount(List<OrderBookInfo> orderBookInfo)
        {
            var bookHarryPotterEpisodeCountList = orderBookInfo.GroupBy(info => info.BookID)
                        .Select(group => new { BookID = group.Key, Count = group.Count() })
                        .OrderByDescending(x => x.Count);
            int returnValue = 0;
            float discount = 1;
            for (int i = bookHarryPotterEpisodeCountList.First().Count; i > 0 ; i--)
            {
                int bookCount = bookHarryPotterEpisodeCountList.Where(item => item.Count / i >= 1).Count();
                discount = GetDiscount(bookCount);
                returnValue += Convert.ToInt32((int)bookCount * discount * 100);
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