using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPCShop.Data.Interfaces;
using EPCShop.Data.Models;

namespace EPCShop.Data.Mocks
{
    public class MockPcs : IAllPcs
    {
        public IEnumerable<Pc> Pcs 
        {
            get
            {
                return new List<Pc>
                {
                    new Pc { id = 1, Name="Box", Price=5000, img="https://30.img.avito.st/640x480/6395174230.jpg"},
                    new Pc { id = 2, Name="zxc", Price=993, img="https://30.img.avito.st/640x480/6395174230.jpg"},
                    new Pc { id = 3, Name="monster", Price=10000,img="https://30.img.avito.st/640x480/6395174230.jpg"},
                    new Pc { id = 4, Name="TrueGang", Price=2500, img="https://filearchive.cnews.ru/img/news/2017/08/30/predator600.jpg"}
                };
            }
        }

        public Pc getObjectPc(int PcID)
        {
            throw new NotImplementedException();
        }
    }
}
