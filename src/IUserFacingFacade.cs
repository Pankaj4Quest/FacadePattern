using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal interface IUserFacingFacade
    {
        public int AddToCart(int itemId, int quantity);
        public int PlaceOrder(int cartId, int userId);
    }
}
