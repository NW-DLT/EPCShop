using EPCShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPCShop.ViewModels
{
    public class PcsListViewModel
    {
        public IEnumerable<Pc> allPcs { get; set; }
    }
}
