using System.Collections.Generic;
using SpaceCart.Models.Database;

namespace SpaceCart.Models.ViewModel
{
    public class UserPurchasesViewModel
    {
        public IEnumerable<Purchase> Purchases { get; set; }
    }
}
