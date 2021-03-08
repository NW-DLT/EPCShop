using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using EPCShop.Data.Models; 

namespace EPCShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Pc.Any())
            { 
                content.Pc.AddRange(
                    new Pc {  Name = "Box", Price = 5000, img = "https://30.img.avito.st/640x480/6395174230.jpg" },
                    new Pc {  Name = "zxc", Price = 993, img = "https://30.img.avito.st/640x480/6395174230.jpg" },
                    new Pc {  Name = "monster", Price = 10000, img = "https://30.img.avito.st/640x480/6395174230.jpg" },
                    new Pc {  Name = "TrueGang", Price = 2500, img = "https://filearchive.cnews.ru/img/news/2017/08/30/predator600.jpg" }
                    );
            }
            content.SaveChanges();
        }
        
    }
}
