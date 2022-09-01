using System;
using System.Collections.Generic;
using SpaceCart.Models.Database;

namespace SpaceCart.Models.ViewModel
{
    public class ShoppingCartModel
    {
        public IEnumerable<ShoppingCart> ShoppingCarts{ get; set; }
        public decimal TotalPrice { get; set; }
    }
}
