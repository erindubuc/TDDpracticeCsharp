using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterBooks
{
    public interface IBookStore
    {
        double CostOfBooksPurchase(int quantity, string[] titles);
        
    }
}
