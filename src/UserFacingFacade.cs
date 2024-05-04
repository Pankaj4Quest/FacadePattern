using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class UserFacingFacade : IUserFacingFacade
    {
        public int AddToCart(int itemId, int quantity)
        {
            throw new NotImplementedException();
        }

        public int PlaceOrder(int cartId, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
