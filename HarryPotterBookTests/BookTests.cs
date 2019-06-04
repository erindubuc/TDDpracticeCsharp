using HarryPotterBooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterBookTests
{
    /* To try and encourage more sales of the 5 different Harry
        Potter books they sell, a bookshop has decided to offer
        discounts of multiple-book purchases.

        One copy of any of the five books costs 8 USD.

        If, however, you buy two different books, you get a 5%
        discount on those two books.

        If you buy 3 different books, you get a 10% discount.

        If you buy 4 different books, you get a 20% discount.

        If you go the whole hog, and buy all 5, you get a huge 25%
        discount.

        Note that if you buy, say, four books, of which 3 are
        different titles, you get a 10% discount on the 3 that
        form part of a set, but the fourth book still costs 8 USD.

        Your mission is to write a piece of code to calculate the
        price of any conceivable shopping basket (containing only
        Harry Potter books), giving as big a discount as possible.

        For example, how much does this basket of books cost?

        2 copies of the first book
        2 copies of the second book
        2 copies of the third book
        1 copy of the fourth book
        1 copy of the fifth book

        Answer: 51.60 USD
    */

    [TestFixture]

    public class BookTests
    {
        
        [Test]
        public void CostOfBuyingOneBook_ReturnsEightDollars()
        {
            BookStore _bookstore = new BookStore();
            int numOfBooks = 1;
            string[] bookTitles = new string[] { "Sorcerer's Stone" };
            double expected = 8;
            double actual = _bookstore.CostOfBooksPurchase(numOfBooks, bookTitles);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuyTwoDifferentTitles_ReturnCostWithFivePercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[2] { "Sorcerer's Stone", "Cursed Child" };
            int numOfBooks = 2;
            double expected = 15;
            double actual = _bookstore.CostOfBooksPurchase(numOfBooks, bookTitles);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuyThreeDifferentTitles_ReturnCostWithTenPercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[3] { "Sorcerer's Stone", "Cursed Child", "Half-Blood Prince" };
            int numOfBooks = 3;
            double expected = 23;
            double actual = _bookstore.CostOfBooksPurchase(numOfBooks, bookTitles);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuyFourDifferentTitles_ReturnCostWithTwentyPercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[4] { "Sorcerer's Stone", "Cursed Child", "Half-Blood Prince", "Goblet of Fire" };
            int numOfBooks = 4;
            double expected = 31;
            double actual = _bookstore.CostOfBooksPurchase(numOfBooks, bookTitles);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuyFiveDifferentTitles_ReturnCostWithTwentyFivePercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[5] { "Sorcerer's Stone", "Cursed Child", "Half-Blood Prince",
                "Goblet of Fire", "Chamber of Secrets" };
            int numOfBooks = 5;
            double expected = 39;

            Assert.AreEqual(expected, _bookstore.CostOfBooksPurchase(numOfBooks, bookTitles));
        }

        [Test]
        public void BuyThreeBooks_TwoTitlesSameOneDifferent_ReturnFivePercentDiscountPlusEight()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[3] { "Sorcerer's Stone", "Cursed Child", "Cursed Child" };
            int numOfBooks = 3;
            double expected = 23;

            Assert.AreEqual(expected, _bookstore.CostOfBooksPurchase(numOfBooks, bookTitles));
        }

        [Test]
        public void BuyFourBooks_ThreeTitlesDifferent_ReturnTenPercentDiscountPlusEight()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[4] { "Sorcerer's Stone", "Goblet of Fire", "Cursed Child", "Cursed Child" };
            int numOfBooks = 4;
            double expected = 31;

            Assert.AreEqual(expected, _bookstore.CostOfBooksPurchase(numOfBooks, bookTitles));
        }

        [Test]
        public void BuyFiveBooks_FourTitlesDifferent_ReturnTenPercentDiscountPlusEight()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[5] { "Sorcerer's Stone", "Half-blood Prince", "Goblet of Fire", "Cursed Child", "Cursed Child" };
            int numOfBooks = 5;
            double expected = 39;

            Assert.AreEqual(expected, _bookstore.CostOfBooksPurchase(numOfBooks, bookTitles));
        }

        [Test]
        public void UseDecimal_Returns8Dollars()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[1] { "Sorcerer's Stone"};
            //int numOfBooks = 5;
            decimal expected = 8.00m;

            Assert.AreEqual(expected, _bookstore.GetTotalPriceToPayForHarryPotterBooks(bookTitles));
        }

        [Test]
        public void UseDictionaryForTwoDifferentTitles_ReturnCostWithFivePercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[2] { "Sorcerer's Stone", "Half-Blood Prince" };
            //int numOfBooks = 5;
            decimal expected = 15.20m;

            Assert.AreEqual(expected, _bookstore.GetTotalPriceToPayForHarryPotterBooks(bookTitles));
        }

        [Test]
        public void DictionaryForThreeDifferentTitles_ReturnCostWithTenPercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[3] { "Sorcerer's Stone", "Half-Blood Prince", "Goblet of Fire" };
            decimal expected = 21.60m;

            Assert.AreEqual(expected, _bookstore.GetTotalPriceToPayForHarryPotterBooks(bookTitles));

        }

        [Test]
        public void DictionaryForFourDifferentTitles_ReturnCostWithTwentyPercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[4] { "Sorcerer's Stone", "Half-Blood Prince", "Goblet of Fire", "Chamber of Secrets" };
            decimal expected = 25.60m;

            Assert.AreEqual(expected, _bookstore.GetTotalPriceToPayForHarryPotterBooks(bookTitles));

        }

        [Test]
        public void DictionaryForFiveDifferentTitles_ReturnCostWithTwentyFivePercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[5] { "Sorcerer's Stone", "Half-Blood Prince", "Goblet of Fire", "Chamber of Secrets", "Prisoner of Azkaban" };
            decimal expected = 30.00m;

            Assert.AreEqual(expected, _bookstore.GetTotalPriceToPayForHarryPotterBooks(bookTitles));

        }

        [Test]
        public void BuyTwoTitlesThatAreSame_ReturnCostWithTwentyFivePercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[2] { "Sorcerer's Stone", "Sorcerer's Stone" };
            decimal expected = 16.00m;

            Assert.AreEqual(expected, _bookstore.GetTotalPriceToPayForHarryPotterBooks(bookTitles));

        }

        [Test]
        public void BuyThreeTitles_TwoThatAreSame_ReturnCostWithFivePercentDiscount()
        {
            BookStore _bookstore = new BookStore();
            string[] bookTitles = new string[3] { "Sorcerer's Stone", "Sorcerer's Stone", "Chamber of Secrets" };
            decimal expected = 23.20m;

            Assert.AreEqual(expected, _bookstore.GetTotalPriceToPayForHarryPotterBooks(bookTitles));

        }
    }

}


