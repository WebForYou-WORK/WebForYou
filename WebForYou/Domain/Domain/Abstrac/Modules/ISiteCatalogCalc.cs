using System.Collections.Generic;
using Domain.Entityes.Modules;

namespace Domain.Abstrac.Modules
{
    public interface ISiteCatalogCalc
    {
        IEnumerable<SiteCatalogCalc> CalcCatalogSites { get; }
        void SaveModule(SiteCatalogCalc catalogCalc);
        void RemoveModule(int moduleId);
    }
}
