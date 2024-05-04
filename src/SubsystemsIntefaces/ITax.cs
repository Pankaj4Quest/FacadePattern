using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubsystemsIntefaces
{
    internal interface ITax
    {
        double getTaxByState(string state);
        void applyTax(int cartId);
    }
}
