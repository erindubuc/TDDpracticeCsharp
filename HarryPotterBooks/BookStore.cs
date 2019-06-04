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

        public double CostOfBooksPurchase(int numOfBooks,string[] bookTitles)
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

        public decimal GetTotalPriceToPayForHarryPotterBooks(string[] bookTitles)
        {
            decimal totalCost = 8.00m;
            int quantityOfBooksWithDifferentTitles = 0;
            int numOfBooksWithNoDiscount = 0;
            decimal twoTitleDiscount = 0.05m;
            decimal threeTitleDiscount = 0.10m;
            decimal fourTitleDiscount = 0.20m;
            decimal fiveTitleDiscount = 0.25m;

            Dictionary<string, int> potterBooks = new Dictionary<string, int>();

            foreach(var title in bookTitles)
            {
                if (potterBooks.ContainsKey(title))
                    potterBooks[title]++;
                else
                    potterBooks.Add(title, 1);
            }
            // Sum of Values
            var totalNumOfBooksPurchased = potterBooks
                .Where(item => potterBooks.ContainsKey(item.Key))
                .Sum(item => item.Value);

            // Get values  
            Dictionary<string, int>.ValueCollection quantityOfTitles = potterBooks.Values;
            foreach (int val in quantityOfTitles)
            {
                if (val < 2)
                    quantityOfBooksWithDifferentTitles += val;

                else
                {
                    quantityOfBooksWithDifferentTitles += 1;
                    numOfBooksWithNoDiscount = val - 1;
                }

                
            }

            if (quantityOfBooksWithDifferentTitles == 1)
                return totalCost * numOfBooksWithNoDiscount + totalCost;

            if (quantityOfBooksWithDifferentTitles == 2)
            {
                if(totalNumOfBooksPurchased > quantityOfBooksWithDifferentTitles)
                    return (totalNumOfBooksPurchased - quantityOfBooksWithDifferentTitles) * totalCost + (totalCost * 2) - totalCost * 2 * twoTitleDiscount;

                if (numOfBooksWithNoDiscount == 0)
                    return (totalCost * 2) - (totalCost * 2) * twoTitleDiscount;
            }
                

            if(quantityOfBooksWithDifferentTitles == 3)
                return (totalCost * 3) - (totalCost * 3) * threeTitleDiscount;

            if (quantityOfBooksWithDifferentTitles == 4)
                return (totalCost * 4) - (totalCost * 4) * fourTitleDiscount;

            if (quantityOfBooksWithDifferentTitles == 5)
                return (totalCost * 5) - (totalCost * 5) * fiveTitleDiscount;

            return totalCost;

        }

    }
}
