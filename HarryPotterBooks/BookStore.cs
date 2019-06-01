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
                    return Math.Floor((totalBookCost * 2) - discountPrice);
                }
                
            }

            if (numOfBooks == 3)
            {
                if (!(bookTitles[0].Equals(bookTitles[1])) && !(bookTitles[0].Equals(bookTitles[2])))
                {
                    discount = 10;
                    discountPrice = discount / 100;
                    return Math.Floor((totalBookCost * 3) - discountPrice);
                }
                if (!bookTitles[0].Equals(bookTitles[1]) && bookTitles[0].Equals(bookTitles[2]) ||
                    bookTitles[0].Equals(bookTitles[1]) && !bookTitles[0].Equals(bookTitles[2]))
                {
                    discount = 5;
                    discountPrice = discount / 100;
                    return Math.Floor((totalBookCost * 2) - discountPrice + 8);
                }
                
            }

            if (numOfBooks == 4)
            {
                if (!(bookTitles[0].Equals(bookTitles[1])) && !(bookTitles[0].Equals(bookTitles[2]) 
                    && !bookTitles[0].Equals(bookTitles[3])))
                {
                    discount = 20;
                    discountPrice = discount / 100;
                    return Math.Floor((totalBookCost * 4) - discountPrice);
                }
                
            }

            if (numOfBooks == 5)
            {
                if (!bookTitles[0].Equals(bookTitles[1]) && !bookTitles[0].Equals(bookTitles[2])
                    && !bookTitles[0].Equals(bookTitles[3]) && !bookTitles[0].Equals(bookTitles[4]))
                {
                    discount = 25;
                    discountPrice = discount / 100;
                    return Math.Floor((totalBookCost * 5) - discountPrice);
                }
                
            }


            return totalBookCost * numOfBooks;
        }

    }
}
