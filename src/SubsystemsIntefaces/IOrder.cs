using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubsystemsIntefaces
{
    internal interface IOrder
    {
        int placeOrder(int cartID, int AddressId);
    }
}
