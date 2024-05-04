using FacadePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubsystemsIntefaces
{
    internal interface IAddress
    {
        Address getAddressDetails(int addressId);
    }
}
