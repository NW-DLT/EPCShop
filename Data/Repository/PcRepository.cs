using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPCShop.Data.Interfaces;
using EPCShop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EPCShop.Data.Repository
{
    public class PcRepository : IAllPcs
    {
        private readonly AppDBContent appDBContent;

        public PcRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        ActionResult<Pc> IAllPcs.getObjectPc(int PcID) => appDBContent.Pc.FirstOrDefault(p => p.id == PcID);


        IEnumerable<Pc> IAllPcs.GetPcs() => appDBContent.Pc;
    }
}
