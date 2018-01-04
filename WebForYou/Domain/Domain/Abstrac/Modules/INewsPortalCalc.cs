using System.Collections.Generic;
using Domain.Entityes.Modules;

namespace Domain.Abstrac.Modules
{
    public interface INewsPortalCalc
    {
        IEnumerable<NewsPortalCalc> CalcNewsPortalSites { get; }
        void SaveModule(NewsPortalCalc newsPortalCalc);
        void RemoveModule(int moduleId);
    }
}
