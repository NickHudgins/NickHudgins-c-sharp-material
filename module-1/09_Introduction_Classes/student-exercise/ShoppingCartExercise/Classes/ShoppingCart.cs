using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        public int TotalNumberOfItems { get; }
        public decimal TotalAmountOwed { get; }

        public ShoppingCart()
        {

        }
        public decimal GetAveragePricePerItem()
        {
            return TotalAmountOwed / TotalNumberOfItems;
        }


    }
}
