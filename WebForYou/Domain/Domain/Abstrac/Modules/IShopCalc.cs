using System.Collections.Generic;
using Domain.Entityes.Modules;

namespace Domain.Abstrac.Modules
{
    public interface IShopCalc
    {
        IEnumerable<ShopCalc> CalcShopSites { get; }
        void SaveModule(ShopCalc shopCalc);
        void RemoveModule(int moduleId);
    }
}
