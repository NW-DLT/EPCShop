using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPCShop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EPCShop.Data.Interfaces
{
    public interface IAllPcs
    {
        ActionResult<Pc> getObjectPc(int PcID);
        IEnumerable<Pc> GetPcs();
    }
}
