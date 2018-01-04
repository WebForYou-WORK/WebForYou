using System.Collections.Generic;
using Domain.Entityes.Modules;

namespace Domain.Abstrac.Modules
{
    public interface IWebsiteCardCalc
    {
        IEnumerable<WebsiteCardCalc> CalcWebsiteCardSites { get; }
        void SaveModule(WebsiteCardCalc websiteCardCalc);
        void RemoveModule(int moduleId);
    }
}
