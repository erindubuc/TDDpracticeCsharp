using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterBooks
{
    public class BookStore : IBookStore
    {
        public string[] bookTitles;

        public decimal CostOfBooksPurchase(int numOfBooks, string[] bookTitles)
        {
            decimal totalBookCost = 8.00m;

            if (numOfBooks == 1)
                return totalBookCost;

            if (numOfBooks == 2)
            {
                if (!string.Equals(bookTitles[0], bookTitles[1]))
                    totalBookCost = (totalBookCost * 2) * (5 / 100);

                else
                    return totalBookCost * 2;
            }
                

            return totalBookCost;
        }

    }
}
