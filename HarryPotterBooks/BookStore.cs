using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterBooks
{
    public class BookStore : IBookStore
    {
        public string bookTitle;

        public double CostOfBooksPurchase(int numOfBooks, string[] bookTitles)
        {
            double totalBookCost = 8;
            float discount = 0;
            float discountPrice = 0;

            if (numOfBooks == 1)
                return totalBookCost;

            if (numOfBooks == 2)
            {
                if (!(bookTitles[0].Equals(bookTitles[1])))
                {
                    discount = 5;
                    discountPrice = discount / 100;
                    return Math.Floor((totalBookCost * 2) - (double)discountPrice);
                }
                else
                    return totalBookCost * 2;
            }
                

            return totalBookCost;
        }

    }
}
