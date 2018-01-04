using System.Collections.Generic;
using Domain.Entityes.Modules;

namespace Domain.Abstrac.Modules
{
    public interface ICorporateWebsiteCalc
    {
        IEnumerable<CorporateWebsiteCalc> CalcCorporateSites { get; }
        void SaveModule(CorporateWebsiteCalc corporateWebsiteCalc);
        void RemoveModule(int moduleId);
    }
}
