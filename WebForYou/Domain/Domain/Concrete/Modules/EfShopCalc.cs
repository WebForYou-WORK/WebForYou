using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac.Modules;
using Domain.Entityes.Modules;

namespace Domain.Concrete.Modules
{
    public class EfShopCalc:IShopCalc
    {
        readonly CalcShopContext _context = new CalcShopContext();
        public IEnumerable<ShopCalc> CalcShopSites => _context.ShopCalcs;
        public void SaveModule(ShopCalc shopCalc)
        {
            if (shopCalc.ModuleId==0)
            {
                _context.ShopCalcs.Add(new ShopCalc
                {
                    ModuleCategory = shopCalc.ModuleCategory,
                    ModuleDescription = shopCalc.ModuleDescription,
                    ModuleName = shopCalc.ModuleName,
                    ModulePrice = shopCalc.ModulePrice
                });
                _context.SaveChanges();
            }
            else
            {
                ShopCalc editShopCalc = _context.ShopCalcs.FirstOrDefault(x => x.ModuleId == shopCalc.ModuleId);
                if (editShopCalc!=null)
                {
                    editShopCalc.ModuleName = shopCalc.ModuleName;
                    editShopCalc.ModuleCategory = shopCalc.ModuleCategory;
                    editShopCalc.ModuleDescription = shopCalc.ModuleDescription;
                    editShopCalc.ModulePrice = shopCalc.ModulePrice;
                    _context.SaveChanges();
                }
                else
                 throw new Exception();
            }
        }

        public void RemoveModule(int moduleId)
        {
            ShopCalc removeShopCalc = _context.ShopCalcs.FirstOrDefault(x => x.ModuleId == moduleId);
            if (removeShopCalc!=null)
            {
                _context.ShopCalcs.Remove(removeShopCalc);
                _context.SaveChanges();
            }
            else
             throw new Exception();
        }
    }
}
