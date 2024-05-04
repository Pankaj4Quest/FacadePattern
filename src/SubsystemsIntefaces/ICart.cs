using FacadePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubsystemsIntefaces
{
    internal interface ICart
    {
        Product getProductDetails(int itemId);
        bool isItemAvailable(Product product);
        bool lockItemsInStock(int itemId, int quantity);
        int AddItemsToCart(int itemId, int quantity);
        double getCartPrice(int cartId);
    }
}
