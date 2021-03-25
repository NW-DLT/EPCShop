using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPCShop.Data.Models;

namespace EPCShop.Data.Interfaces
{
    public interface IAllPcs
    {
        Pc getObjectPc(int PcID);
        IEnumerable<Pc> GetPcs();
    }
}
